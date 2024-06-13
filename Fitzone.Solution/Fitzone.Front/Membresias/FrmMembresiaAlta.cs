using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;

namespace Fitzone.Front.Membresias
{
    public partial class FrmMembresiaAlta : Form
    {
        Socio? _Socio = null;
        TipoMembresia _tipoMembresiaSeleccionada = null;
        List<Cuota> _listaCuotas = new List<Cuota>();

        #region redimensionar

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int BORDER_SIZE = 5; // Tamaño de los bordes para redimensionar
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
        public FrmMembresiaAlta()
        {
            InitializeComponent();
        }

        private void FrmMembresia_Load(object sender, EventArgs e)
        {
            CargarTipos();
            txtFechaDesde.Value = Statics.DateTimeNowSinHora();
        }

        private void LimpiarControles()
        {
            _listaCuotas = new List<Cuota>();
            bindingSource1.DataSource = _listaCuotas;
            txtDescripcionMembresía.Text = "";

        }
        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Consulta;
            frm.ShowDialog();
            _Socio = frm._SocioSeleccionado;

            if (_Socio != null)
            {
                txtNombre.Text = _Socio.nombre;
                txtApellido.Text = _Socio.apellido;
                txtDocumento.Text = _Socio.numeroDocumento;
                txtTelefono.Text = _Socio.telefono1;
                txtDireccion.Text = _Socio.calle + " " + _Socio.calleNumero;
            }


        }


        private void CargarTipos()
        {
            MembresiaController membresiaController = new MembresiaController();
            bindingSource2.DataSource = membresiaController.GetAllTipoMembresia();
            RefreshTipoMembresia();
        }

        private void RefreshTipoMembresia()
        {
            if (bindingSource2.DataSource == null)
                return;

            if (bindingSource2.Current == null)
                return;

            _tipoMembresiaSeleccionada = (TipoMembresia)bindingSource2.Current;

            txtDetalleTipo.Text = _tipoMembresiaSeleccionada.descripcion;
            txtPrecio.Text = _tipoMembresiaSeleccionada.precioTotal.ToString();
            txtCuotas.Text = _tipoMembresiaSeleccionada.cantidadCuotas.ToString();
            txtCantDias.Text = _tipoMembresiaSeleccionada.cantidadDiasSemanales.ToString();

            string dias = _tipoMembresiaSeleccionada.diasHabilitados;
            chkLunes.Checked = dias.Contains("lunes");
            chkMartes.Checked = dias.Contains("martes");
            chkMiercoles.Checked = dias.Contains("miercoles");
            chkJueves.Checked = dias.Contains("jueves");
            chkViernes.Checked = dias.Contains("viernes");
            chkSabado.Checked = dias.Contains("sabado");

            CalcularFechasMembresia();

        }

        private void CalcularFechasMembresia()
        {
            try
            {
                txtFechaHasta.Value = txtFechaDesde.Value.AddMonths(Convert.ToInt16(txtCuotas.Text));
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void txtFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            CalcularFechasMembresia();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            int cant = _tipoMembresiaSeleccionada.cantidadCuotas;
            string? diasVenc = new ConfiguracionesController().GetValueByName("CuotaCantDiasVencimiento");
            //por defecto 10, por si no esta configurado
            int diasVencimiento = 10;
            if (diasVenc != null)
                diasVencimiento = Convert.ToInt16(diasVenc);

            _listaCuotas = new List<Cuota>();
            DateTime desde = txtFechaDesde.Value;
            for (int i = 0; i < cant; i++)
            {
                desde = desde.AddMonths(i);

                Cuota c = new Cuota();
                c.precio = _tipoMembresiaSeleccionada.precioTotal / cant;
                c.numero = i + 1;
                c.fechaDesde = desde;
                c.fechaHasta = desde.AddMonths(1);
                c.fechaVencimiento = desde.AddDays(diasVencimiento-1);

                _listaCuotas.Add(c);
            }

            bindingSource1.DataSource = _listaCuotas;

            ucAgregar1__ClickUCAgregar(null, null);
        }

        private void bindingSource2_CurrentItemChanged(object sender, EventArgs e)
        {
            RefreshTipoMembresia();
        }

        private void ucAgregar1__ClickUCAgregar(object sender, EventArgs e)
        {
            txtDescripcionMembresía.Text = String.Format(" {0} | {1} | Desde: {2} Hasta: {3} | Cantidad de días por semana: {4} | Días habilitados: {5}",
              _tipoMembresiaSeleccionada.nombre,
              _tipoMembresiaSeleccionada.descripcion,
              Statics.DateTimeNowSinHoraString(txtFechaDesde.Value),
              Statics.DateTimeNowSinHoraString(txtFechaHasta.Value),
              _tipoMembresiaSeleccionada.cantidadDiasSemanales,
              _tipoMembresiaSeleccionada.diasHabilitados
              );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            
        }

        private bool ValidarGuardar()
        {
            string mensaje = "";

            if (_Socio == null)
                mensaje += "\nSeleccione el socio";

            if (_tipoMembresiaSeleccionada == null)
                mensaje += "\nSeleccione el tipo de membresía";

            if (!_listaCuotas.Any())
                mensaje += "\nDebe generar las cuotas";

            if (!mensaje.IsNullOrEmpty())
            {
                new MessageBoxCustom(mensaje, EnumModoMessageBoxCustom.SeEncontraronErrores).ShowDialog();
                return false;
            }

            return true;
        }

        private void Guardar()
        {
            if (!ValidarGuardar())
                return;

            if (_Socio == null)
                return;

            try
            {
                Membresia m = new Membresia();                
                m.idSocio = _Socio.idSocio;
                m.precio = _tipoMembresiaSeleccionada.precioTotal;
                m.fechaAlta = DateTime.Now;
                m.detalle = txtDescripcionMembresía.Text;
                m.idEstadoMembresia = 1;
                m.idTipoMembresia = _tipoMembresiaSeleccionada.idTipoMembresia;
                m.fechaDesde = txtFechaDesde.Value;
                m.fechaHasta = txtFechaHasta.Value;
                m.Cuotas = _listaCuotas;
                m.cantidadDiasSemanales = _tipoMembresiaSeleccionada.cantidadDiasSemanales;
                m.diasHabilitados = _tipoMembresiaSeleccionada.diasHabilitados;

                var mes = new MessageBoxCustom(EnumModoMessageBoxCustom.ConfirmaGuardar);
                mes.ShowDialog();                
                if (mes.response == DialogResult.No)
                {
                    return;
                }    

                new MembresiaController().Insert(m);

                new MessageBoxCustom(EnumModoMessageBoxCustom.DatosGuardadosCorrectamente).ShowDialog();
                LimpiarControles();
            }
            catch (Exception ex)
            {

                new MessageBoxCustom(ex.Message,EnumModoMessageBoxCustom.SeEncontraronErrores,50);
                throw;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (new MessageBoxCustom(EnumModoMessageBoxCustom.DeseaSalirSePerderanLosCambios)
                .ShowDialog() == DialogResult.OK)
                Close();

        }
    }
}
