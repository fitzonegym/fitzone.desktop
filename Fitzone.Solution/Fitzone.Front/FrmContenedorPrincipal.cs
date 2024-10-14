using Fitzone.Entidades;
using Fitzone.Front.Facturas;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Instructores;
using Fitzone.Front.Membresias;
using Fitzone.Front.Socios;
using Fitzone.Front.Usuarios;

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

            sociosToolStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.Socios);
            membresíaToolStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.Membresia);
            facturaStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.Facturas);
            configuraciónToolStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.Configuracion);
            controlDeAccesosToolStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.ControlAccesos);
            //tipoDeMembresíaToolStripMenuItem.Visible = Statics.VerificarAcceso(EnumOpcionesMenu.ControlAccesos);

            toolStripStatusLabelUsuario.Text = String.Format("Usuario: {0} [{1}]", 
                Statics.UsuarioLogueado.Nombre + " " + Statics.UsuarioLogueado.Apellido,
                Statics.UsuarioLogueado.NombreUsuario);

            string perfil = "";
            if (Statics.UsuarioLogueado.idPerfil == (int)EnumPerfil.Administrador)
                perfil = EnumPerfil.Administrador.ToString();
            if (Statics.UsuarioLogueado.idPerfil == (int)EnumPerfil.Operador)
                perfil = EnumPerfil.Operador.ToString();
            if (Statics.UsuarioLogueado.idPerfil == (int)EnumPerfil.Gerente)
                perfil = EnumPerfil.Gerente.ToString();
            if (Statics.UsuarioLogueado.idPerfil == (int)EnumPerfil.Control_accesos)
                perfil = EnumPerfil.Control_accesos.ToString();
            toolStripStatusLabelUsuario.Text += " [" + perfil + "]";

        }
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está abierto
            FrmSociosAdmin frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmSociosAdmin)
                {
                    frm = (FrmSociosAdmin)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmSociosAdmin();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
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

            // Verificar si el formulario ya está abierto
            FrmSociosAlta frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmSociosAlta)
                {
                    frm = (FrmSociosAlta)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmSociosAlta();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm._EnumModoForm = EnumModoForm.Alta;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
            frm.BringToFront();

        }

        private void admnistraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
  


            // Verificar si el formulario ya está abierto
            FrmMembresiaAdmin frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmMembresiaAdmin)
                {
                    frm = (FrmMembresiaAdmin)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmMembresiaAdmin();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
            frm.BringToFront();



        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            // Verificar si el formulario ya está abierto
            FrmMembresiaAlta frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmMembresiaAlta)
                {
                    frm = (FrmMembresiaAlta)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmMembresiaAlta();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
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

        private void tipoDeMembresíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            FrmTipoMembresiaAdmin frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmTipoMembresiaAdmin)
                {
                    frm = (FrmTipoMembresiaAdmin)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmTipoMembresiaAdmin();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
            frm.BringToFront();


        }

        private void controlDeAccesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMControlAcceso frm = new FRMControlAcceso();
            frm.Show();

         

        }


        private void instructoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            FrmInstructoresAdmin frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmInstructoresAdmin)
                {
                    frm = (FrmInstructoresAdmin)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmInstructoresAdmin();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo            
            frm.TopMost = true;
            frm.BringToFront();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            FrmUsuariosAlta frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmUsuariosAlta)
                {
                    frm = (FrmUsuariosAlta)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmUsuariosAlta();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo            
            frm.TopMost = true;
            frm.BringToFront();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void administraciónToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // Verificar si el formulario ya está abierto
            FrmFacturasAdmin frm = null;

            //foreach (Form frmAbierto in this.MdiChildren)
            foreach (Form frmAbierto in this.panelPrincipal.Controls)
            {
                if (frmAbierto is FrmFacturasAdmin)
                {
                    frm = (FrmFacturasAdmin)frmAbierto;
                    break;
                }
            }

            // Si no se encontró una instancia abierta, se crea una nueva
            if (frm == null)
            {
                frm = new FrmFacturasAdmin();
                frm.MdiParent = this;
                this.panelPrincipal.Controls.Add(frm);
                frm.StartPosition = FormStartPosition.CenterParent;
                //frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
                frm.Show();
            }

            // Traer el formulario al frente si ya existía o si es nuevo
            frm.TopMost = true;
            frm.BringToFront();
        }   


    }
}
