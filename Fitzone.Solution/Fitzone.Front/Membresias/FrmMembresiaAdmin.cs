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
        }

        private void FrmMembresiaAdmin_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            txtFechaDesde.Value = DateTime.Now.AddDays(-10);
            txtFechaHasta.Value = DateTime.Now.AddMonths(1);

            this.WindowState = FormWindowState.Maximized;
            CargarGrilla();

        }   

        private void CargarGrilla()
        {
            Membresia filtro = new Membresia();
            if (_Socio != null)
                filtro.idSocio = _Socio.idSocio;
            filtro.fechaDesde = txtFechaDesde.Value;
            filtro.fechaHasta = txtFechaHasta.Value;

            _listaMembresias = new MembresiaController().GetAll(filtro);


            bindingSource1.DataSource = _listaMembresias;

            ucCantidadregistros1._cantidad = _listaMembresias.Count();
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
                txtNombre.Text = "";
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
            frm.ShowDialog();
            CargarGrilla();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            return;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            return;
        }
    }
}
