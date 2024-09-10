using Emgu.CV;
using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Tokens;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Diagnostics;
using Color = System.Drawing.Color;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace Fitzone.Front.Socios
{
    public partial class FrmPagarCuota : Form
    {
        public int _idSocio = 1;
        List<Membresia> _membresias = new List<Membresia>();
        Socio _socio;
        List<Cuota> _cuotas = new List<Cuota>();
        public FrmPagarCuota()
        {
            InitializeComponent();
        }

        #region redimensionar

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int BORDER_SIZE = 15; // Tamaño de los bordes para redimensionar
                                            //   // Funciones necesarias para permitir el movimiento del formulario
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x84) // WM_NCHITTEST
            {
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X < BORDER_SIZE && cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X < BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X < BORDER_SIZE)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }
        public void OnMouseDownForm(MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Permitir que el formulario se mueva cuando el usuario lo arrastre
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void FrmPagarCuota_Load(object sender, EventArgs e)
        {
            CargarSocio();
            CargarMembresia();
            CargarCuotas();
        }

        private void CargarMembresia()
        {
            MembresiaController membresiaController = new MembresiaController();
            _membresias = membresiaController.GetByIdSocioFechaTipoMembresia(_socio.idSocio, DateTime.Now) ?? new List<Membresia>();

            bindingSourceMembresia.DataSource = _membresias;
        }

        private void CargarSocio()
        {
            _socio = new SocioController().GetById(_idSocio) ?? new Socio();
            txtNombre.Text = _socio.NombreCompleto;
        }

        private void CargarCuotas()
        {
            if (bindingSourceMembresia.Current == null)
                return;

            int idMembresia = ((Membresia)bindingSourceMembresia.Current).idMembresia;

            CuotaController cuotaController = new CuotaController();

            _cuotas = new List<Cuota>();
            if (opPendientes.Checked)
                _cuotas = cuotaController.GetCuotasPendientesDePagoAlDia(idMembresia, Configuraciones.fechaHoy);

            if (opTodas.Checked)
                _cuotas = cuotaController.GetCuotasTodas(idMembresia, Configuraciones.fechaHoy);

            if (opProxima.Checked)
                _cuotas = cuotaController.GetCuotasPendientesDePagoTodas(idMembresia, Configuraciones.fechaHoy).OrderBy(c => c.fechaDesde).Take(1).ToList();

            bindingSourceCuotas.DataSource = _cuotas;
        }

        private void opPendientes_CheckedChanged(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        private void opTodas_CheckedChanged(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        private void opProxima_CheckedChanged(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var CuotasPagar = _cuotas.Where(c => c.seleccionada).ToList();

            if (CuotasPagar.Count == 0)
            {
                new MessageBoxCustom("Selecciona una o varias cuotas para pagar", EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }
            Factura f = new Factura();
            f.tipoFactura = "F";
            f.fecha = DateTime.Now;
            f.letra = "C";
            f.metodoDePago = cmbTipoPago.Text;
            f.numero = new FacturaController().getNumeroProximo();
            f.total = _cuotas.Where(c => c.seleccionada).Sum(c => c.precio);
            f.clienteNombre = _socio.NombreCompleto;
            f.clienteDireccion = String.Join(" ", _socio.calle, _socio.calleNumero, _socio.BarrioNombre);

            f.DetalleFactura = new List<DetalleFactura>();

            FacturaController facturaController = new FacturaController();
            foreach (var item in CuotasPagar)
            {
                DetalleFactura d = new DetalleFactura();
                d.idCuota = item.idCuota;
                d.cantidad = 1;
                d.precioUnitario = item.precio;
                d.total = item.precio * d.cantidad;
                d.descripcion = "Cuota " + Statics.GetMesAñoTexto(item.fechaVencimiento) + " - " + cmbTipoMembresia.Text.Substring(0, 15);

                f.DetalleFactura.Add(d);

            }



            //listo para guardar
            MessageBoxCustom msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            facturaController.Insert(f);

            new MessageBoxCustom(EnumModoMessageBoxCustom.DatosGuardadosCorrectamente).ShowDialog();
            CargarCuotas();
        }

        private void bindingSourceCuotas_CurrentItemChanged(object sender, EventArgs e)
        {

            txtTotal.Text = _cuotas.Where(c => c.seleccionada).Sum(c => c.precio).ToString();

        }
        private void bindingSourceMembresia_CurrentItemChanged(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // No se puede seleccionar cuotas que ya estan pagadas
            if (dataGridView1.Columns[e.ColumnIndex].Name == "seleccionadaCol")
            {
                // Obtén la fila actual
                var fila = dataGridView1.Rows[e.RowIndex];

                // Verifica si la columna 'pagada' es true
                if (Convert.ToBoolean(fila.Cells["pagadaCol"].Value) == true)
                {
                    // Si pagada es true, deshabilita la celda de checkbox
                    fila.Cells["seleccionadaCol"].ReadOnly = true;
                    fila.Cells["seleccionadaCol"].Style.BackColor = Color.LightGray;  // Opcional: Cambiar el color para indicar que está deshabilitado
                }
                else
                {
                    // Habilita el checkbox si no está pagada
                    fila.Cells["seleccionadaCol"].ReadOnly = false;
                    fila.Cells["seleccionadaCol"].Style.BackColor = Color.White;  // Restaurar color si es editable
                }
            }
            else           // pintar de rojo solo las vencidas
            if (dataGridView1.Columns[e.ColumnIndex].Name == "pagadaCol")
            {
                // Obtén la fila actual
                var fila = dataGridView1.Rows[e.RowIndex];

                // Verifica si la columna 'pagada' es true
                if (Convert.ToDateTime(fila.Cells["fechaVencimientoCol"].Value) > Statics.DateTimeNowSinHora()
                    || Convert.ToBoolean(fila.Cells["pagadaCol"].Value) == true)
                {
                    // Si pagada es true, deshabilita la celda de checkbox                    
                    fila.Cells["fechaVencimientoCol"].Style.BackColor = Color.LightGreen;  // Opcional: Cambiar el color para indicar que está deshabilitado
                }
                else
                {
                    // Habilita el checkbox si no está pagada                    
                    //  fila.Cells["seleccionadaCol"].Style.BackColor = Color.LightCyan;  // Restaurar color si es editable
                    //se pintan de rosa por diseño
                }
            }
        }

        private void Imprimir2(Factura fac)
        {
            var facturaDocument = new FacturaDocument(fac);

            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("Factura", "PDF");            
            facturaDocument.GeneratePdf(fileName);
            Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });

        }     

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            var f = new FacturaController().GetById(1);            
            Imprimir2(f);

        }
    }
}
