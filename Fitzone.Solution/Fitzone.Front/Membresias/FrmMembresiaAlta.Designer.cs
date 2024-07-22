namespace Fitzone.Front.Membresias
{
    partial class FrmMembresiaAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            botonesForms2 = new UserControls.UCBotonesForms();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            btnAceptar = new ReaLTaiizor.Controls.CyberButton();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            btnBuscarSocio = new ReaLTaiizor.Controls.CyberButton();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            txtDocumento = new ReaLTaiizor.Controls.AloneTextBox();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            idCuotaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idMembresiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ucBordertd1 = new UserControls.UCBorderTD();
            groupBox1 = new GroupBox();
            txtDireccion = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel11 = new ReaLTaiizor.Controls.ThunderLabel();
            txtTelefono = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel12 = new ReaLTaiizor.Controls.ThunderLabel();
            cmbTipoMembresia = new ReaLTaiizor.Controls.AloneComboBox();
            bindingSource2 = new BindingSource(components);
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            chkSabado = new CheckBox();
            chkViernes = new CheckBox();
            chkJueves = new CheckBox();
            chkMiercoles = new CheckBox();
            chkMartes = new CheckBox();
            chkLunes = new CheckBox();
            thunderLabel10 = new ReaLTaiizor.Controls.ThunderLabel();
            txtCantDias = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel9 = new ReaLTaiizor.Controls.ThunderLabel();
            cmdGenerar = new ReaLTaiizor.Controls.CyberButton();
            txtCuotas = new ReaLTaiizor.Controls.AloneTextBox();
            txtPrecio = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            txtDetalleTipo = new TextBox();
            txtFechaHasta = new DateTimePicker();
            txtFechaDesde = new DateTimePicker();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            ucTituloLabel2 = new UserControls.UCTituloLabel();
            thunderLabel8 = new ReaLTaiizor.Controls.ThunderLabel();
            txtDescripcionMembresía = new TextBox();
            ucAgregar1 = new UserControls.UCAgregar();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 679);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(694, 3);
            ucBordertd2.TabIndex = 47;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(696, 3);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 679);
            ucBorderlr2.TabIndex = 45;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 3);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 679);
            ucBorderlr1.TabIndex = 44;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Agregar Membresía";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(8, 5);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(165, 34);
            ucTituloLabel1.TabIndex = 43;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Enabled = false;
            txtNombre.EnabledCalc = false;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(112, 20);
            txtNombre.MaxLength = 32767;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 31;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(643, 7);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 29;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(4, 29);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(57, 16);
            thunderLabel1.TabIndex = 30;
            thunderLabel1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.Black;
            btnCancelar.ColorBackground_1 = Color.Black;
            btnCancelar.ColorBackground_2 = Color.Gray;
            btnCancelar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnCancelar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnCancelar.ColorPen_1 = Color.Black;
            btnCancelar.ColorPen_2 = Color.Gray;
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(589, 637);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 38;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Salir";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(4, 60);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(56, 20);
            thunderLabel2.TabIndex = 32;
            thunderLabel2.Text = "Apellido";
            // 
            // btnAceptar
            // 
            btnAceptar.Alpha = 20;
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.Background = true;
            btnAceptar.Background_WidthPen = 4F;
            btnAceptar.BackgroundPen = true;
            btnAceptar.ColorBackground = Color.Black;
            btnAceptar.ColorBackground_1 = Color.Black;
            btnAceptar.ColorBackground_2 = Color.Gray;
            btnAceptar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnAceptar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnAceptar.ColorPen_1 = Color.Black;
            btnAceptar.ColorPen_2 = Color.Gray;
            btnAceptar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAceptar.Effect_1 = true;
            btnAceptar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnAceptar.Effect_1_Transparency = 25;
            btnAceptar.Effect_2 = true;
            btnAceptar.Effect_2_ColorBackground = Color.White;
            btnAceptar.Effect_2_Transparency = 20;
            btnAceptar.Font = new Font("Arial", 11F);
            btnAceptar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAceptar.Lighting = false;
            btnAceptar.LinearGradient_Background = false;
            btnAceptar.LinearGradientPen = false;
            btnAceptar.Location = new Point(491, 637);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.PenWidth = 15;
            btnAceptar.Rounding = true;
            btnAceptar.RoundingInt = 70;
            btnAceptar.Size = new Size(99, 40);
            btnAceptar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAceptar.TabIndex = 37;
            btnAceptar.Tag = "Cyber";
            btnAceptar.TextButton = "Guardar";
            btnAceptar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAceptar.Timer_Effect_1 = 5;
            btnAceptar.Timer_RGB = 300;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Transparent;
            txtApellido.Enabled = false;
            txtApellido.EnabledCalc = false;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(112, 51);
            txtApellido.MaxLength = 32767;
            txtApellido.MultiLine = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = false;
            txtApellido.Size = new Size(233, 29);
            txtApellido.TabIndex = 33;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.UseSystemPasswordChar = false;
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Alpha = 20;
            btnBuscarSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarSocio.BackColor = Color.Transparent;
            btnBuscarSocio.Background = true;
            btnBuscarSocio.Background_WidthPen = 4F;
            btnBuscarSocio.BackgroundPen = true;
            btnBuscarSocio.ColorBackground = Color.Black;
            btnBuscarSocio.ColorBackground_1 = Color.Black;
            btnBuscarSocio.ColorBackground_2 = Color.Gray;
            btnBuscarSocio.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnBuscarSocio.ColorLighting = Color.FromArgb(81, 45, 168);
            btnBuscarSocio.ColorPen_1 = Color.Black;
            btnBuscarSocio.ColorPen_2 = Color.Gray;
            btnBuscarSocio.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnBuscarSocio.Effect_1 = true;
            btnBuscarSocio.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnBuscarSocio.Effect_1_Transparency = 25;
            btnBuscarSocio.Effect_2 = true;
            btnBuscarSocio.Effect_2_ColorBackground = Color.White;
            btnBuscarSocio.Effect_2_Transparency = 20;
            btnBuscarSocio.Font = new Font("Arial", 11F);
            btnBuscarSocio.ForeColor = Color.FromArgb(245, 245, 245);
            btnBuscarSocio.Lighting = false;
            btnBuscarSocio.LinearGradient_Background = false;
            btnBuscarSocio.LinearGradientPen = false;
            btnBuscarSocio.Location = new Point(246, 203);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.PenWidth = 15;
            btnBuscarSocio.Rounding = true;
            btnBuscarSocio.RoundingInt = 70;
            btnBuscarSocio.Size = new Size(99, 40);
            btnBuscarSocio.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBuscarSocio.TabIndex = 36;
            btnBuscarSocio.Tag = "Cyber";
            btnBuscarSocio.TextButton = "Buscar";
            btnBuscarSocio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBuscarSocio.Timer_Effect_1 = 5;
            btnBuscarSocio.Timer_RGB = 300;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(4, 95);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(107, 16);
            thunderLabel3.TabIndex = 34;
            thunderLabel3.Text = "Nro. Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.Transparent;
            txtDocumento.Enabled = false;
            txtDocumento.EnabledCalc = false;
            txtDocumento.Font = new Font("Segoe UI", 9F);
            txtDocumento.ForeColor = Color.Black;
            txtDocumento.Location = new Point(112, 86);
            txtDocumento.MaxLength = 32767;
            txtDocumento.MultiLine = false;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = false;
            txtDocumento.Size = new Size(233, 29);
            txtDocumento.TabIndex = 35;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.UseSystemPasswordChar = false;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Cuota);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(81, 45, 168);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numeroDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, fechaDesdeDataGridViewTextBoxColumn, fechaHastaDataGridViewTextBoxColumn, fechaVencimiento, idCuotaDataGridViewTextBoxColumn, idMembresiaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 423);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(674, 211);
            dataGridView1.TabIndex = 39;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Nro";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "fechaDesde";
            fechaDesdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHastaDataGridViewTextBoxColumn
            // 
            fechaHastaDataGridViewTextBoxColumn.DataPropertyName = "fechaHasta";
            fechaHastaDataGridViewTextBoxColumn.HeaderText = "fechaHasta";
            fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            fechaHastaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaVencimiento
            // 
            fechaVencimiento.DataPropertyName = "fechaVencimiento";
            fechaVencimiento.HeaderText = "Vencimiento";
            fechaVencimiento.Name = "fechaVencimiento";
            fechaVencimiento.ReadOnly = true;
            // 
            // idCuotaDataGridViewTextBoxColumn
            // 
            idCuotaDataGridViewTextBoxColumn.DataPropertyName = "idCuota";
            idCuotaDataGridViewTextBoxColumn.HeaderText = "idCuota";
            idCuotaDataGridViewTextBoxColumn.Name = "idCuotaDataGridViewTextBoxColumn";
            idCuotaDataGridViewTextBoxColumn.ReadOnly = true;
            idCuotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMembresiaDataGridViewTextBoxColumn
            // 
            idMembresiaDataGridViewTextBoxColumn.DataPropertyName = "idMembresia";
            idMembresiaDataGridViewTextBoxColumn.HeaderText = "idMembresia";
            idMembresiaDataGridViewTextBoxColumn.Name = "idMembresiaDataGridViewTextBoxColumn";
            idMembresiaDataGridViewTextBoxColumn.ReadOnly = true;
            idMembresiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(0, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(698, 3);
            ucBordertd1.TabIndex = 46;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(thunderLabel11);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(thunderLabel12);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(thunderLabel3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(thunderLabel2);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnBuscarSocio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 249);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Socio";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Transparent;
            txtDireccion.Enabled = false;
            txtDireccion.EnabledCalc = false;
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(112, 156);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MultiLine = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = false;
            txtDireccion.Size = new Size(233, 29);
            txtDireccion.TabIndex = 40;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.UseSystemPasswordChar = false;
            // 
            // thunderLabel11
            // 
            thunderLabel11.BackColor = Color.Transparent;
            thunderLabel11.ForeColor = Color.WhiteSmoke;
            thunderLabel11.Location = new Point(4, 165);
            thunderLabel11.Name = "thunderLabel11";
            thunderLabel11.Size = new Size(107, 16);
            thunderLabel11.TabIndex = 39;
            thunderLabel11.Text = "Dirección";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.Enabled = false;
            txtTelefono.EnabledCalc = false;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(112, 121);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MultiLine = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = false;
            txtTelefono.Size = new Size(233, 29);
            txtTelefono.TabIndex = 38;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // thunderLabel12
            // 
            thunderLabel12.BackColor = Color.Transparent;
            thunderLabel12.ForeColor = Color.WhiteSmoke;
            thunderLabel12.Location = new Point(4, 130);
            thunderLabel12.Name = "thunderLabel12";
            thunderLabel12.Size = new Size(102, 20);
            thunderLabel12.TabIndex = 37;
            thunderLabel12.Text = "Teléfono";
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.DataSource = bindingSource2;
            cmbTipoMembresia.DisplayMember = "nombre";
            cmbTipoMembresia.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.EnabledCalc = true;
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.ItemHeight = 20;
            cmbTipoMembresia.Location = new Point(6, 22);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(307, 26);
            cmbTipoMembresia.TabIndex = 49;
            cmbTipoMembresia.ValueMember = "idTipoMembresia";
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Entidades.TipoMembresia);
            bindingSource2.CurrentItemChanged += bindingSource2_CurrentItemChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(chkSabado);
            groupBox2.Controls.Add(chkViernes);
            groupBox2.Controls.Add(chkJueves);
            groupBox2.Controls.Add(chkMiercoles);
            groupBox2.Controls.Add(chkMartes);
            groupBox2.Controls.Add(chkLunes);
            groupBox2.Controls.Add(thunderLabel10);
            groupBox2.Controls.Add(txtCantDias);
            groupBox2.Controls.Add(thunderLabel9);
            groupBox2.Controls.Add(cmdGenerar);
            groupBox2.Controls.Add(txtCuotas);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(thunderLabel5);
            groupBox2.Controls.Add(thunderLabel4);
            groupBox2.Controls.Add(txtDetalleTipo);
            groupBox2.Controls.Add(cmbTipoMembresia);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(368, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 249);
            groupBox2.TabIndex = 51;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de membresía";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(276, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(34, 19);
            checkBox1.TabIndex = 66;
            checkBox1.Text = "D";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Enabled = false;
            chkSabado.ForeColor = Color.White;
            chkSabado.Location = new Point(240, 182);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(32, 19);
            chkSabado.TabIndex = 65;
            chkSabado.Text = "S";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Enabled = false;
            chkViernes.ForeColor = Color.White;
            chkViernes.Location = new Point(200, 182);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(33, 19);
            chkViernes.TabIndex = 64;
            chkViernes.Text = "V";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Enabled = false;
            chkJueves.ForeColor = Color.White;
            chkJueves.Location = new Point(162, 182);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(30, 19);
            chkJueves.TabIndex = 63;
            chkJueves.Text = "J";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Enabled = false;
            chkMiercoles.ForeColor = Color.White;
            chkMiercoles.Location = new Point(240, 148);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(40, 19);
            chkMiercoles.TabIndex = 62;
            chkMiercoles.Text = "Mi";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Enabled = false;
            chkMartes.ForeColor = Color.White;
            chkMartes.Location = new Point(200, 148);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(43, 19);
            chkMartes.TabIndex = 61;
            chkMartes.Text = "Ma";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Enabled = false;
            chkLunes.ForeColor = Color.White;
            chkLunes.Location = new Point(162, 148);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(32, 19);
            chkLunes.TabIndex = 60;
            chkLunes.Text = "L";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // thunderLabel10
            // 
            thunderLabel10.BackColor = Color.Transparent;
            thunderLabel10.ForeColor = Color.WhiteSmoke;
            thunderLabel10.Location = new Point(162, 113);
            thunderLabel10.Name = "thunderLabel10";
            thunderLabel10.Size = new Size(138, 16);
            thunderLabel10.TabIndex = 59;
            thunderLabel10.Text = "Días a la semana";
            // 
            // txtCantDias
            // 
            txtCantDias.BackColor = Color.Transparent;
            txtCantDias.Enabled = false;
            txtCantDias.EnabledCalc = false;
            txtCantDias.Font = new Font("Segoe UI", 9F);
            txtCantDias.ForeColor = Color.Black;
            txtCantDias.Location = new Point(80, 177);
            txtCantDias.MaxLength = 32767;
            txtCantDias.MultiLine = false;
            txtCantDias.Name = "txtCantDias";
            txtCantDias.ReadOnly = true;
            txtCantDias.Size = new Size(55, 29);
            txtCantDias.TabIndex = 58;
            txtCantDias.TextAlign = HorizontalAlignment.Left;
            txtCantDias.UseSystemPasswordChar = false;
            // 
            // thunderLabel9
            // 
            thunderLabel9.BackColor = Color.Transparent;
            thunderLabel9.ForeColor = Color.WhiteSmoke;
            thunderLabel9.Location = new Point(12, 177);
            thunderLabel9.Name = "thunderLabel9";
            thunderLabel9.Size = new Size(73, 29);
            thunderLabel9.TabIndex = 57;
            thunderLabel9.Text = "Cant. días max";
            // 
            // cmdGenerar
            // 
            cmdGenerar.Alpha = 20;
            cmdGenerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmdGenerar.BackColor = Color.Transparent;
            cmdGenerar.Background = true;
            cmdGenerar.Background_WidthPen = 4F;
            cmdGenerar.BackgroundPen = true;
            cmdGenerar.ColorBackground = Color.Black;
            cmdGenerar.ColorBackground_1 = Color.Black;
            cmdGenerar.ColorBackground_2 = Color.Gray;
            cmdGenerar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cmdGenerar.ColorLighting = Color.FromArgb(81, 45, 168);
            cmdGenerar.ColorPen_1 = Color.Black;
            cmdGenerar.ColorPen_2 = Color.Gray;
            cmdGenerar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cmdGenerar.Effect_1 = true;
            cmdGenerar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cmdGenerar.Effect_1_Transparency = 25;
            cmdGenerar.Effect_2 = true;
            cmdGenerar.Effect_2_ColorBackground = Color.White;
            cmdGenerar.Effect_2_Transparency = 20;
            cmdGenerar.Font = new Font("Arial", 11F);
            cmdGenerar.ForeColor = Color.FromArgb(245, 245, 245);
            cmdGenerar.Lighting = false;
            cmdGenerar.LinearGradient_Background = false;
            cmdGenerar.LinearGradientPen = false;
            cmdGenerar.Location = new Point(196, 203);
            cmdGenerar.Name = "cmdGenerar";
            cmdGenerar.PenWidth = 15;
            cmdGenerar.Rounding = true;
            cmdGenerar.RoundingInt = 70;
            cmdGenerar.Size = new Size(123, 40);
            cmdGenerar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cmdGenerar.TabIndex = 37;
            cmdGenerar.Tag = "Cyber";
            cmdGenerar.TextButton = "Generar Cuotas";
            cmdGenerar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cmdGenerar.Timer_Effect_1 = 5;
            cmdGenerar.Timer_RGB = 300;
            cmdGenerar.Click += cmdGenerar_Click;
            // 
            // txtCuotas
            // 
            txtCuotas.BackColor = Color.Transparent;
            txtCuotas.Enabled = false;
            txtCuotas.EnabledCalc = false;
            txtCuotas.Font = new Font("Segoe UI", 9F);
            txtCuotas.ForeColor = Color.Black;
            txtCuotas.Location = new Point(80, 142);
            txtCuotas.MaxLength = 32767;
            txtCuotas.MultiLine = false;
            txtCuotas.Name = "txtCuotas";
            txtCuotas.ReadOnly = true;
            txtCuotas.Size = new Size(55, 29);
            txtCuotas.TabIndex = 56;
            txtCuotas.TextAlign = HorizontalAlignment.Left;
            txtCuotas.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.Transparent;
            txtPrecio.Enabled = false;
            txtPrecio.EnabledCalc = false;
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(77, 107);
            txtPrecio.MaxLength = 32767;
            txtPrecio.MultiLine = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(79, 29);
            txtPrecio.TabIndex = 55;
            txtPrecio.TextAlign = HorizontalAlignment.Left;
            txtPrecio.UseSystemPasswordChar = false;
            // 
            // thunderLabel5
            // 
            thunderLabel5.BackColor = Color.Transparent;
            thunderLabel5.ForeColor = Color.WhiteSmoke;
            thunderLabel5.Location = new Point(12, 142);
            thunderLabel5.Name = "thunderLabel5";
            thunderLabel5.Size = new Size(50, 29);
            thunderLabel5.TabIndex = 52;
            thunderLabel5.Text = "Cant. cuotas";
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(14, 113);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(57, 16);
            thunderLabel4.TabIndex = 51;
            thunderLabel4.Text = "Precio";
            // 
            // txtDetalleTipo
            // 
            txtDetalleTipo.Enabled = false;
            txtDetalleTipo.Location = new Point(6, 54);
            txtDetalleTipo.Multiline = true;
            txtDetalleTipo.Name = "txtDetalleTipo";
            txtDetalleTipo.Size = new Size(307, 47);
            txtDetalleTipo.TabIndex = 50;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.CustomFormat = "dd/MM/yyyy";
            txtFechaHasta.Enabled = false;
            txtFechaHasta.Format = DateTimePickerFormat.Custom;
            txtFechaHasta.Location = new Point(68, 51);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(86, 23);
            txtFechaHasta.TabIndex = 58;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.CustomFormat = "dd/MM/yyyy";
            txtFechaDesde.Format = DateTimePickerFormat.Custom;
            txtFechaDesde.Location = new Point(68, 22);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(86, 23);
            txtFechaDesde.TabIndex = 57;
            txtFechaDesde.ValueChanged += txtFechaDesde_ValueChanged;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(5, 51);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(57, 16);
            thunderLabel7.TabIndex = 54;
            thunderLabel7.Text = "Hasta";
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(5, 22);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(57, 16);
            thunderLabel6.TabIndex = 53;
            thunderLabel6.Text = "Desde";
            // 
            // ucTituloLabel2
            // 
            ucTituloLabel2._titulo = "Cuotas";
            ucTituloLabel2.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel2.Location = new Point(11, 391);
            ucTituloLabel2.Name = "ucTituloLabel2";
            ucTituloLabel2.Size = new Size(65, 34);
            ucTituloLabel2.TabIndex = 53;
            // 
            // thunderLabel8
            // 
            thunderLabel8.BackColor = Color.Transparent;
            thunderLabel8.ForeColor = Color.WhiteSmoke;
            thunderLabel8.Location = new Point(171, 22);
            thunderLabel8.Name = "thunderLabel8";
            thunderLabel8.Size = new Size(92, 16);
            thunderLabel8.TabIndex = 59;
            thunderLabel8.Text = "Descripción";
            // 
            // txtDescripcionMembresía
            // 
            txtDescripcionMembresía.Location = new Point(250, 22);
            txtDescripcionMembresía.Multiline = true;
            txtDescripcionMembresía.Name = "txtDescripcionMembresía";
            txtDescripcionMembresía.ScrollBars = ScrollBars.Both;
            txtDescripcionMembresía.Size = new Size(421, 71);
            txtDescripcionMembresía.TabIndex = 60;
            // 
            // ucAgregar1
            // 
            ucAgregar1.BackColor = Color.Transparent;
            ucAgregar1.Location = new Point(171, 44);
            ucAgregar1.Name = "ucAgregar1";
            ucAgregar1.Size = new Size(20, 20);
            ucAgregar1.TabIndex = 61;
            ucAgregar1._ClickUCAgregar += ucAgregar1__ClickUCAgregar;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDescripcionMembresía);
            groupBox3.Controls.Add(ucAgregar1);
            groupBox3.Controls.Add(thunderLabel6);
            groupBox3.Controls.Add(thunderLabel7);
            groupBox3.Controls.Add(thunderLabel8);
            groupBox3.Controls.Add(txtFechaDesde);
            groupBox3.Controls.Add(txtFechaHasta);
            groupBox3.Location = new Point(12, 291);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(674, 107);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            // 
            // FrmMembresiaAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(698, 682);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(botonesForms2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dataGridView1);
            Controls.Add(ucBordertd1);
            Controls.Add(groupBox3);
            Controls.Add(ucTituloLabel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMembresiaAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMembresia";
            Load += FrmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.CyberButton btnAceptar;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.CyberButton btnBuscarSocio;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.AloneTextBox txtDocumento;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private UserControls.UCBorderTD ucBordertd1;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipoMembresia;
        private BindingSource bindingSource2;
        private GroupBox groupBox2;
        private DateTimePicker txtFechaDesde;
        private ReaLTaiizor.Controls.AloneTextBox txtCuotas;
        private ReaLTaiizor.Controls.AloneTextBox txtPrecio;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel5;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private TextBox txtDetalleTipo;
        private DateTimePicker txtFechaHasta;
        private ReaLTaiizor.Controls.CyberButton cmdGenerar;
        private UserControls.UCTituloLabel ucTituloLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel8;
        private TextBox txtDescripcionMembresía;
        private UserControls.UCAgregar ucAgregar1;
        private CheckBox chkLunes;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel10;
        private ReaLTaiizor.Controls.AloneTextBox txtCantDias;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel9;
        private ReaLTaiizor.Controls.AloneTextBox txtDireccion;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel11;
        private ReaLTaiizor.Controls.AloneTextBox txtTelefono;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel12;
        private CheckBox chkSabado;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaVencimiento;
        private DataGridViewTextBoxColumn idCuotaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMembresiaDataGridViewTextBoxColumn;
        private GroupBox groupBox3;
    }
}