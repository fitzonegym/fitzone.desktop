namespace Fitzone.Front.Socios
{
    partial class FrmPagarCuota
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            dataGridView1 = new DataGridView();
            bindingSourceCuotas = new BindingSource(components);
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAceptar = new ReaLTaiizor.Controls.CyberButton();
            cmbTipoMembresia = new ReaLTaiizor.Controls.AloneComboBox();
            bindingSourceMembresia = new BindingSource(components);
            thunderLabel13 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            opPendientes = new RadioButton();
            opTodas = new RadioButton();
            opProxima = new RadioButton();
            groupBox1 = new GroupBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            cmbTipoPago = new ReaLTaiizor.Controls.AloneComboBox();
            aloneTextBox2 = new ReaLTaiizor.Controls.AloneTextBox();
            groupBox2 = new GroupBox();
            txtTotal = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            seleccionadaCol = new DataGridViewCheckBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaVencimientoCol = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagadaCol = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCuotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembresia).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(0, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(688, 3);
            ucBordertd1.TabIndex = 28;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(686, 3);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 569);
            ucBorderlr2.TabIndex = 29;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 3);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 569);
            ucBorderlr1.TabIndex = 30;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 569);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(684, 3);
            ucBordertd2.TabIndex = 31;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Registrar pago de Cuotas";
            ucTituloLabel1.AutoSize = true;
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(12, 12);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(209, 34);
            ucTituloLabel1.TabIndex = 32;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(630, 9);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(81, 45, 168);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { seleccionadaCol, numeroDataGridViewTextBoxColumn, fechaDesdeDataGridViewTextBoxColumn, fechaHastaDataGridViewTextBoxColumn, fechaVencimientoCol, precioDataGridViewTextBoxColumn, pagadaCol });
            dataGridView1.DataSource = bindingSourceCuotas;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(664, 269);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // bindingSourceCuotas
            // 
            bindingSourceCuotas.DataSource = typeof(Entidades.Cuota);
            bindingSourceCuotas.CurrentItemChanged += bindingSourceCuotas_CurrentItemChanged;
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
            btnCancelar.Location = new Point(581, 523);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 42;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Salir";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
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
            btnAceptar.Location = new Point(483, 523);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.PenWidth = 15;
            btnAceptar.Rounding = true;
            btnAceptar.RoundingInt = 70;
            btnAceptar.Size = new Size(99, 40);
            btnAceptar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAceptar.TabIndex = 41;
            btnAceptar.Tag = "Cyber";
            btnAceptar.TextButton = "Aceptar";
            btnAceptar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAceptar.Timer_Effect_1 = 5;
            btnAceptar.Timer_RGB = 300;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.DataSource = bindingSourceMembresia;
            cmbTipoMembresia.DisplayMember = "TipoMembresiaNombre";
            cmbTipoMembresia.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.EnabledCalc = true;
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.ItemHeight = 20;
            cmbTipoMembresia.Location = new Point(119, 55);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(317, 26);
            cmbTipoMembresia.TabIndex = 49;
            cmbTipoMembresia.ValueMember = "idMembresia";
            // 
            // bindingSourceMembresia
            // 
            bindingSourceMembresia.DataSource = typeof(Entidades.Membresia);
            bindingSourceMembresia.CurrentItemChanged += bindingSourceMembresia_CurrentItemChanged;
            // 
            // thunderLabel13
            // 
            thunderLabel13.BackColor = Color.Transparent;
            thunderLabel13.ForeColor = Color.WhiteSmoke;
            thunderLabel13.Location = new Point(9, 46);
            thunderLabel13.Name = "thunderLabel13";
            thunderLabel13.Size = new Size(76, 48);
            thunderLabel13.TabIndex = 67;
            thunderLabel13.Text = "Membresía";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(9, 29);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(46, 16);
            thunderLabel1.TabIndex = 67;
            thunderLabel1.Text = "Socio";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Enabled = false;
            txtNombre.EnabledCalc = false;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(109, 19);
            txtNombre.MaxLength = 32767;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(336, 29);
            txtNombre.TabIndex = 68;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.Enabled = false;
            aloneTextBox1.EnabledCalc = false;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.Black;
            aloneTextBox1.Location = new Point(109, 49);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(336, 39);
            aloneTextBox1.TabIndex = 69;
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // opPendientes
            // 
            opPendientes.AutoSize = true;
            opPendientes.ForeColor = Color.White;
            opPendientes.Location = new Point(192, 94);
            opPendientes.Name = "opPendientes";
            opPendientes.Size = new Size(83, 19);
            opPendientes.TabIndex = 82;
            opPendientes.Text = "Pendientes";
            opPendientes.UseVisualStyleBackColor = true;
            opPendientes.CheckedChanged += opPendientes_CheckedChanged;
            // 
            // opTodas
            // 
            opTodas.AutoSize = true;
            opTodas.ForeColor = Color.White;
            opTodas.Location = new Point(281, 94);
            opTodas.Name = "opTodas";
            opTodas.Size = new Size(55, 19);
            opTodas.TabIndex = 83;
            opTodas.Text = "Todas";
            opTodas.UseVisualStyleBackColor = true;
            opTodas.CheckedChanged += opTodas_CheckedChanged;
            // 
            // opProxima
            // 
            opProxima.AutoSize = true;
            opProxima.Checked = true;
            opProxima.ForeColor = Color.White;
            opProxima.Location = new Point(117, 94);
            opProxima.Name = "opProxima";
            opProxima.Size = new Size(69, 19);
            opProxima.TabIndex = 84;
            opProxima.TabStop = true;
            opProxima.Text = "Próxima";
            opProxima.UseVisualStyleBackColor = true;
            opProxima.CheckedChanged += opProxima_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cmbTipoMembresia);
            groupBox1.Controls.Add(opProxima);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Controls.Add(opTodas);
            groupBox1.Controls.Add(opPendientes);
            groupBox1.Controls.Add(thunderLabel13);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(aloneTextBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 120);
            groupBox1.TabIndex = 85;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(9, 32);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(93, 16);
            thunderLabel2.TabIndex = 85;
            thunderLabel2.Text = "Tipo de pago";
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.EnabledCalc = true;
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.ItemHeight = 20;
            cmbTipoPago.Items.AddRange(new object[] { "CONTADO", "DEBITO", "TRANSFERENCIA", "TARJETA CRÉDITO" });
            cmbTipoPago.Location = new Point(127, 22);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(148, 26);
            cmbTipoPago.TabIndex = 86;
            // 
            // aloneTextBox2
            // 
            aloneTextBox2.BackColor = Color.Transparent;
            aloneTextBox2.Enabled = false;
            aloneTextBox2.EnabledCalc = false;
            aloneTextBox2.Font = new Font("Segoe UI", 9F);
            aloneTextBox2.ForeColor = Color.Black;
            aloneTextBox2.Location = new Point(117, 16);
            aloneTextBox2.MaxLength = 32767;
            aloneTextBox2.MultiLine = false;
            aloneTextBox2.Name = "aloneTextBox2";
            aloneTextBox2.ReadOnly = false;
            aloneTextBox2.Size = new Size(168, 39);
            aloneTextBox2.TabIndex = 87;
            aloneTextBox2.TextAlign = HorizontalAlignment.Left;
            aloneTextBox2.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(thunderLabel3);
            groupBox2.Controls.Add(cmbTipoPago);
            groupBox2.Controls.Add(thunderLabel2);
            groupBox2.Controls.Add(aloneTextBox2);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(664, 64);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Pago";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Transparent;
            txtTotal.Enabled = false;
            txtTotal.EnabledCalc = false;
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(349, 22);
            txtTotal.MaxLength = 32767;
            txtTotal.MultiLine = false;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = false;
            txtTotal.Size = new Size(96, 29);
            txtTotal.TabIndex = 89;
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(306, 32);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(93, 16);
            thunderLabel3.TabIndex = 88;
            thunderLabel3.Text = "Total";
            // 
            // seleccionadaCol
            // 
            seleccionadaCol.DataPropertyName = "seleccionada";
            seleccionadaCol.HeaderText = " Seleccionar";
            seleccionadaCol.Name = "seleccionadaCol";
            seleccionadaCol.Width = 80;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numeroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            numeroDataGridViewTextBoxColumn.HeaderText = "Nro.";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Width = 50;
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
            // fechaVencimientoCol
            // 
            fechaVencimientoCol.DataPropertyName = "fechaVencimiento";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            fechaVencimientoCol.DefaultCellStyle = dataGridViewCellStyle2;
            fechaVencimientoCol.HeaderText = "Vencimiento";
            fechaVencimientoCol.Name = "fechaVencimientoCol";
            fechaVencimientoCol.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Total";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagadaCol
            // 
            pagadaCol.DataPropertyName = "pagada";
            pagadaCol.HeaderText = "Pagada";
            pagadaCol.Name = "pagadaCol";
            pagadaCol.ReadOnly = true;
            // 
            // FrmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(688, 572);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dataGridView1);
            Controls.Add(botonesForms2);
            Controls.Add(ucTituloLabel1);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBordertd1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagarCuota";
            Text = "FrmPagarCuota";
            Load += FrmPagarCuota_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCuotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembresia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBotonesForms botonesForms2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAceptar;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipoMembresia;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel13;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private BindingSource bindingSourceCuotas;
        private BindingSource bindingSourceMembresia;
        private RadioButton opPendientes;
        private RadioButton opTodas;
        private RadioButton opProxima;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipoPago;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.AloneTextBox txtTotal;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private DataGridViewCheckBoxColumn seleccionadaCol;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaVencimientoCol;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn pagadaCol;
    }
}