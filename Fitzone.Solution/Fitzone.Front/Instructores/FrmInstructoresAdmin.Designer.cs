namespace Fitzone.Front.Instructores
{
    partial class FrmInstructoresAdmin
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
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            groupBox1 = new GroupBox();
            cmbTipoMembresia = new ReaLTaiizor.Controls.AloneComboBox();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            ucClearFilters1 = new UserControls.UCClearFilters();
            txtDocumento = new ReaLTaiizor.Controls.AloneTextBox();
            ucPintarFilasPares1 = new UserControls.UCPintarFilasPares();
            dataGridView1 = new DataGridView();
            idInstructorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCompletoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            calleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calleNumeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TieneImagen = new DataGridViewCheckBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anuladoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructorActividadesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBarrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingGrilla = new BindingSource(components);
            ucCantidadregistros1 = new UserControls.UCCantidadregistros();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            toolTip1 = new ToolTip(components);
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnImprimir = new ReaLTaiizor.Controls.CyberButton();
            btnModificar = new ReaLTaiizor.Controls.CyberButton();
            btnAgregar = new ReaLTaiizor.Controls.CyberButton();
            btnConsultar = new ReaLTaiizor.Controls.CyberButton();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingGrilla).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.EnabledCalc = true;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(116, 13);
            txtNombre.MaxLength = 30;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 6;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(8, 22);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(57, 16);
            thunderLabel1.TabIndex = 2;
            thunderLabel1.Text = "Nombre";
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(8, 53);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(56, 20);
            thunderLabel2.TabIndex = 12;
            thunderLabel2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Transparent;
            txtApellido.EnabledCalc = true;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(116, 44);
            txtApellido.MaxLength = 30;
            txtApellido.MultiLine = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = false;
            txtApellido.Size = new Size(233, 29);
            txtApellido.TabIndex = 13;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.UseSystemPasswordChar = false;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(8, 79);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(108, 22);
            thunderLabel3.TabIndex = 14;
            thunderLabel3.Text = "Nro. Documento";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbTipoMembresia);
            groupBox1.Controls.Add(aloneTextBox1);
            groupBox1.Controls.Add(thunderLabel4);
            groupBox1.Controls.Add(ucClearFilters1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Controls.Add(thunderLabel2);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(thunderLabel3);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 118);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTipoMembresia.DisplayMember = "TipoMembresiaNombre";
            cmbTipoMembresia.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.EnabledCalc = true;
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.ItemHeight = 20;
            cmbTipoMembresia.Location = new Point(477, 19);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(247, 26);
            cmbTipoMembresia.TabIndex = 70;
            cmbTipoMembresia.ValueMember = "idMembresia";
            cmbTipoMembresia.Visible = false;
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.Enabled = false;
            aloneTextBox1.EnabledCalc = false;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.Black;
            aloneTextBox1.Location = new Point(467, 12);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(266, 39);
            aloneTextBox1.TabIndex = 71;
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            aloneTextBox1.Visible = false;
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(363, 20);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(108, 22);
            thunderLabel4.TabIndex = 66;
            thunderLabel4.Text = "Tipo membresía";
            thunderLabel4.Visible = false;
            // 
            // ucClearFilters1
            // 
            ucClearFilters1.Location = new Point(363, 76);
            ucClearFilters1.Name = "ucClearFilters1";
            ucClearFilters1.Size = new Size(25, 25);
            ucClearFilters1.TabIndex = 65;
            toolTip1.SetToolTip(ucClearFilters1, "Limpiar filtros");
            ucClearFilters1.Load += ucClearFilters1_Load;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.Transparent;
            txtDocumento.EnabledCalc = true;
            txtDocumento.Font = new Font("Segoe UI", 9F);
            txtDocumento.ForeColor = Color.Black;
            txtDocumento.Location = new Point(116, 76);
            txtDocumento.MaxLength = 9;
            txtDocumento.MultiLine = false;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = false;
            txtDocumento.Size = new Size(233, 29);
            txtDocumento.TabIndex = 15;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.UseSystemPasswordChar = false;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // ucPintarFilasPares1
            // 
            ucPintarFilasPares1._dataGridView = dataGridView1;
            ucPintarFilasPares1.BackColor = Color.Transparent;
            ucPintarFilasPares1.Location = new Point(217, 161);
            ucPintarFilasPares1.Name = "ucPintarFilasPares1";
            ucPintarFilasPares1.Size = new Size(33, 27);
            ucPintarFilasPares1.TabIndex = 83;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idInstructorDataGridViewTextBoxColumn, nombreCompletoDataGridViewTextBoxColumn, tipoDocumentoDataGridViewTextBoxColumn, numeroDocumentoDataGridViewTextBoxColumn, telefono1DataGridViewTextBoxColumn, telefono2DataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, fechaAlta, calleDataGridViewTextBoxColumn, calleNumeroDataGridViewTextBoxColumn, barrioDataGridViewTextBoxColumn, TieneImagen, fechaNacimientoDataGridViewTextBoxColumn, anuladoDataGridViewCheckBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, instructorActividadesDataGridViewTextBoxColumn, idBarrioDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingGrilla;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(750, 217);
            dataGridView1.TabIndex = 71;
            // 
            // idInstructorDataGridViewTextBoxColumn
            // 
            idInstructorDataGridViewTextBoxColumn.DataPropertyName = "idInstructor";
            idInstructorDataGridViewTextBoxColumn.HeaderText = "idInstructor";
            idInstructorDataGridViewTextBoxColumn.Name = "idInstructorDataGridViewTextBoxColumn";
            idInstructorDataGridViewTextBoxColumn.ReadOnly = true;
            idInstructorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipoDocumento";
            tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo Doc.";
            tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "numeroDocumento";
            numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro Doc.";
            numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1";
            telefono1DataGridViewTextBoxColumn.HeaderText = "Celular";
            telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2";
            telefono2DataGridViewTextBoxColumn.HeaderText = "Teléfono";
            telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAlta
            // 
            fechaAlta.DataPropertyName = "fechaAlta";
            fechaAlta.HeaderText = "Fecha Alta";
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            calleDataGridViewTextBoxColumn.HeaderText = "calle";
            calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            calleDataGridViewTextBoxColumn.ReadOnly = true;
            calleDataGridViewTextBoxColumn.Visible = false;
            // 
            // calleNumeroDataGridViewTextBoxColumn
            // 
            calleNumeroDataGridViewTextBoxColumn.DataPropertyName = "calleNumero";
            calleNumeroDataGridViewTextBoxColumn.HeaderText = "calleNumero";
            calleNumeroDataGridViewTextBoxColumn.Name = "calleNumeroDataGridViewTextBoxColumn";
            calleNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            calleNumeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            barrioDataGridViewTextBoxColumn.DataPropertyName = "Barrio";
            barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            barrioDataGridViewTextBoxColumn.ReadOnly = true;
            barrioDataGridViewTextBoxColumn.Visible = false;
            // 
            // TieneImagen
            // 
            TieneImagen.DataPropertyName = "TieneImagen";
            TieneImagen.HeaderText = "Imagen [S/N]";
            TieneImagen.Name = "TieneImagen";
            TieneImagen.ReadOnly = true;
            TieneImagen.Visible = false;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaNacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            anuladoDataGridViewCheckBoxColumn.DataPropertyName = "anulado";
            anuladoDataGridViewCheckBoxColumn.HeaderText = "anulado";
            anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            anuladoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            apellidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // instructorActividadesDataGridViewTextBoxColumn
            // 
            instructorActividadesDataGridViewTextBoxColumn.DataPropertyName = "InstructorActividades";
            instructorActividadesDataGridViewTextBoxColumn.HeaderText = "InstructorActividades";
            instructorActividadesDataGridViewTextBoxColumn.Name = "instructorActividadesDataGridViewTextBoxColumn";
            instructorActividadesDataGridViewTextBoxColumn.ReadOnly = true;
            instructorActividadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBarrioDataGridViewTextBoxColumn
            // 
            idBarrioDataGridViewTextBoxColumn.DataPropertyName = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.HeaderText = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.Name = "idBarrioDataGridViewTextBoxColumn";
            idBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            idBarrioDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingGrilla
            // 
            bindingGrilla.DataSource = typeof(Entidades.Instructor);
            // 
            // ucCantidadregistros1
            // 
            ucCantidadregistros1._cantidad = 0;
            ucCantidadregistros1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ucCantidadregistros1.BackColor = Color.Transparent;
            ucCantidadregistros1.Location = new Point(663, 186);
            ucCantidadregistros1.Name = "ucCantidadregistros1";
            ucCantidadregistros1.Size = new Size(103, 16);
            ucCantidadregistros1.TabIndex = 82;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 479);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(773, 3);
            ucBordertd2.TabIndex = 79;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(773, 3);
            ucBordertd1.TabIndex = 78;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(775, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 482);
            ucBorderlr2.TabIndex = 77;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 0);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 482);
            ucBorderlr1.TabIndex = 76;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Administrar instructores";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(3, 2);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(208, 34);
            ucTituloLabel1.TabIndex = 75;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(728, 6);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 67;
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
            btnCancelar.Location = new Point(663, 431);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 70;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Salir";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            toolTip1.SetToolTip(btnCancelar, "Cancelar");
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Alpha = 20;
            btnImprimir.BackColor = Color.Transparent;
            btnImprimir.Background = true;
            btnImprimir.Background_WidthPen = 4F;
            btnImprimir.BackgroundPen = true;
            btnImprimir.ColorBackground = Color.Black;
            btnImprimir.ColorBackground_1 = Color.Black;
            btnImprimir.ColorBackground_2 = Color.Gray;
            btnImprimir.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnImprimir.ColorLighting = Color.FromArgb(81, 45, 168);
            btnImprimir.ColorPen_1 = Color.Black;
            btnImprimir.ColorPen_2 = Color.Gray;
            btnImprimir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnImprimir.Effect_1 = true;
            btnImprimir.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnImprimir.Effect_1_Transparency = 25;
            btnImprimir.Effect_2 = true;
            btnImprimir.Effect_2_ColorBackground = Color.White;
            btnImprimir.Effect_2_Transparency = 20;
            btnImprimir.Font = new Font("Arial", 11F);
            btnImprimir.ForeColor = Color.FromArgb(245, 245, 245);
            btnImprimir.Lighting = false;
            btnImprimir.LinearGradient_Background = false;
            btnImprimir.LinearGradientPen = false;
            btnImprimir.Location = new Point(112, 162);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.PenWidth = 15;
            btnImprimir.Rounding = true;
            btnImprimir.RoundingInt = 70;
            btnImprimir.Size = new Size(99, 40);
            btnImprimir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnImprimir.TabIndex = 80;
            btnImprimir.Tag = "Cyber";
            btnImprimir.TextButton = "Imprimir";
            btnImprimir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnImprimir.Timer_Effect_1 = 5;
            btnImprimir.Timer_RGB = 300;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Alpha = 20;
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.BackColor = Color.Transparent;
            btnModificar.Background = true;
            btnModificar.Background_WidthPen = 4F;
            btnModificar.BackgroundPen = true;
            btnModificar.ColorBackground = Color.Black;
            btnModificar.ColorBackground_1 = Color.Black;
            btnModificar.ColorBackground_2 = Color.Gray;
            btnModificar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnModificar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnModificar.ColorPen_1 = Color.Black;
            btnModificar.ColorPen_2 = Color.Gray;
            btnModificar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnModificar.Effect_1 = true;
            btnModificar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnModificar.Effect_1_Transparency = 25;
            btnModificar.Effect_2 = true;
            btnModificar.Effect_2_ColorBackground = Color.White;
            btnModificar.Effect_2_Transparency = 20;
            btnModificar.Font = new Font("Arial", 11F);
            btnModificar.ForeColor = Color.FromArgb(245, 245, 245);
            btnModificar.Lighting = false;
            btnModificar.LinearGradient_Background = false;
            btnModificar.LinearGradientPen = false;
            btnModificar.Location = new Point(104, 431);
            btnModificar.Name = "btnModificar";
            btnModificar.PenWidth = 15;
            btnModificar.Rounding = true;
            btnModificar.RoundingInt = 70;
            btnModificar.Size = new Size(99, 40);
            btnModificar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnModificar.TabIndex = 74;
            btnModificar.Tag = "Cyber";
            btnModificar.TextButton = "Modificar";
            btnModificar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnModificar.Timer_Effect_1 = 5;
            btnModificar.Timer_RGB = 300;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Alpha = 20;
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.Background = true;
            btnAgregar.Background_WidthPen = 4F;
            btnAgregar.BackgroundPen = true;
            btnAgregar.ColorBackground = Color.Black;
            btnAgregar.ColorBackground_1 = Color.Black;
            btnAgregar.ColorBackground_2 = Color.Gray;
            btnAgregar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnAgregar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnAgregar.ColorPen_1 = Color.Black;
            btnAgregar.ColorPen_2 = Color.Gray;
            btnAgregar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAgregar.Effect_1 = true;
            btnAgregar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnAgregar.Effect_1_Transparency = 25;
            btnAgregar.Effect_2 = true;
            btnAgregar.Effect_2_ColorBackground = Color.White;
            btnAgregar.Effect_2_Transparency = 20;
            btnAgregar.Font = new Font("Arial", 11F);
            btnAgregar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAgregar.Lighting = false;
            btnAgregar.LinearGradient_Background = false;
            btnAgregar.LinearGradientPen = false;
            btnAgregar.Location = new Point(7, 431);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.PenWidth = 15;
            btnAgregar.Rounding = true;
            btnAgregar.RoundingInt = 70;
            btnAgregar.Size = new Size(99, 40);
            btnAgregar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAgregar.TabIndex = 72;
            btnAgregar.Tag = "Cyber";
            btnAgregar.TextButton = "Agregar";
            btnAgregar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAgregar.Timer_Effect_1 = 5;
            btnAgregar.Timer_RGB = 300;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Alpha = 20;
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConsultar.BackColor = Color.Transparent;
            btnConsultar.Background = true;
            btnConsultar.Background_WidthPen = 4F;
            btnConsultar.BackgroundPen = true;
            btnConsultar.ColorBackground = Color.Black;
            btnConsultar.ColorBackground_1 = Color.Black;
            btnConsultar.ColorBackground_2 = Color.Gray;
            btnConsultar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnConsultar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnConsultar.ColorPen_1 = Color.Black;
            btnConsultar.ColorPen_2 = Color.Gray;
            btnConsultar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnConsultar.Effect_1 = true;
            btnConsultar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnConsultar.Effect_1_Transparency = 25;
            btnConsultar.Effect_2 = true;
            btnConsultar.Effect_2_ColorBackground = Color.White;
            btnConsultar.Effect_2_Transparency = 20;
            btnConsultar.Font = new Font("Arial", 11F);
            btnConsultar.ForeColor = Color.FromArgb(245, 245, 245);
            btnConsultar.Lighting = false;
            btnConsultar.LinearGradient_Background = false;
            btnConsultar.LinearGradientPen = false;
            btnConsultar.Location = new Point(202, 431);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.PenWidth = 15;
            btnConsultar.Rounding = true;
            btnConsultar.RoundingInt = 70;
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConsultar.TabIndex = 84;
            btnConsultar.Tag = "Cyber";
            btnConsultar.TextButton = "Consultar";
            btnConsultar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConsultar.Timer_Effect_1 = 5;
            btnConsultar.Timer_RGB = 300;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Alpha = 20;
            btnFiltrar.BackColor = Color.Transparent;
            btnFiltrar.Background = true;
            btnFiltrar.Background_WidthPen = 4F;
            btnFiltrar.BackgroundPen = true;
            btnFiltrar.ColorBackground = Color.Black;
            btnFiltrar.ColorBackground_1 = Color.Black;
            btnFiltrar.ColorBackground_2 = Color.Gray;
            btnFiltrar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnFiltrar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnFiltrar.ColorPen_1 = Color.Black;
            btnFiltrar.ColorPen_2 = Color.Gray;
            btnFiltrar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnFiltrar.Effect_1 = true;
            btnFiltrar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnFiltrar.Effect_1_Transparency = 25;
            btnFiltrar.Effect_2 = true;
            btnFiltrar.Effect_2_ColorBackground = Color.White;
            btnFiltrar.Effect_2_Transparency = 20;
            btnFiltrar.Font = new Font("Arial", 11F);
            btnFiltrar.ForeColor = Color.FromArgb(245, 245, 245);
            btnFiltrar.Lighting = false;
            btnFiltrar.LinearGradient_Background = false;
            btnFiltrar.LinearGradientPen = false;
            btnFiltrar.Location = new Point(12, 162);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.PenWidth = 15;
            btnFiltrar.Rounding = true;
            btnFiltrar.RoundingInt = 70;
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFiltrar.TabIndex = 68;
            btnFiltrar.Tag = "Cyber";
            btnFiltrar.TextButton = "Filtrar";
            btnFiltrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFiltrar.Timer_Effect_1 = 5;
            btnFiltrar.Timer_RGB = 300;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FrmInstructoresAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(777, 482);
            Controls.Add(groupBox1);
            Controls.Add(ucPintarFilasPares1);
            Controls.Add(ucCantidadregistros1);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(botonesForms2);
            Controls.Add(btnImprimir);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(btnConsultar);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInstructoresAdmin";
            Text = "FrmInstructoresAdmin";
            Load += FrmInstructoresAdmin_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private GroupBox groupBox1;
        private UserControls.UCClearFilters ucClearFilters1;
        private ToolTip toolTip1;
        private ReaLTaiizor.Controls.AloneTextBox txtDocumento;
        private UserControls.UCPintarFilasPares ucPintarFilasPares1;
        private DataGridView dataGridView1;
        private BindingSource bindingGrilla;
        private UserControls.UCCantidadregistros ucCantidadregistros1;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnImprimir;
        private ReaLTaiizor.Controls.CyberButton btnModificar;
        private ReaLTaiizor.Controls.CyberButton btnAgregar;
        private ReaLTaiizor.Controls.CyberButton btnConsultar;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipoMembresia;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private DataGridViewTextBoxColumn idInstructorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAlta;
        private DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleNumeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn TieneImagen;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructorActividadesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
    }
}