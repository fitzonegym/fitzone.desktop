using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitzone.Front.Instructores
{
    public partial class FrmInstructoresAdmin : Form
    {
        List<Instructor> _listaInstructores = new List<Instructor>();
        public Instructor? _INstructorSeleccionado = null;
        public EnumModoFormulario _EnumModoFormulario = EnumModoFormulario.Administracion;

        bool primeraCarga = true;
        string ordenadoPor = "";

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
        public FrmInstructoresAdmin()
        {
            InitializeComponent();
            txtNombre.TB.KeyPress += filtro_KeyPress;
            txtApellido.TB.KeyPress += filtro_KeyPress;
            txtDocumento.TB.KeyPress += filtro_KeyPress;

        }
        private void LimpiarFiltros()
        {
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
        }

        private void filtro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarGrilla();
                // Prevenir el sonido de beep
                e.Handled = true;

            }
            
        }

        private void FrmInstructoresAdmin_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();

            CargarTipos();

            if (_EnumModoFormulario == EnumModoFormulario.Consulta)
            {

                btnCancelar.Visible = true;
                // btnAceptar.Location = btnCancelar.Location;
                CargarGrilla();
            }
            if (_EnumModoFormulario == EnumModoFormulario.Administracion)
            {
                // btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnAnular.Visible = true;

                this.WindowState = FormWindowState.Maximized;
                CargarGrilla();
            }

            //dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);

        }

        private void CargarGrilla()
        {

            InstructorController c = new InstructorController();

            Instructor filter = new Instructor();

            filter.nombre = txtNombre.Text.Trim();
            filter.apellido = txtApellido.Text.Trim();
            filter.numeroDocumento = txtDocumento.Text.Trim();
            filter.idTipoMembresiaFiltro = (int)cmbTipoMembresia.SelectedValue;

            string acti = ((Actividad)bindingActividad.Current).nombre;

            _listaInstructores = c.GetAll(filter).Where(c =>  c.ActividadesNames.Contains(acti) || acti == "TODOS").ToList();

            bindingGrilla.DataSource = null;
            bindingGrilla.DataSource = _listaInstructores;

            ucCantidadregistros1._cantidad = _listaInstructores.Count();

            if (_listaInstructores.Count == 0 && !primeraCarga)
            {
                new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.NoSeEncontraronDatos).ShowDialog();
                return;
            }

            //dataGridView1.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            primeraCarga = false;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInstructoresAlta frm = new FrmInstructoresAlta();
            frm._EnumModoForm = EnumModoForm.Alta;
            frm._idInstructor = 0;

            frm.ShowDialog();

            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bindingGrilla.DataSource == null || bindingGrilla.Current == null)
            {
                new MessageBoxCustom("Seleccione un instructor", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmInstructoresAlta frm = new FrmInstructoresAlta();
            frm._EnumModoForm = EnumModoForm.Modificacion;

            frm._idInstructor = ((Instructor)bindingGrilla.Current).idInstructor;

            frm.ShowDialog();

            CargarGrilla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bindingGrilla == null || bindingGrilla.Current == null)
            {
                new MessageBoxCustom("Seleccione un instructor", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmInstructoresAlta frm = new FrmInstructoresAlta();
            frm._EnumModoForm = EnumModoForm.Consulta;
            frm._idInstructor = ((Instructor)bindingGrilla.Current).idInstructor;

            frm.ShowDialog();

            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }     

        private void ucClearFilters1__ClickUCAgregar(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
        private void CargarTipos()
        {
            ActividadController membresiaController = new ActividadController();
            var membresias = membresiaController.GetAll();
            membresias.Insert(0,new Actividad{ idActividad = 0, nombre = "TODOS" });
            bindingActividad.DataSource = membresias;


        }
    }
}
