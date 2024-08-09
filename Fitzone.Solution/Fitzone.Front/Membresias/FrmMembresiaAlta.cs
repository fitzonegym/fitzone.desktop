using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Fitzone.Front.Membresias
{
    public partial class FrmMembresiaAlta : Form
    {
        Socio? _Socio = null;
        TipoMembresia _tipoMembresiaSeleccionada = null;
        List<Cuota> _listaCuotas = new List<Cuota>();
        DateTime fechaHastaSeleccionada;
        public EnumModoForm _EnumModoForm = EnumModoForm.Consulta;
        public int _id_membresia = 2;

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
        public FrmMembresiaAlta()
        {
            InitializeComponent();
        }
        private void FrmMembresia_Load(object sender, EventArgs e)
        {
            CargarTipos();            

            txtFechaDesde.Value = Statics.DateTimeNowSinHora();

            LimpiarControles();

            RefreshTipoMembresia();

            fechaHastaSeleccionada = txtFechaHasta.Value;

            if (_EnumModoForm == EnumModoForm.Consulta)
            {
                btnAceptar.Enabled = false; 
                Cargar();
                cmbTipoMembresia.EnabledCalc = false;
                btnBuscarSocio.Visible = false; 
                cmdGenerar.Visible = false; 
                txtFechaDesde.Enabled= false;   
                txtDescripcionMembresía.Enabled = false;    
                btnAceptar.Visible = false; 
            }
        }

        private void Cargar()
        {
            MembresiaController membresiaController = new MembresiaController();
            Membresia m = membresiaController.GetById(_id_membresia);
            if (m != null)
            {
               

                _Socio = m.Socio;

                if (_Socio != null)
                {
                    txtNombre.Text = _Socio.nombre;
                    txtApellido.Text = _Socio.apellido;
                    txtDocumento.Text = _Socio.numeroDocumento;
                    txtTelefono.Text = _Socio.telefono1;
                    txtDireccion.Text = _Socio.calle + " " + _Socio.calleNumero;
                }

                cmbTipoMembresia.SelectedValue = m.idTipoMembresia;                

                txtDetalleTipo.Text = m.detalle;
                txtPrecio.Text = m.precio.ToString();
                txtCuotas.Text = _tipoMembresiaSeleccionada.cantidadCuotas.ToString();
                txtCantDias.Text = m.cantidadDiasSemanales.ToString();

                string dias = m.diasHabilitados;
                chkLunes.Checked = dias.Contains("lunes");
                chkMartes.Checked = dias.Contains("martes");
                chkMiercoles.Checked = dias.Contains("miercoles");
                chkJueves.Checked = dias.Contains("jueves");
                chkViernes.Checked = dias.Contains("viernes");
                chkSabado.Checked = dias.Contains("sabado");
                chkDomingo.Checked = dias.Contains("domingo");

                txtCupo.Text = _tipoMembresiaSeleccionada.cupoClase.ToString();
                txtHoraDesde.Text = m.horadesde.ToShortTimeString();
                txtHoraHasta.Text = m.horaHasta.ToShortTimeString();

                chkCuotaUnica.Checked = _tipoMembresiaSeleccionada.cuotaUnica;

                txtFechaHasta.Value = m.fechaDesde;
                txtFechaHasta.Value = m.fechaHasta;

                Disponibilidad();

                AgregarDetalle();

                _listaCuotas = m.Cuotas??new List<Cuota>();
                bindingSourceCuotas.DataSource = _listaCuotas;

                txtInstructor.Text = _tipoMembresiaSeleccionada.InstructorNombreCompleto;

            }
        }

        private void LimpiarControles()
        {
            _listaCuotas = new List<Cuota>();
            bindingSourceCuotas.DataSource = _listaCuotas;
            txtDescripcionMembresía.Text = "";

            _Socio = null;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

        }
        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Consulta;
            frm.ShowDialog();
            _Socio = frm._SocioSeleccionado;

            if (_Socio != null)
            {
                txtNombre.Text = _Socio.nombre;
                txtApellido.Text = _Socio.apellido;
                txtDocumento.Text = _Socio.numeroDocumento;
                txtTelefono.Text = _Socio.telefono1;
                txtDireccion.Text = _Socio.calle + " " + _Socio.calleNumero;
            }

        }
        private void CargarTipos()
        {
            TipoMembresiaController membresiaController = new TipoMembresiaController();
            bindingSourceTipo.DataSource = membresiaController.GetAll();
            RefreshTipoMembresia();
        }
        //private void CargarInstructores(int idActividad)
        //{
        //    InstructorController controller = new InstructorController();
        //    bindingSourceInstructor.DataSource = controller.GetInstructoresActividad(idActividad);
        //}
        private void RefreshTipoMembresia()
        {

            if (bindingSourceTipo.Current == null)
                return;

            _tipoMembresiaSeleccionada = (TipoMembresia)bindingSourceTipo.Current;

            txtDetalleTipo.Text = _tipoMembresiaSeleccionada.descripcion;
            txtPrecio.Text = _tipoMembresiaSeleccionada.precioTotal.ToString();
            txtCuotas.Text = _tipoMembresiaSeleccionada.cantidadCuotas.ToString();
            txtCantDias.Text = _tipoMembresiaSeleccionada.cantidadDiasSemanales.ToString();

            string dias = _tipoMembresiaSeleccionada.diasHabilitados;
            chkLunes.Checked = dias.Contains("lunes");
            chkMartes.Checked = dias.Contains("martes");
            chkMiercoles.Checked = dias.Contains("miercoles");
            chkJueves.Checked = dias.Contains("jueves");
            chkViernes.Checked = dias.Contains("viernes");
            chkSabado.Checked = dias.Contains("sabado");
            chkDomingo.Checked = dias.Contains("domingo");

            txtCupo.Text = _tipoMembresiaSeleccionada.cupoClase.ToString();
            txtHoraDesde.Text = _tipoMembresiaSeleccionada.horadesde.ToShortTimeString();
            txtHoraHasta.Text = _tipoMembresiaSeleccionada.horaHasta.ToShortTimeString();

            chkCuotaUnica.Checked = _tipoMembresiaSeleccionada.cuotaUnica;

            CalcularFechasMembresia();

            Disponibilidad();

            AgregarDetalle();

         //   CargarInstructores(_tipoMembresiaSeleccionada.idActividad);

            _listaCuotas = new List<Cuota>();
            bindingSourceCuotas.DataSource = _listaCuotas;

            txtInstructor.Text = _tipoMembresiaSeleccionada.InstructorNombreCompleto;

        }
        private void CalcularFechasMembresia()
        {
            try
            {
                //if (chkCuotaUnica.Checked)
                //    txtFechaHasta.Value = txtFechaDesde.Value.AddMonths(1).AddSeconds(-1);
                //else
                    txtFechaHasta.Value = txtFechaDesde.Value.AddMonths(Convert.ToInt16(txtCuotas.Text)).AddSeconds(-1);
            }
            catch (Exception)
            {

                throw;
            }


        }
        private void txtFechaDesde_ValueChanged(object sender, EventArgs e)
        {

            CalcularFechasMembresia();
        }
        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            GenerarCuotas();

            fechaHastaSeleccionada = txtFechaHasta.Value;
        }

        private void GenerarCuotas()
        {
            int cant = _tipoMembresiaSeleccionada.cantidadCuotas;

            if (_tipoMembresiaSeleccionada.cuotaUnica)
                cant = 1;

            string? diasVenc = new ConfiguracionesController().GetValueByName("CuotaCantDiasVencimiento");
            //por defecto 10, por si no esta configurado
            int diasVencimiento = 10;
            if (diasVenc != null)
                diasVencimiento = Convert.ToInt16(diasVenc);

            _listaCuotas = new List<Cuota>();
            DateTime desde = txtFechaDesde.Value;

            for (int i = 0; i < cant; i++)
            {   
                Cuota c = new Cuota();
                c.precio = _tipoMembresiaSeleccionada.precioTotal / cant;
                c.numero = i + 1;
                c.fechaDesde = desde;
                
                if (cant == 1)
                    c.fechaHasta = txtFechaHasta.Value;
                else
                    c.fechaHasta = desde.AddMonths(1).AddSeconds(-1);

                if (i == 0)
                    c.fechaVencimiento = desde.AddDays(1).AddSeconds(-1);
                else
                    c.fechaVencimiento = desde.AddDays(diasVencimiento).AddSeconds(-1);

                _listaCuotas.Add(c);

                desde = desde.AddMonths(1);
            }

            bindingSourceCuotas.DataSource = _listaCuotas;

            AgregarDetalle();
        }

        private void bindingSource2_CurrentItemChanged(object sender, EventArgs e)
        {
            RefreshTipoMembresia();
        }
        private void ucAgregar1__ClickUCAgregar(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void AgregarDetalle()
        {
            txtDescripcionMembresía.Text = String.Format(" {0} | {1} | Desde: {2} Hasta: {3} | Cantidad de días por semana: {4} | Días habilitados: {5}",
            _tipoMembresiaSeleccionada.nombre,
            _tipoMembresiaSeleccionada.descripcion,
            Statics.DateTimeNowSinHoraString(txtFechaDesde.Value),
            Statics.DateTimeNowSinHoraString(txtFechaHasta.Value),
            _tipoMembresiaSeleccionada.cantidadDiasSemanales,
            _tipoMembresiaSeleccionada.diasHabilitados
            );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        private bool ValidarGuardar()
        {
            string mensaje = "";

            if (_Socio == null)
                mensaje += "\nSeleccione el socio";

            if (_tipoMembresiaSeleccionada == null)
                mensaje += "\nSeleccione el tipo de membresía";

            //if (bindingSourceInstructor.Current == null)
            //    mensaje += "\nSeleccione el instructor";

            if (!_listaCuotas.Any())
                mensaje += "\nDebe generar las cuotas";
            else
                if (fechaHastaSeleccionada != txtFechaHasta.Value)
                    mensaje += "\nLa fecha desde/hasta cambió, debe generar de nuevo las cuotas";

            if (txtDisponibilidadBack.Text == "0")
                mensaje += "\nNo hay disponibilidad";

            

            if (!mensaje.IsNullOrEmpty())
            {
                new MessageBoxCustom(mensaje, EnumModoMessageBoxCustom.SeEncontraronErrores,130).ShowDialog();
                return false;
            }

            return true;
        }
        private void Guardar()
        {
            if (!ValidarGuardar())
                return;
            if (_Socio == null)
                return;

            try
            {


                Membresia m = new Membresia();
                m.idSocio = _Socio.idSocio;
                m.precio = _tipoMembresiaSeleccionada.precioTotal;
                m.fechaAlta = DateTime.Now;
                m.detalle = txtDescripcionMembresía.Text;
                m.fechaDesde = txtFechaDesde.Value;
                m.fechaHasta = txtFechaHasta.Value;
                m.Cuotas = _listaCuotas;
                m.cantidadDiasSemanales = _tipoMembresiaSeleccionada.cantidadDiasSemanales;
                m.diasHabilitados = _tipoMembresiaSeleccionada.diasHabilitados;

                m.horadesde = _tipoMembresiaSeleccionada.horadesde;
                m.horaHasta = _tipoMembresiaSeleccionada.horaHasta;
                m.idActividad = _tipoMembresiaSeleccionada.idActividad;
                m.idInstructor = _tipoMembresiaSeleccionada.idInstructor;

                m.idTipoMembresia = _tipoMembresiaSeleccionada.idTipoMembresia;
                m.idEstadoMembresia = 1;

                var mes = new MessageBoxCustom(EnumModoMessageBoxCustom.ConfirmaGuardar);
                mes.ShowDialog();
                if (mes.response == DialogResult.No)
                {
                    return;
                }

                new MembresiaController().Insert(m);

                new MessageBoxCustom(EnumModoMessageBoxCustom.DatosGuardadosCorrectamente).ShowDialog();
                LimpiarControles();
                RefreshTipoMembresia();
            }
            catch (Exception ex)
            {

                new MessageBoxCustom(ex.Message, EnumModoMessageBoxCustom.SeEncontraronErrores, 50);
                throw;
            }


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_EnumModoForm == EnumModoForm.Consulta)
            {
                Close();
                return;
            }

            if (_listaCuotas.Count == 0 && _Socio == null)
            {
                Close();
                return;
            }


            var mes = new MessageBoxCustom(EnumModoMessageBoxCustom.DeseaSalirSePerderanLosCambios);
            mes.ShowDialog();

            if (mes.response == DialogResult.Yes)
                Close();

        }
        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var tipo = (TipoMembresia)cmbTipoMembresia.SelectedItem;

            //int? cant = 0;
            //if (tipo != null)
            //{
            //    MembresiaController con = new MembresiaController();
            //    cant = con.GetDisponibilidad(tipo);
            //}

            //if (cant == null)
            //{
            //    txtDisponibilidadBack.Text = "";
            //    txtDisponibilidadBack.BackColor = Color.Transparent;
            //}
            //else
            //{
            //    if (cant == 0)
            //    {
            //        txtDisponibilidadBack.BackColor = Color.Red;
            //    }
            //    if (cant > 0 && cant <= 5)
            //    {
            //        txtDisponibilidadBack.BackColor = Color.Yellow;
            //    }
            //    if (cant >= 6)
            //    {
            //        txtDisponibilidadBack.BackColor = Color.Green;
            //    }

            //    txtDisponibilidadBack.Text = cant.ToString();
            //}

        }
        private void Disponibilidad()
        {
            //  var tipo = (TipoMembresia)cmbTipoMembresia.SelectedItem;
            var tipo = _tipoMembresiaSeleccionada;

            int? cant = 0;
            if (tipo != null)
            {
                MembresiaController con = new MembresiaController();
                cant = con.GetDisponibilidad(tipo);
            }

            if (cant == null)
            {
                txtDisponibilidadBack.Text = "";
                txtDisponibilidadBack.BackColor = Color.Transparent;
            }
            else
            {
                if (cant == 0)
                {
                    txtDisponibilidadBack.BackColor = Color.Red;
                }
                if (cant > 0 && cant <= 5)
                {
                    txtDisponibilidadBack.BackColor = Color.Yellow;
                }
                if (cant >= 6)
                {
                    txtDisponibilidadBack.BackColor = Color.Green;
                }

                txtDisponibilidadBack.Text = cant.ToString();
            }
        }
    }
}
