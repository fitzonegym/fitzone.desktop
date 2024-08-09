using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Socios;
using Fitzone.Front.UserControls;
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
    public partial class FrmTipoMembresiaAdmin : Form
    {
        List<TipoMembresia>? _listaTipos = new List<TipoMembresia>();

        public FrmTipoMembresiaAdmin()
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
        private void FrmTipoMembresiaAdmin_Load(object sender, EventArgs e)
        {

            CargarGrilla();
        }

        private void CargarGrilla()
        {

            _listaTipos = new TipoMembresiaController().GetAll();
            tipoMembresiaBindingSource.DataSource = _listaTipos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTipoMembresiaAlta frm = new FrmTipoMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Alta;
            frm.ShowDialog();

            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            //return;

            if (tipoMembresiaBindingSource.DataSource == null || tipoMembresiaBindingSource.Current == null)
                return;

            FrmTipoMembresiaAlta frm = new FrmTipoMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Modificacion;

            frm._tipo = ((TipoMembresia)tipoMembresiaBindingSource.Current);
            frm._id_tipo = ((TipoMembresia)tipoMembresiaBindingSource.Current).idTipoMembresia;

            frm.ShowDialog();

            CargarGrilla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {     

            if (tipoMembresiaBindingSource.DataSource == null || tipoMembresiaBindingSource.Current == null)
                return;

            FrmTipoMembresiaAlta frm = new FrmTipoMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Consulta;

            frm._tipo = ((TipoMembresia)tipoMembresiaBindingSource.Current);
            frm._id_tipo = ((TipoMembresia)tipoMembresiaBindingSource.Current).idTipoMembresia;

            frm.ShowDialog();

     
        }
    }
}
