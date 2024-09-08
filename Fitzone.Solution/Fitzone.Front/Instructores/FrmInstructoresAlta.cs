using Emgu.CV;
using Emgu.CV.Util;
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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.Instructores
{
    public partial class FrmInstructoresAlta : Form
    {
        public int _idInstructor = 4;
        Instructor? _instructor;
        List<InstructorActividad> _listaInstructorActividad = new List<InstructorActividad>();
        public EnumModoForm _EnumModoForm = EnumModoForm.Modificacion;

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

        public FrmInstructoresAlta()
        {
            InitializeComponent();
        }

        private void FrmInstructoresAlta_Load(object sender, EventArgs e)
        {
            txtFechaNac.Value = DateTime.Now;

            CargarBarrios();
            CargarDatosInstructor();
            CargarActividadesCombo();

            if (_EnumModoForm == EnumModoForm.Consulta)
            {
                btnGuardar.Visible = false;
                HabilitarControlles(false);

                ucTitulo._titulo = "Consultar Instructor";
            }
            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                ucTitulo._titulo = "Modificar Instructor";
            }
            if (_EnumModoForm == EnumModoForm.Alta)
            {
                ucTitulo._titulo = "Agregar Instructor";
            }
        }

        private void CargarBarrios()
        {
            BarrioController c = new BarrioController();
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = c.GetAll();

        }

        private void CargarActividadesCombo()
        {
            ActividadController c = new ActividadController();
            bindingActividad.DataSource = null;
            bindingActividad.DataSource = c.GetAll();

        }

        private void CargarDatosInstructor()
        {

            InstructorController sc = new InstructorController();
            _instructor = sc.GetById(_idInstructor);
            if (_instructor == null)
                return;

            cmbBarrio.SelectedValue = _instructor.idBarrio;

            txtMail.Text = _instructor.mail;
            txtCalle.Text = _instructor.calle;
            txtCalleNro.Text = _instructor.calleNumero;

            txtNombre.Text = _instructor.nombre;
            txtApellido.Text = _instructor.apellido;
            txtNroDoc.Text = _instructor.numeroDocumento;

            rdbDNI.Checked = _instructor.tipoDocumento == "DNI";
            rdbOtro.Checked = _instructor.tipoDocumento != "DNI";

            txtCelular.Text = _instructor.telefono1;
            txtTelefono.Text = _instructor.telefono2;

            txtFechaNac.Value = _instructor.fechaNacimiento;


            _listaInstructorActividad = _instructor.InstructorActividades;
            bindingGrilla.DataSource = null;
            bindingGrilla.DataSource = _listaInstructorActividad;

            _Validating(null, null);
        }

        private void HabilitarControlles(bool _enabled)
        {
            cmbBarrio.EnabledCalc = _enabled;

            txtMail.Enabled = _enabled;
            txtCalle.Enabled = _enabled;
            txtCalleNro.Enabled = _enabled;

            txtNombre.Enabled = _enabled;
            txtApellido.Enabled = _enabled;
            txtNroDoc.Enabled = _enabled;

            txtFechaNac.Enabled = _enabled;

            rdbDNI.Enabled = _enabled;
            rdbOtro.Enabled = _enabled;

            txtCelular.Enabled = _enabled;
            txtTelefono.Enabled = _enabled;

//            cmbActividad.Enabled = _enabled;
            cmbActividad.EnabledCalc = _enabled;
            ucAgregar1.Enabled = _enabled;
            ucAgregar2.Enabled = _enabled;
            ucEliminar1.Enabled = _enabled;    

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardar()
        {
            MessageBoxCustom msg;

            if (_EnumModoForm == EnumModoForm.Alta)
            {
                _instructor = new Instructor();
                _instructor.idInstructor = 0;
            }

            if (_instructor == null) return; //solo para quitar el warning

            _instructor.idBarrio = ((Barrio)bindingSource1.Current).idBarrio;

            _instructor.mail = txtMail.Text;
            _instructor.anulado = false;

            _instructor.calle = txtCalle.Text;
            _instructor.calleNumero = txtCalleNro.Text;

            _instructor.nombre = txtNombre.Text;
            _instructor.apellido = txtApellido.Text;
            _instructor.numeroDocumento = txtNroDoc.Text;
            if (rdbDNI.Checked)
                _instructor.tipoDocumento = "DNI";
            else
                _instructor.tipoDocumento = "OTRO";
            _instructor.telefono1 = txtCelular.Text;
            _instructor.telefono2 = txtTelefono.Text;

            _instructor.fechaNacimiento = txtFechaNac.Value;

            // validaciones
            string mensajeErrores = "";
            if (!Validar(ref mensajeErrores, _instructor))
            {
                //si falla alguna validacion muestro el mensaje y no hago nada mas
                //msg = new MessageBoxCustom(mensajeErrores, Enumeraciones.EnumModoMessageBoxCustom.SeEncontraronErrores);
                msg = new MessageBoxCustom("Verifique los campos obligatorios", EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                return;
            }

            //listo para guardar
            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            InstructorController c = new InstructorController();

            try
            {
                if (_EnumModoForm == EnumModoForm.Alta)
                    c.Insert(_instructor);

                if (_EnumModoForm == EnumModoForm.Modificacion)
                    c.Update(_instructor, _instructor.idInstructor);
            }
            catch (Exception ex)
            {
                msg = new MessageBoxCustom(ex.Message, EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                return;
            }

            if (_EnumModoForm == EnumModoForm.Modificacion)
            {
                msg = new MessageBoxCustom("Se actualizaron los datos del instructor", EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                Close();
            }

            if (_EnumModoForm == EnumModoForm.Alta)
            {
                msg = new MessageBoxCustom("Se dió de alta el instructor " + "(" + _instructor.idInstructor.ToString() + ") " + _instructor.NombreCompleto + "\n¿Desea agregar uno nuevo?", EnumModoMessageBoxCustom.YesNo, 50);
                msg.ShowDialog();
                if (msg.response == DialogResult.No)
                    Close();
            }

            LimpiarTodo();

        }

        private bool Validar(ref string mensaje, Instructor e)
        {
            mensaje = "";


            if (String.IsNullOrWhiteSpace(e.nombre))
            {
                mensaje += "\nIngrese el nombre";
            }

            if (String.IsNullOrWhiteSpace(e.apellido))
            {
                mensaje += "\nIngrese el apellido";
            }

            string caracteresIndeseados = "()-., ";

            string nrodoc = new string(e.numeroDocumento.Where(c => !caracteresIndeseados.Contains(c)).ToArray());
            if (nrodoc.Length != 8)
            {
                mensaje += "\nIngrese el nro. de documento";
            }

            if (String.IsNullOrWhiteSpace(e.telefono1) || e.telefono1.Length != 10)
            {
                mensaje += "\nIngrese el celular";
            }


            if (!String.IsNullOrWhiteSpace(e.mail) && !IsValidEmail(e.mail))
            {
                mensaje += "\nIngrese el mail";
            }

            if (!String.IsNullOrWhiteSpace(mensaje))
            {
                return false;
            }

            return true;

        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void LimpiarTodo()
        {
            _instructor = new Instructor();
            cmbBarrio.SelectedValue = _instructor.idBarrio;

            txtMail.Text = _instructor.mail;
            txtCalle.Text = _instructor.calle;
            txtCalleNro.Text = _instructor.calleNumero;

            txtNombre.Text = _instructor.nombre;
            txtApellido.Text = _instructor.apellido;
            txtNroDoc.Text = _instructor.numeroDocumento;

            if (_instructor.tipoDocumento == "DNI")
                rdbDNI.Checked = true;
            else
                rdbOtro.Checked = true;

            txtCelular.Text = _instructor.telefono1;
            txtTelefono.Text = _instructor.telefono2;

            _Validating(null, null);

        }

        private void _Validating(object sender, CancelEventArgs e)
        {
            string caracteresIndeseados = "()-., ";

            //ucErrorIconoNroDoc.Visible = String.IsNullOrWhiteSpace(new string(txtNroDoc.Text.Where(c => !caracteresIndeseados.Contains(c)).ToArray()));           
            string nrodoc = new string(txtNroDoc.Text.Where(c => !caracteresIndeseados.Contains(c)).ToArray());
            ucErrorIconoNroDoc.Visible = nrodoc.Length != 8;

            string cel = new string(txtCelular.Text.Where(c => !caracteresIndeseados.Contains(c)).ToArray());
            ucErrorIconoCel.Visible = cel.Length != 10;

            ucErrorIconoNombre.Visible = String.IsNullOrWhiteSpace(txtNombre.Text);
            txtNombre.Text = Statics.Capitalize(txtNombre.Text);

            ucErrorIconoApellido.Visible = String.IsNullOrWhiteSpace(txtApellido.Text);
            txtApellido.Text = Statics.Capitalize(txtApellido.Text);

            ucErrorIconoMail.Visible = !String.IsNullOrWhiteSpace(txtMail.Text) && !IsValidEmail(txtMail.Text);

        }

        private void ucAgregar2__ClickUCAgregar(object sender, EventArgs e)
        {
            if (_listaInstructorActividad.FirstOrDefault(c=>c.ActividadNombre.Contains(cmbActividad.Text)) != null)
            {
                return;
            }



            InstructorActividad ia = new InstructorActividad();
            ia.idInstructor = _idInstructor;
            ia.idActividad = (int)cmbActividad.SelectedValue;
            ia.ActividadNombre = cmbActividad.Text;

            _listaInstructorActividad.Add(ia);

            RefreshGridActividades();   


        }

        private void ucEliminar1__ClickUCEliminar(object sender, EventArgs e)
        {
            var item = bindingGrilla.Current as InstructorActividad;
            if (item == null)
                return ;

            var membresias = new MembresiaController().GetActivasXInstructorXActividad(_idInstructor, item.idActividad);
            if (membresias.Count>0)
            {
                new MessageBoxCustom("No se puede quitar la actividad porque \nestá en uso en una membresía",EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return ;
            }


            _listaInstructorActividad.Remove(item);

            RefreshGridActividades();
        }

        private void RefreshGridActividades()
        {
            bindingGrilla.DataSource = null;
            bindingGrilla.DataSource = _listaInstructorActividad;
        }
       
    }
}
