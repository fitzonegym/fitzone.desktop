namespace Fitzone.Front.Membresias
{
    partial class FrmMembresiaAdmin
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
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            BtnAnular = new ReaLTaiizor.Controls.CyberButton();
            botonesForms2 = new UserControls.UCBotonesForms();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAgregar = new ReaLTaiizor.Controls.CyberButton();
            dataGridView1 = new DataGridView();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaAltaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detalleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDiasSemanalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasHabilitadosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            socioNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoMembresiaNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMembresiaNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            cmbTipoMembresia = new ReaLTaiizor.Controls.AloneComboBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 508);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(813, 3);
            ucBordertd2.TabIndex = 47;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(813, 3);
            ucBordertd1.TabIndex = 46;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(815, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 511);
            ucBorderlr2.TabIndex = 45;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 0);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 511);
            ucBorderlr1.TabIndex = 44;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Administrar membresías";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(2, 0);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(289, 34);
            ucTituloLabel1.TabIndex = 43;
            // 
            // BtnAnular
            // 
            BtnAnular.Alpha = 20;
            BtnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAnular.BackColor = Color.Transparent;
            BtnAnular.Background = true;
            BtnAnular.Background_WidthPen = 4F;
            BtnAnular.BackgroundPen = true;
            BtnAnular.ColorBackground = Color.Black;
            BtnAnular.ColorBackground_1 = Color.Black;
            BtnAnular.ColorBackground_2 = Color.Gray;
            BtnAnular.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            BtnAnular.ColorLighting = Color.FromArgb(81, 45, 168);
            BtnAnular.ColorPen_1 = Color.Black;
            BtnAnular.ColorPen_2 = Color.Gray;
            BtnAnular.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnAnular.Effect_1 = true;
            BtnAnular.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            BtnAnular.Effect_1_Transparency = 25;
            BtnAnular.Effect_2 = true;
            BtnAnular.Effect_2_ColorBackground = Color.White;
            BtnAnular.Effect_2_Transparency = 20;
            BtnAnular.Font = new Font("Arial", 11F);
            BtnAnular.ForeColor = Color.FromArgb(245, 245, 245);
            BtnAnular.Lighting = false;
            BtnAnular.LinearGradient_Background = false;
            BtnAnular.LinearGradientPen = false;
            BtnAnular.Location = new Point(612, 465);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.PenWidth = 15;
            BtnAnular.Rounding = true;
            BtnAnular.RoundingInt = 70;
            BtnAnular.Size = new Size(99, 40);
            BtnAnular.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnAnular.TabIndex = 41;
            BtnAnular.Tag = "Cyber";
            BtnAnular.TextButton = "Anular";
            BtnAnular.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnAnular.Timer_Effect_1 = 5;
            BtnAnular.Timer_RGB = 300;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(767, 5);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 29;
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
            btnCancelar.Location = new Point(709, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 38;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Alpha = 20;
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnAgregar.Location = new Point(513, 465);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.PenWidth = 15;
            btnAgregar.Rounding = true;
            btnAgregar.RoundingInt = 70;
            btnAgregar.Size = new Size(99, 40);
            btnAgregar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAgregar.TabIndex = 40;
            btnAgregar.Tag = "Cyber";
            btnAgregar.TextButton = "Agregar";
            btnAgregar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAgregar.Timer_Effect_1 = 5;
            btnAgregar.Timer_RGB = 300;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { precioDataGridViewTextBoxColumn, fechaAltaDataGridViewTextBoxColumn, fechaDesdeDataGridViewTextBoxColumn, fechaHastaDataGridViewTextBoxColumn, detalleDataGridViewTextBoxColumn, cantidadDiasSemanalesDataGridViewTextBoxColumn, diasHabilitadosDataGridViewTextBoxColumn, socioNombreDataGridViewTextBoxColumn, estadoMembresiaNombreDataGridViewTextBoxColumn, tipoMembresiaNombreDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(797, 320);
            dataGridView1.TabIndex = 39;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta";
            fechaAltaDataGridViewTextBoxColumn.HeaderText = "Alta";
            fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            fechaAltaDataGridViewTextBoxColumn.ReadOnly = true;
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
            fechaHastaDataGridViewTextBoxColumn.HeaderText = "Hasta";
            fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            detalleDataGridViewTextBoxColumn.DataPropertyName = "detalle";
            detalleDataGridViewTextBoxColumn.HeaderText = "detalle";
            detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            detalleDataGridViewTextBoxColumn.ReadOnly = true;
            detalleDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantidadDiasSemanalesDataGridViewTextBoxColumn
            // 
            cantidadDiasSemanalesDataGridViewTextBoxColumn.DataPropertyName = "cantidadDiasSemanales";
            cantidadDiasSemanalesDataGridViewTextBoxColumn.HeaderText = "Dias";
            cantidadDiasSemanalesDataGridViewTextBoxColumn.Name = "cantidadDiasSemanalesDataGridViewTextBoxColumn";
            cantidadDiasSemanalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasHabilitadosDataGridViewTextBoxColumn
            // 
            diasHabilitadosDataGridViewTextBoxColumn.DataPropertyName = "diasHabilitados";
            diasHabilitadosDataGridViewTextBoxColumn.HeaderText = "Habilitados";
            diasHabilitadosDataGridViewTextBoxColumn.Name = "diasHabilitadosDataGridViewTextBoxColumn";
            diasHabilitadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socioNombreDataGridViewTextBoxColumn
            // 
            socioNombreDataGridViewTextBoxColumn.DataPropertyName = "SocioNombre";
            socioNombreDataGridViewTextBoxColumn.HeaderText = "Socio";
            socioNombreDataGridViewTextBoxColumn.Name = "socioNombreDataGridViewTextBoxColumn";
            socioNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoMembresiaNombreDataGridViewTextBoxColumn
            // 
            estadoMembresiaNombreDataGridViewTextBoxColumn.DataPropertyName = "EstadoMembresiaNombre";
            estadoMembresiaNombreDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoMembresiaNombreDataGridViewTextBoxColumn.Name = "estadoMembresiaNombreDataGridViewTextBoxColumn";
            estadoMembresiaNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMembresiaNombreDataGridViewTextBoxColumn
            // 
            tipoMembresiaNombreDataGridViewTextBoxColumn.DataPropertyName = "TipoMembresiaNombre";
            tipoMembresiaNombreDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoMembresiaNombreDataGridViewTextBoxColumn.Name = "tipoMembresiaNombreDataGridViewTextBoxColumn";
            tipoMembresiaNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Membresia);
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.EnabledCalc = true;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(79, 40);
            txtNombre.MaxLength = 32767;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 49;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(16, 49);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(57, 16);
            thunderLabel1.TabIndex = 48;
            thunderLabel1.Text = "Socio";
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
            btnFiltrar.Location = new Point(443, 72);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.PenWidth = 15;
            btnFiltrar.Rounding = true;
            btnFiltrar.RoundingInt = 70;
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFiltrar.TabIndex = 50;
            btnFiltrar.Tag = "Cyber";
            btnFiltrar.TextButton = "Filtrar";
            btnFiltrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFiltrar.Timer_Effect_1 = 5;
            btnFiltrar.Timer_RGB = 300;
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.DisplayMember = "nombre";
            cmbTipoMembresia.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.EnabledCalc = true;
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.ItemHeight = 20;
            cmbTipoMembresia.Location = new Point(79, 86);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(307, 26);
            cmbTipoMembresia.TabIndex = 51;
            cmbTipoMembresia.ValueMember = "idTipoMembresia";
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(16, 96);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(57, 16);
            thunderLabel2.TabIndex = 52;
            thunderLabel2.Text = "Nombre";
            // 
            // FrmMembresiaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(817, 511);
            Controls.Add(thunderLabel2);
            Controls.Add(cmbTipoMembresia);
            Controls.Add(txtNombre);
            Controls.Add(thunderLabel1);
            Controls.Add(btnFiltrar);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(BtnAnular);
            Controls.Add(botonesForms2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMembresiaAdmin";
            Text = "Administrar Membresias";
            Load += FrmMembresiaAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private ReaLTaiizor.Controls.CyberButton BtnAnular;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAgregar;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDiasSemanalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasHabilitadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn socioNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoMembresiaNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMembresiaNombreDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipoMembresia;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
    }
}