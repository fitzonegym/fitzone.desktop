using Fitzone.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.Socios
{
    public partial class FRMControlAcceso : Form
    {

        public FRMControlAcceso()
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDiaHora.Text = DateTime.Now.ToString();
        }

        private void FRMIngresosRegistrar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
  

        private void txtNroDoc_Click(object sender, EventArgs e)
        {
            //string cadenaOriginal = txtNroDoc.Text;
            //string caracteresIndeseados = "., ";
            //string resultado = new string(cadenaOriginal.Where(c => !caracteresIndeseados.Contains(c)).ToArray());

            //if (String.IsNullOrWhiteSpace(resultado))
            txtNroDoc.SelectionStart = 0;
            txtNroDoc.SelectionLength = 10;
        }    

        private void txtNroDoc_Enter(object sender, EventArgs e)
        {
            txtNroDoc.SelectionStart = 0;
            txtNroDoc.SelectionLength = 10;
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Buscar();
                txtNroDoc.SelectionStart = 0;
                txtNroDoc.SelectionLength = 10;
            }
        }

        private void Buscar()
        {
            DateTime hoy = txtFecha.Value;

            SocioController socioController = new SocioController();

            string actividades = "";
            string vencimientos = "";
            string nombre = "";

            var respuesta = socioController.VerificarEstadoCuota(txtNroDoc.Text,hoy);

            lblMensaje.Text = respuesta.EnumEstadoCuotaSocio.ToString().Replace('_',' ');
            lblActividad.Text = respuesta.actividades ?? "No encontrado";
            lblNombre.Text = respuesta.nombreSocio ?? "No encontrado";
            lblMensaje.BackColor = respuesta.Color;
        }

        private void FRMIngresosRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                txtNroDoc.Text = "";
                txtNroDoc.SelectionStart = 0;
                txtNroDoc.SelectionLength = 10;
                txtNroDoc.Focus();
            }
            //if (e.KeyChar == (char)Keys.Enter)
            //{   
                
            //    e.Handled = true;
               
            //    txtNroDoc.Focus();
            //    //Buscar();
            //  //  txtNroDoc.SelectionStart = 0;
            //  //  txtNroDoc.SelectionLength = 10;

            //}
        }

      
    }
}
