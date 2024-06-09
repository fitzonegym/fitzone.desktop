using Fitzone.Front.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.FormsExtras
{

    public partial class MessageBoxCustom : Form
    {
        public DialogResult response;
        EnumModoMessageBoxCustom _modo;
        string _mensaje;
        int _aumentarAncho = 0;

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

        public MessageBoxCustom(string mensaje, EnumModoMessageBoxCustom modo)
        {
            InitializeComponent();
            _modo = modo;
            _mensaje = mensaje;
        }

        public MessageBoxCustom(string mensaje, EnumModoMessageBoxCustom modo, int aumentarAncho)
        {
            InitializeComponent();
            _modo = modo;
            _mensaje = mensaje;
            _aumentarAncho = aumentarAncho;
        }

        public MessageBoxCustom(EnumModoMessageBoxCustom modo)
        {
            InitializeComponent();
            _modo = modo;
        }

        private void MessageBoxCustom_Load(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo ||
                _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                btn1.TextButton = "Si";
                btn2.TextButton = "No";
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                btn1.TextButton = "Aceptar";
                btn2.TextButton = "Cancelar";
            }

            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente || _modo == EnumModoMessageBoxCustom.Aceptar)
            {
                btn1.Visible = false;
                btn2.TextButton = "Aceptar";
            }

            if (_modo == EnumModoMessageBoxCustom.NoSeEncontraronDatos)
            {
                btn1.Visible = false;
                btn2.TextButton = "Aceptar";
                _mensaje = "No se encontraron datos.";
            }

            if (_modo == EnumModoMessageBoxCustom.SeEncontraronErrores)
            {
                btn1.Visible = false;
                btn2.TextButton = "Aceptar";
                _mensaje = "Se encontraron los siguientes errores: \n" + _mensaje;
                this.Size = new Size(this.Width, this.Height + 100);
            }

            lblMensaje2.Text = _mensaje;


            if (_modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
                lblMensaje2.Text = "¿Confirma guardar los datos?";
            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente)
                lblMensaje2.Text = "Los datos se guardaron correctamente";

            this.Size = new Size(this.Width + _aumentarAncho, this.Height);


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo
                || _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                response = DialogResult.Yes;
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                response = DialogResult.OK;
            }
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo
                || _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                response = DialogResult.No;
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                response = DialogResult.Cancel;
            }
            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente)
            {
                response = DialogResult.OK;
            }
            Close();
        }

        private void MessageBoxCustom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (btn1.Visible)
                {
                    btn1_Click(null, null);                    
                }
                else
                {
                    btn2_Click(null, null);
                }
                // Prevenir el sonido de beep
                e.Handled = true;

            }

        }
    }
}
