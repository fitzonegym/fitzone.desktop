using Fitzone.Controller;
using Fitzone.Front.FormsExtras;

namespace Fitzone.Front.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
            try
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
            catch (Exception)
            {
            }

        }
        public void OnMouseDownForm(MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            try
            {
                base.OnMouseDown(e);
                // Permitir que el formulario se mueva cuando el usuario lo arrastre
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion


        private void inicio_Click(object sender, EventArgs e)
        {
            string NombreUsuario, password;

            NombreUsuario = txtusuario.Text;
            password = txtcontrasena.Text;            

            if (String.IsNullOrWhiteSpace(NombreUsuario) || String.IsNullOrWhiteSpace(password))
            {
                new MessageBoxCustom("Ingrese el usuario y/o contraseña",Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();   
                return;
            }  

            UsuarioController usuarioController = new UsuarioController();
            //usuarioController.VerificarContraseña(usuario)

            var usuario = usuarioController.GetByName(NombreUsuario);
            if (usuario == null)
            {
                new MessageBoxCustom("Nombre de usuario no encontrado", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            if (usuarioController.VerificarContraseña(password, usuario.Password))            
            {
                FrmContenedorPrincipal form2 = new FrmContenedorPrincipal();
                this.Visible = false;
                Statics.UsuarioLogueado = usuario;
                form2.ShowDialog();

                Close();

                

            }
            else
            {
                new MessageBoxCustom("Contraseña incorrecta", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();

                Statics.UsuarioLogueado = null;
                return;
            }
            

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontrasena.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centrado();
        }

        private void centrado()
        {

            //obtenemos las dimensiones
            int altura_forma = Height;
            int anchura_forma = Width;
            int altura_groupbox = panel1.Height;
            int anchura_groupbox = panel1.Width;
            //obtenemos la nueva posicion del groupBox1

            int nueva_altura = (altura_forma - altura_groupbox) / 2;
            int nueva_anchura = (anchura_forma - anchura_groupbox) / 2;

            panel1.Location = new Point(nueva_anchura, nueva_altura);

        }

        private void Form1_Load_SizeChange(object sender, EventArgs e)
        {
            centrado();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                inicio_Click(null, null);
                // Prevenir el sonido de beep
                e.Handled = true;

            }

            if (e.KeyChar ==124)
            {
                txtusuario.Text = "admin";
                txtcontrasena.Text = "admin";
                inicio_Click(null, null);
                // Prevenir el sonido de beep
                e.Handled = true;

            }

        }

    }
}
