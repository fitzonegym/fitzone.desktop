namespace Fitzone.Front.Facturas
{
    partial class FrmFacturasAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            ucCantidadregistros1 = new UserControls.UCCantidadregistros();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            estadoMembresiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            horaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnModificar = new ReaLTaiizor.Controls.CyberButton();
            txtFechaHasta = new DateTimePicker();
            txtFechaDesde = new DateTimePicker();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            groupBox1 = new GroupBox();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            horadesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            fechaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idMembresiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            fechaDesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ucCantidadregistros1
            // 
            ucCantidadregistros1._cantidad = 0;
            ucCantidadregistros1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ucCantidadregistros1.BackColor = Color.Transparent;
            ucCantidadregistros1.Location = new Point(1035, 124);
            ucCantidadregistros1.Name = "ucCantidadregistros1";
            ucCantidadregistros1.Size = new Size(103, 16);
            ucCantidadregistros1.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "fechaAlta";
            dataGridViewTextBoxColumn1.HeaderText = "Alta";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "EstadoMembresiaNombre";
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // estadoMembresiaDataGridViewTextBoxColumn
            // 
            estadoMembresiaDataGridViewTextBoxColumn.DataPropertyName = "EstadoMembresia";
            estadoMembresiaDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoMembresiaDataGridViewTextBoxColumn.Name = "estadoMembresiaDataGridViewTextBoxColumn";
            estadoMembresiaDataGridViewTextBoxColumn.ReadOnly = true;
            estadoMembresiaDataGridViewTextBoxColumn.Visible = false;
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
            txtNombre.Location = new Point(47, 17);
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
            thunderLabel1.Location = new Point(6, 25);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(57, 16);
            thunderLabel1.TabIndex = 48;
            thunderLabel1.Text = "Socio";
            // 
            // horaHastaDataGridViewTextBoxColumn
            // 
            horaHastaDataGridViewTextBoxColumn.DataPropertyName = "horaHasta";
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            horaHastaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            horaHastaDataGridViewTextBoxColumn.HeaderText = "Hora Hasta";
            horaHastaDataGridViewTextBoxColumn.Name = "horaHastaDataGridViewTextBoxColumn";
            horaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            horaHastaDataGridViewTextBoxColumn.Width = 70;
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
            btnModificar.Location = new Point(8, 496);
            btnModificar.Name = "btnModificar";
            btnModificar.PenWidth = 15;
            btnModificar.Rounding = true;
            btnModificar.RoundingInt = 70;
            btnModificar.Size = new Size(99, 40);
            btnModificar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnModificar.TabIndex = 78;
            btnModificar.Tag = "Cyber";
            btnModificar.TextButton = "Consultar";
            btnModificar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnModificar.Timer_Effect_1 = 5;
            btnModificar.Timer_RGB = 300;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.CustomFormat = "dd/MM/yyyy";
            txtFechaHasta.Format = DateTimePickerFormat.Custom;
            txtFechaHasta.Location = new Point(478, 18);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(86, 23);
            txtFechaHasta.TabIndex = 62;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.CustomFormat = "dd/MM/yyyy";
            txtFechaDesde.Format = DateTimePickerFormat.Custom;
            txtFechaDesde.Location = new Point(341, 18);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(86, 23);
            txtFechaDesde.TabIndex = 61;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(432, 25);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(57, 16);
            thunderLabel7.TabIndex = 60;
            thunderLabel7.Text = "Hasta";
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(296, 25);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(57, 16);
            thunderLabel6.TabIndex = 59;
            thunderLabel6.Text = "Desde";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtFechaHasta);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtFechaDesde);
            groupBox1.Controls.Add(thunderLabel7);
            groupBox1.Controls.Add(thunderLabel6);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Location = new Point(8, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 56);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
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
            btnFiltrar.Location = new Point(8, 100);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.PenWidth = 15;
            btnFiltrar.Rounding = true;
            btnFiltrar.RoundingInt = 70;
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFiltrar.TabIndex = 76;
            btnFiltrar.Tag = "Cyber";
            btnFiltrar.TextButton = "Filtrar";
            btnFiltrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFiltrar.Timer_Effect_1 = 5;
            btnFiltrar.Timer_RGB = 300;
            // 
            // horadesdeDataGridViewTextBoxColumn
            // 
            horadesdeDataGridViewTextBoxColumn.DataPropertyName = "horadesde";
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            horadesdeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            horadesdeDataGridViewTextBoxColumn.HeaderText = "Hora Desde";
            horadesdeDataGridViewTextBoxColumn.Name = "horadesdeDataGridViewTextBoxColumn";
            horadesdeDataGridViewTextBoxColumn.ReadOnly = true;
            horadesdeDataGridViewTextBoxColumn.Width = 70;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 545);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(1146, 3);
            ucBordertd2.TabIndex = 75;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(1146, 3);
            ucBordertd1.TabIndex = 74;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(1148, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 548);
            ucBorderlr2.TabIndex = 73;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 0);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 548);
            ucBorderlr1.TabIndex = 72;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Administrar facturas";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(2, 8);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(289, 34);
            ucTituloLabel1.TabIndex = 71;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(1100, 5);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 66;
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
            btnCancelar.Location = new Point(1040, 496);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 67;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Salir";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            // 
            // fechaHastaDataGridViewTextBoxColumn
            // 
            fechaHastaDataGridViewTextBoxColumn.DataPropertyName = "fechaHasta";
            fechaHastaDataGridViewTextBoxColumn.HeaderText = "Hasta";
            fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMembresiaDataGridViewTextBoxColumn
            // 
            idMembresiaDataGridViewTextBoxColumn.DataPropertyName = "idMembresia";
            idMembresiaDataGridViewTextBoxColumn.HeaderText = "Id";
            idMembresiaDataGridViewTextBoxColumn.Name = "idMembresiaDataGridViewTextBoxColumn";
            idMembresiaDataGridViewTextBoxColumn.ReadOnly = true;
            idMembresiaDataGridViewTextBoxColumn.Visible = false;
            idMembresiaDataGridViewTextBoxColumn.Width = 50;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "TipoMembresiaNombre";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "SocioNombre";
            dataGridViewTextBoxColumn5.HeaderText = "Socio";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "diasHabilitados";
            dataGridViewTextBoxColumn4.HeaderText = "Dias Habilitados";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "detalle";
            dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idMembresiaDataGridViewTextBoxColumn, Tipo, dataGridViewTextBoxColumn5, precioDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn2, fechaDesdeDataGridViewTextBoxColumn, fechaHastaDataGridViewTextBoxColumn, horadesdeDataGridViewTextBoxColumn, horaHastaDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, colEstado, estadoMembresiaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(1130, 345);
            dataGridView1.TabIndex = 68;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "fechaDesde";
            fechaDesdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmFacturasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(1150, 548);
            Controls.Add(ucCantidadregistros1);
            Controls.Add(btnModificar);
            Controls.Add(groupBox1);
            Controls.Add(btnFiltrar);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(botonesForms2);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFacturasAdmin";
            Text = "FrmFacturasAdmin";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCCantidadregistros ucCantidadregistros1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn estadoMembresiaDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private DataGridViewTextBoxColumn horaHastaDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.CyberButton btnModificar;
        private DateTimePicker txtFechaHasta;
        private DateTimePicker txtFechaDesde;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private DataGridViewTextBoxColumn horadesdeDataGridViewTextBoxColumn;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMembresiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
    }
}