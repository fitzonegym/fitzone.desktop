using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.Membresias
{
    public partial class FrmMembresiaAdmin : Form
    {
        List<Membresia>? _listaMembresias = new List<Membresia>();
        Socio? _Socio = new Socio();

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
        public FrmMembresiaAdmin()
        {
            InitializeComponent();
            txtNombre.TB.KeyPress += txtNombre_KeyPress;
        }

        private void FrmMembresiaAdmin_Load(object sender, EventArgs e)
        {            
            txtFechaDesde.Value = DateTime.Now.AddDays(-10);
            txtFechaHasta.Value = DateTime.Now.AddMonths(1);

            this.WindowState = FormWindowState.Maximized;
            CargarGrilla();

        }

        private void CargarGrilla()
        {
            Membresia filtro = new Membresia();  

            if (chkFecha.Checked)
            {
                filtro.fechaDesde = Statics.DateTimeSinHora(txtFechaDesde.Value);
                filtro.fechaHasta = Statics.DateTimeSinHora(txtFechaHasta.Value);
            }
            else
            {
                filtro.fechaDesde = new DateTime(2000, 1, 1);
                filtro.fechaHasta = new DateTime(2030, 1, 1);
            }

            filtro.Socio = null;

            if (!String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                filtro.Socio = new Socio();
                filtro.Socio.nombre = txtNombre.Text.Trim();
                //filtro.Socio.apellido = txtNombre.Text.Trim();
                //filtro.Socio.numeroDocumento = txtNombre.Text.Trim();
            }

            _listaMembresias = new MembresiaController().GetAllFilters(filtro);

            bindingSource1.DataSource = _listaMembresias;

            ucCantidadregistros1._cantidad = _listaMembresias?.Count() ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucBuscar1__ClickUC(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Consulta;
            frm.ShowDialog();
            _Socio = frm._SocioSeleccionado;

            if (_Socio != null)
                txtNombre.Text = _Socio.nombre + " " + _Socio.apellido;
            else
                txtNombre.Text = "Seleccione un socio";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void ucBuscar1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Alta;
            frm._id_membresia = 0;
            frm.ShowDialog();
            CargarGrilla();
        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            if (bindingSource1 == null || bindingSource1.Current == null)
            {
                new MessageBoxCustom("Seleccione una membresia", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmPagarCuota frm = new FrmPagarCuota();
            frm._idSocio = ((Membresia)bindingSource1.Current).idSocio;
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Consulta;

            frm._id_membresia = ((Membresia)bindingSource1.Current).idMembresia;

            frm.ShowDialog();
        }

        private void ucBuscar1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarGrilla();
                // Prevenir el sonido de beep
                //e.Handled = true;

            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtener la fila actual
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Verificar si la columna "anulado" tiene el valor true
            if (Convert.ToString(row.Cells["colEstado"].Value) == "Activa")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightGreen; // Cambia el color según tus preferencias
                //row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Vencida")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightCoral; // Cambia el color según tus preferencias
                                                                   //  row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Deshabilitada")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia el color según tus preferencias
                                                                  // row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Finalizada")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightBlue; // Cambia el color según tus preferencias
                                                                  //  row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
        }

        public void SetSocio(string nrodocumento)
        {   
            txtNombre.Text = nrodocumento;
            chkFecha.Checked = false;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtFechaDesde.Enabled = txtFechaHasta.Enabled = chkFecha.Checked;
            

        }
    }
}
