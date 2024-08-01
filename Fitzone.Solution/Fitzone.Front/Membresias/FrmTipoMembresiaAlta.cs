﻿using Emgu.CV;
using Fitzone.Controller;
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

namespace Fitzone.Front.Membresias
{
    public partial class FrmTipoMembresiaAlta : Form
    {
        private VideoCapture _capture;
        public int _id_tipo = 1;
        TipoMembresia? _tipo;
        public EnumModoForm _EnumModoForm = EnumModoForm.Alta;

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
        public FrmTipoMembresiaAlta()
        {
            InitializeComponent();
        }

        private void FrmTipoMembresiaAlta_Load(object sender, EventArgs e)
        {

            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                ucTituloLabel1._titulo = "Modificar tipo de membresía";
            }
            if (_EnumModoForm == EnumModoForm.Alta)
            {
                _tipo = new TipoMembresia();
                ucTituloLabel1._titulo = "Agregar tipo de membresía";
            }

            CargarActividad();
            CargarInstructor();
        }

        private void CargarActividad()
        {
            GeneralesController con = new GeneralesController();
            bindingSourceActividad.DataSource = con.GetActividad();
        }

        private void CargarInstructor()
        {
            InstructorController con = new InstructorController();

            var list = con.GetInstructoresActividad((int)(cmbActividad.SelectedValue ?? 0));

            bindingSourceInstructor.DataSource = list;

            ucErrorIconoInstructor.Visible = list == null || list.Count == 0;
            


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBoxCustom msg;

            if (_EnumModoForm == EnumModoForm.Alta)
            {
                _tipo = new TipoMembresia();
                _tipo.idTipoMembresia = 0;
            }

            if (_tipo == null) return; //solo para quitar el warning

            // validaciones
            string mensajeErrores = "";
            if (!Validar(ref mensajeErrores))
            {
                msg = new MessageBoxCustom("Verifique los campos obligatorios \n" + mensajeErrores, EnumModoMessageBoxCustom.Aceptar,0,50);
                msg.ShowDialog();
                return;
            }
            _tipo.nombre = txtNombre.Text;
            _tipo.idActividad = ((Actividad)bindingSourceActividad.Current).idActividad;
            _tipo.idInstructor = ((Instructor)bindingSourceInstructor.Current).idInstructor;

            _tipo.precioTotal = spnPrecio.Value;

            _tipo.cantidadCuotas = (int)spnCuotas.Value;
            _tipo.cantidadDiasSemanales = (int)spnCantDias.Value;
            _tipo.cupoClase = chkSinCupo.Checked ? null : (int)spnCupo.Value;
            _tipo.descripcion = txtDetalle.Text;

            _tipo.horadesde = TimeOnly.FromDateTime(spnDesde.Value);
            _tipo.horaHasta = TimeOnly.FromDateTime(spnHasta.Value);

            string dias = "";
            dias += chkLunes.Checked ? "lunes," : "";
            dias += chkMartes.Checked ? "martes," : "";
            dias += chkMiercoles.Checked ? "miercoles," : "";
            dias += chkJueves.Checked ? "jueves," : "";
            dias += chkViernes.Checked ? "viernes," : "";
            dias += chkSabado.Checked ? "sabado," : "";
            dias += chkDomingo.Checked ? "domingo," : "";

            if (dias != "")
                dias = dias.Remove(dias.Length - 1);

            dias = "[" + dias + "]";
            _tipo.diasHabilitados = dias;


            //listo para guardar
            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            TipoMembresiaController c = new TipoMembresiaController();

            try
            {
                if (_EnumModoForm == EnumModoForm.Alta)
                    c.Insert(_tipo);

                if (_EnumModoForm == EnumModoForm.Modificacion)
                    c.Update(_tipo, _tipo.idTipoMembresia);
            }
            catch (Exception ex)
            {
                msg = new MessageBoxCustom(ex.Message, EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                return;
            }

            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                msg = new MessageBoxCustom("Se actualizaron los datos del socio", EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                Close();
            }

            if (_EnumModoForm == EnumModoForm.Alta)
            {
                msg = new MessageBoxCustom("Se dió de alta el tipo de membresía " + _tipo.nombre + "\n¿Desea agregar uno nuevo?", EnumModoMessageBoxCustom.YesNo, 50);
                msg.ShowDialog();
                if (msg.response == DialogResult.No)
                    Close();
            }

            _tipo = new TipoMembresia();
            _tipo.precioTotal = 1;
            _tipo.cantidadCuotas = 1;
            _tipo.cantidadDiasSemanales = 1;                
            CargarLimpiar();
        }
        private void CargarLimpiar()
        {
            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                cmbActividad.SelectedValue = _tipo.idActividad;
                cmbInstructor.SelectedValue = _tipo.idInstructor;
            }
            txtDetalle.Text = _tipo.descripcion;
            spnPrecio.Value = _tipo.precioTotal;
            spnCuotas.Value = _tipo.cantidadCuotas;
            spnCantDias.Value = _tipo.cantidadDiasSemanales;

            string dias = _tipo.diasHabilitados;
            chkLunes.Checked = dias.Contains("lunes");
            chkMartes.Checked = dias.Contains("martes");
            chkMiercoles.Checked = dias.Contains("miercoles");
            chkJueves.Checked = dias.Contains("jueves");
            chkViernes.Checked = dias.Contains("viernes");
            chkSabado.Checked = dias.Contains("sabado");
            chkDomingo.Checked = dias.Contains("domingo");

            if (_tipo.cupoClase == null)
            {
                spnCupo.Value = 1;
                spnCupo.Enabled = false;
                chkSinCupo.Checked = true;
            }
            else
            {
                spnCupo.Value = (int)_tipo.cupoClase;
                spnCupo.Enabled = true;
                chkSinCupo.Checked = false;
            }

            txtHoraDesde.Text = _tipo.horadesde.ToShortTimeString();
            txtHoraHasta.Text = _tipo.horaHasta.ToShortTimeString();

            ActualizarPrecioCuota();

            //_Validating(null, null);            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingSourceActividad_CurrentChanged(object sender, EventArgs e)
        {
            CargarInstructor();
        }
        private bool Validar(ref string mensaje)
        {
            mensaje = "";

            if (String.IsNullOrWhiteSpace(txtNombre.Text))            
                mensaje += "\nNombre";            

            if (bindingSourceActividad == null || bindingSourceActividad.Current == null)
                mensaje += "\nActividad";

            if (bindingSourceInstructor == null || bindingSourceInstructor.Current == null)
                mensaje += "\nInstructor";
          

            bool cond = chkLunes.Checked || chkMartes.Checked ||
                chkMiercoles.Checked || chkJueves.Checked ||
                chkViernes.Checked || chkSabado.Checked || chkDomingo.Checked;

            if (!cond)
                mensaje += "\nDías de la semana";

            if (!String.IsNullOrWhiteSpace(mensaje))
            {
                return false;
            }


            return true;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chkCualquierHora_CheckedChanged(object sender, EventArgs e)
        {
            spnDesde.Enabled = !chkCualquierHora.Checked;
            spnHasta.Enabled = !chkCualquierHora.Checked;

            if (chkCualquierHora.Checked)
            {
                spnDesde.Value = new DateTime(2000, 1, 1, 0, 0, 0);
                spnHasta.Value = new DateTime(2000, 1, 1, 23, 59, 59);
            }
        }

        private void spnCuotas_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();
        }

        private void spnPrecio_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();
        }

        private void ActualizarPrecioCuota()
        {
            decimal precio = spnPrecio.Value;
            decimal cantidad = spnCuotas.Value;

            decimal valorCuota = precio / cantidad;
            if (valorCuota < 0)
                valorCuota = 1;

            spnPrecioCuota.Value = valorCuota;
        }

        private void chkSinCupo_CheckedChanged(object sender, EventArgs e)
        {
            spnCupo.Enabled = !chkSinCupo.Checked;
        }   

        private void _Validating(object sender, CancelEventArgs e)
        {
            ucErrorIconoNombre.Visible = String.IsNullOrWhiteSpace(txtNombre.Text);
            txtNombre.Text = Statics.Capitalize(txtNombre.Text);

            ucErrorIconoDias.Visible = !(chkLunes.Checked || chkMartes.Checked ||
                chkMiercoles.Checked || chkJueves.Checked ||
                chkViernes.Checked || chkSabado.Checked || chkDomingo.Checked);

        }
    }
}
