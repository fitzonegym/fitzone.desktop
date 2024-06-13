using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;

namespace Fitzone.Front.Socios
{
    public partial class FrmSociosAdmin : Form
    {
        List<Socio> listaSocios = new List<Socio>();
        public Socio? _SocioSeleccionado = null;
        public EnumModoFormulario _EnumModoFormulario = EnumModoFormulario.Consulta;

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

        public FrmSociosAdmin()
        {
            InitializeComponent();
            txtNombre.TB.KeyPress += txtCualquierFiltro_KeyPress;
            txtApellido.TB.KeyPress += txtCualquierFiltro_KeyPress;
            txtDocumento.TB.KeyPress += txtCualquierFiltro_KeyPress;
        }

        private void HabilitarDeshabilitarBotones(bool enableDisable)
        {
            btnAceptar.Enabled = btnAgregar.Enabled = btnCancelar.Enabled = btnModificar.Enabled = BtnAnular.Enabled = enableDisable;
        }
        private void VisibleBotones(bool visible)
        {
            btnAceptar.Visible = btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnAnular.Visible = visible;
        }

        private void FrmSociosAdmin_Load(object sender, EventArgs e)
        {
            VisibleBotones(false);

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (_EnumModoFormulario == EnumModoFormulario.Consulta)
            {
                btnAceptar.Visible = true;
                btnAceptar.Location = btnCancelar.Location;
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            Statics.WaitShow();
            SocioController c = new SocioController();

            Socio filter = new Socio();

            filter.nombre = txtNombre.Text;
            filter.apellido = txtApellido.Text;
            filter.numeroDocumento = txtDocumento.Text;

            listaSocios = c.GetAll(filter);
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = listaSocios;

            /*
            Equin.ApplicationFramework.BindingListView<Socio> view = new Equin.ApplicationFramework.BindingListView<Socio>(listaSocios);
            dataGridView1.DataSource = view;
            */

            if (listaSocios.Count == 0)
            {
                new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.NoSeEncontraronDatos).ShowDialog();
            }

            Statics.WaitHide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            /*
             
              FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta.MdiParent = this;
            panelPrincipal.Controls.Add(frmSociosAlta);
            frmSociosAlta.StartPosition = FormStartPosition.CenterParent;
            frmSociosAlta.Show();
             */

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Alta;

            frmSociosAlta.ShowDialog();

            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _SocioSeleccionado = null;
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Modificacion;

            frmSociosAlta._id_socio = ((Socio)bindingSource1.Current).idSocio;

            frmSociosAlta.ShowDialog();

            CargarGrilla();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            _SocioSeleccionado = ((Socio)bindingSource1.Current);
            Close();
        }

        private void txtCualquierFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarGrilla();
                // Prevenir el sonido de beep
                e.Handled = true;

            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            _SocioSeleccionado = ((Socio)bindingSource1.Current);
            Close();
        }
    }
}
