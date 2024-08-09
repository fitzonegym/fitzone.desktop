using Emgu.CV;
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
        public TipoMembresia? _tipo;
        public EnumModoForm _EnumModoForm = EnumModoForm.Consulta;

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

            CargarActividad();
            CargarInstructor();

            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                ucTituloLabel1._titulo = "Modificar tipo de membresía";
                Cargar();
                cmbActividad.EnabledCalc = false;                
            }
            if (_EnumModoForm == EnumModoForm.Alta)
            {
                _tipo = new TipoMembresia();
                ucTituloLabel1._titulo = "Agregar tipo de membresía";
                Limpiar();
            }
            if (_EnumModoForm == EnumModoForm.Consulta)
            {
                ucTituloLabel1._titulo = "Consultar tipo de membresía";
                ucErrorIconoDias.Visible = false;
                ucErrorIconoNombre.Visible = false;

                Cargar();
                EnabledDisabled(false);
            }

            _Validating(null, null);
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

        private void EnabledDisabled(bool _enabled)
        {

            txtNombre.Enabled = _enabled;
            cmbActividad.EnabledCalc = _enabled;            
            cmbInstructor.EnabledCalc = _enabled;

            spnPrecio.Enabled = _enabled;

            spnCuotas.Enabled = _enabled;
            spnCantDias.Enabled = _enabled;
            chkSinCupo.Enabled = _enabled;
            txtDetalle.Enabled = _enabled;

            spnDesde.Enabled = _enabled;
            spnHasta.Enabled = _enabled;

            rdnUnica.Enabled = _enabled;
            rdnMensual.Enabled = _enabled;  
            
            chkLunes.Enabled = _enabled;
            chkMartes.Enabled = _enabled;
            chkMiercoles.Enabled = _enabled;
            chkJueves.Enabled = _enabled;
            chkViernes.Enabled = _enabled;
            chkSabado.Enabled = _enabled;
            chkDomingo.Enabled = _enabled;


            spnCupo.Enabled = _enabled;
            chkCualquierHora.Enabled = _enabled;    
            
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
                msg = new MessageBoxCustom("Verifique los campos obligatorios \n" + mensajeErrores, EnumModoMessageBoxCustom.Aceptar, 100, 100);
                msg.ShowDialog();
                return;
            }
            _tipo.nombre = txtNombre.Text;
            _tipo.idActividad = ((Actividad)bindingSourceActividad.Current).idActividad;
            _tipo.idInstructor = ((Instructor)bindingSourceInstructor.Current).idInstructor;

            _tipo.precioTotal = spnPrecio.Value;

            _tipo.cantidadCuotas = (int)spnCuotas.Value;
            _tipo.cantidadDiasSemanales = (int)spnCantDias.Value;
            _tipo.cupoClase = chkSinCupo.Checked ? (int)spnCupo.Value : null;
            _tipo.descripcion = txtDetalle.Text;

            _tipo.horadesde = TimeOnly.FromDateTime(spnDesde.Value);
            _tipo.horaHasta = TimeOnly.FromDateTime(spnHasta.Value);

            _tipo.cuotaUnica = rdnUnica.Checked;

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

            Limpiar();
        }

        private void Limpiar()
        {
            _tipo = new TipoMembresia();
            _tipo.cantidadCuotas = 1;
            _tipo.cantidadDiasSemanales = 1;
            _tipo.precioTotal = 1;
            cmbActividad.SelectedValue = 1;
            _tipo.idInstructor = 1;
            _tipo.horadesde = new TimeOnly(0, 0);
            _tipo.horaHasta = new TimeOnly(0, 0);
            chkCualquierHora.Checked = true;
            chkSinCupo.Checked = false;
            _tipo.cupoClase = 1;
            _tipo.cuotaUnica = true;
            rdnMensual.Checked = false;
            rdnUnica.Checked = true;

            Cargar();

            _Validating(null, null);
        }

        private void Cargar()
        {
            cmbActividad.SelectedValue = _tipo.idActividad;
            cmbInstructor.SelectedValue = _tipo.idInstructor;

            spnDesde.Value = new DateTime(new DateOnly(2000,1,1),_tipo.horadesde);
            spnHasta.Value = new DateTime(new DateOnly(2000,1,1), _tipo.horaHasta);


            txtNombre.Text = _tipo.nombre;
            txtDetalle.Text = _tipo.descripcion;
            spnPrecio.Value = _tipo.precioTotal;
            spnCuotas.Value = _tipo.cantidadCuotas;
            spnCantDias.Value = _tipo.cantidadDiasSemanales;
            rdnMensual.Checked = !_tipo.cuotaUnica;
            rdnUnica.Checked = _tipo.cuotaUnica;

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
                chkSinCupo.Checked = false;
            }
            else
            {
                spnCupo.Value = (int)_tipo.cupoClase;
                spnCupo.Enabled = true;
                chkSinCupo.Checked = true;
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


            TimeOnly d = new TimeOnly(spnDesde.Value.Hour, spnDesde.Value.Minute);
            TimeOnly h = new TimeOnly(spnHasta.Value.Hour, spnHasta.Value.Minute);

            if (d >= h)
                mensaje += "\nLa hora 'desde' debe ser menor a hora 'hasta'";

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
            spnDesde.Enabled = chkCualquierHora.Checked;
            spnHasta.Enabled = chkCualquierHora.Checked;

            if (!chkCualquierHora.Checked)
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
            if (rdnUnica.Checked)
            {
                valorCuota = precio;
            }

            if (valorCuota < 1)
                valorCuota = 1;

            spnPrecioCuota.Value = valorCuota;
        }

        private void chkSinCupo_CheckedChanged(object sender, EventArgs e)
        {
            spnCupo.Enabled = chkSinCupo.Checked;
            spnCupo.Visible = chkSinCupo.Checked;

            //if (!chkSinCupo.Checked)
            //    spnCupo.Value = 1;
        }

        private void _Validating(object sender, CancelEventArgs e)
        {

            if (_EnumModoForm == EnumModoForm.Consulta)
                return;

            ucErrorIconoNombre.Visible = String.IsNullOrWhiteSpace(txtNombre.Text);
            txtNombre.Text = Statics.Capitalize(txtNombre.Text);

            ucErrorIconoDias.Visible = !(chkLunes.Checked || chkMartes.Checked ||
                chkMiercoles.Checked || chkJueves.Checked ||
                chkViernes.Checked || chkSabado.Checked || chkDomingo.Checked);

        }

        private void rdbUnica_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();
        }

        private void rdbMensual_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();
        }

        private void spnPrecioCuota_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdnUnica_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();

        }

        private void rdnMensual_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCuota();
        }
    }
}
