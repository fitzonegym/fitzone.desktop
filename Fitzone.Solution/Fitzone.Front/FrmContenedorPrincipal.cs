using Fitzone.Front.FormsExtras;
using Fitzone.Front.Membresias;
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

namespace Fitzone.Front
{
    public partial class FrmContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmContenedorPrincipal()
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


        private void FrmContenedorPrincipal_Load(object sender, EventArgs e)
        {
            MyRenderer rend = new MyRenderer();
            menuStrip1.Renderer = rend;
        }
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;

            frm.Show();
            frm.BringToFront();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxCustom msg = new MessageBoxCustom("¿Desea salir del sistema?", Enumeraciones.EnumModoMessageBoxCustom.YesNo);
            msg.ShowDialog();
            if (msg.response == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosAlta frm = new FrmSociosAlta();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
            frm.BringToFront();
        }

        private void admnistraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresiaAdmin frm = new FrmMembresiaAdmin();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
            frm.BringToFront();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
            frm.BringToFront();
        }

        private void BringToFrontForm(Form form)
        {
            form.Activated += (s, e) => { form.BringToFront(); };
            this.MdiChildActivate += (s, e) =>
            {
                if (this.ActiveMdiChild != form)
                {
                    form.BringToFront();
                }
            };
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);

        }

        private void panelPrincipal_DoubleClick(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }
    }
}
