﻿using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.Usuarios
{
    public partial class FrmUsuariosAlta : Form
    {
        Usuario _usuario;
        public FrmUsuariosAlta()
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //listo para guardar
            MessageBoxCustom msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            UsuarioController controller = new UsuarioController();

            try
            {
                _usuario = new Usuario();

                _usuario.Nombre = txtNombre.Text;
                _usuario.Apellido = txtApellido.Text;
                _usuario.FechaAlta = DateTime.Now;
                _usuario.NombreUsuario = txtUsuario.Text;
                _usuario.Password = txtContraseña.Text;

                switch (cmbPerfil.Text)
                {
                    case "Administrador":
                        _usuario.idPerfil = 1;
                        break;
                    case "Operador":
                        _usuario.idPerfil = 3;
                        break;
                    case "Gerente":
                        _usuario.idPerfil = 4;
                        break;
                    default:
                        _usuario.idPerfil = 1;
                        break;
                }

                controller.Insert(_usuario);

                new MessageBoxCustom(EnumModoMessageBoxCustom.DatosGuardadosCorrectamente).ShowDialog();
                Close();

            }
            catch (Exception ex)
            {

                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuariosAlta_Load(object sender, EventArgs e)
        {
            cmbPerfil.SelectedIndex = 0;    
        }
    }
}
