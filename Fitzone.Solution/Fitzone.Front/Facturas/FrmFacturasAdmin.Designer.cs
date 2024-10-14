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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ucCantidadregistros1 = new UserControls.UCCantidadregistros();
            bindingFactura = new BindingSource(components);
            txtNombreBack = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            btnConsultar = new ReaLTaiizor.Controls.CyberButton();
            txtFechaHasta = new DateTimePicker();
            txtFechaDesde = new DateTimePicker();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            groupBox1 = new GroupBox();
            ucClearFilters1 = new UserControls.UCClearFilters();
            txtSocio = new TextBox();
            ucBuscar1 = new UserControls.UCBuscar();
            chkFecha = new CheckBox();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            dataGridView1 = new DataGridView();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            letraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            metodoDePagoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ucPintarFilasPares1 = new UserControls.UCPintarFilasPares();
            btnImprimir = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)bindingFactura).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ucCantidadregistros1
            // 
            ucCantidadregistros1._cantidad = 0;
            ucCantidadregistros1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ucCantidadregistros1.BackColor = Color.Transparent;
            ucCantidadregistros1.Location = new Point(655, 124);
            ucCantidadregistros1.Name = "ucCantidadregistros1";
            ucCantidadregistros1.Size = new Size(103, 16);
            ucCantidadregistros1.TabIndex = 79;
            // 
            // bindingFactura
            // 
            bindingFactura.DataSource = typeof(Entidades.Factura);
            // 
            // txtNombreBack
            // 
            txtNombreBack.BackColor = Color.Transparent;
            txtNombreBack.EnabledCalc = true;
            txtNombreBack.Font = new Font("Segoe UI", 9F);
            txtNombreBack.ForeColor = Color.Black;
            txtNombreBack.Location = new Point(47, 17);
            txtNombreBack.MaxLength = 32767;
            txtNombreBack.MultiLine = false;
            txtNombreBack.Name = "txtNombreBack";
            txtNombreBack.ReadOnly = false;
            txtNombreBack.Size = new Size(233, 29);
            txtNombreBack.TabIndex = 49;
            txtNombreBack.TextAlign = HorizontalAlignment.Left;
            txtNombreBack.UseSystemPasswordChar = false;
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
            // btnConsultar
            // 
            btnConsultar.Alpha = 20;
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnConsultar.Location = new Point(564, 497);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.PenWidth = 15;
            btnConsultar.Rounding = true;
            btnConsultar.RoundingInt = 70;
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConsultar.TabIndex = 78;
            btnConsultar.Tag = "Cyber";
            btnConsultar.TextButton = "Consultar";
            btnConsultar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConsultar.Timer_Effect_1 = 5;
            btnConsultar.Timer_RGB = 300;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.CustomFormat = "dd/MM/yyyy";
            txtFechaHasta.Format = DateTimePickerFormat.Custom;
            txtFechaHasta.Location = new Point(542, 18);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.Size = new Size(86, 23);
            txtFechaHasta.TabIndex = 62;
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.CustomFormat = "dd/MM/yyyy";
            txtFechaDesde.Format = DateTimePickerFormat.Custom;
            txtFechaDesde.Location = new Point(405, 18);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.Size = new Size(86, 23);
            txtFechaDesde.TabIndex = 61;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(496, 25);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(57, 16);
            thunderLabel7.TabIndex = 60;
            thunderLabel7.Text = "Hasta";
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(360, 25);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(57, 16);
            thunderLabel6.TabIndex = 59;
            thunderLabel6.Text = "Desde";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(ucClearFilters1);
            groupBox1.Controls.Add(txtSocio);
            groupBox1.Controls.Add(ucBuscar1);
            groupBox1.Controls.Add(chkFecha);
            groupBox1.Controls.Add(txtFechaHasta);
            groupBox1.Controls.Add(txtNombreBack);
            groupBox1.Controls.Add(txtFechaDesde);
            groupBox1.Controls.Add(thunderLabel7);
            groupBox1.Controls.Add(thunderLabel6);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Location = new Point(8, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 56);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            // 
            // ucClearFilters1
            // 
            ucClearFilters1.Location = new Point(647, 16);
            ucClearFilters1.Name = "ucClearFilters1";
            ucClearFilters1.Size = new Size(25, 25);
            ucClearFilters1.TabIndex = 83;
            ucClearFilters1._ClickUCAgregar += ucClearFilters1__ClickUCAgregar;
            // 
            // txtSocio
            // 
            txtSocio.Enabled = false;
            txtSocio.Location = new Point(76, 20);
            txtSocio.Name = "txtSocio";
            txtSocio.Size = new Size(195, 23);
            txtSocio.TabIndex = 82;
            // 
            // ucBuscar1
            // 
            ucBuscar1.Location = new Point(56, 21);
            ucBuscar1.Name = "ucBuscar1";
            ucBuscar1.Size = new Size(20, 21);
            ucBuscar1.TabIndex = 81;
            ucBuscar1._ClickUC += ucBuscar1__ClickUC;
            // 
            // chkFecha
            // 
            chkFecha.AutoSize = true;
            chkFecha.Checked = true;
            chkFecha.CheckState = CheckState.Checked;
            chkFecha.ForeColor = Color.White;
            chkFecha.Location = new Point(297, 22);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(57, 19);
            chkFecha.TabIndex = 65;
            chkFecha.Text = "Fecha";
            chkFecha.UseVisualStyleBackColor = true;
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;
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
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 545);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(766, 3);
            ucBordertd2.TabIndex = 75;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(766, 3);
            ucBordertd1.TabIndex = 74;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(768, 0);
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
            botonesForms2.Location = new Point(720, 5);
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
            btnCancelar.Location = new Point(663, 497);
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
            btnCancelar.Click += btnCancelar_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, clienteNombreDataGridViewTextBoxColumn, tipoFacturaDataGridViewTextBoxColumn, letraDataGridViewTextBoxColumn, metodoDePagoDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingFactura;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(750, 345);
            dataGridView1.TabIndex = 68;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Nro";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteNombreDataGridViewTextBoxColumn
            // 
            clienteNombreDataGridViewTextBoxColumn.DataPropertyName = "clienteNombre";
            clienteNombreDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteNombreDataGridViewTextBoxColumn.Name = "clienteNombreDataGridViewTextBoxColumn";
            clienteNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoFacturaDataGridViewTextBoxColumn
            // 
            tipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "tipoFactura";
            tipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoFacturaDataGridViewTextBoxColumn.Name = "tipoFacturaDataGridViewTextBoxColumn";
            tipoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // letraDataGridViewTextBoxColumn
            // 
            letraDataGridViewTextBoxColumn.DataPropertyName = "letra";
            letraDataGridViewTextBoxColumn.HeaderText = "Letra";
            letraDataGridViewTextBoxColumn.Name = "letraDataGridViewTextBoxColumn";
            letraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoDePagoDataGridViewTextBoxColumn
            // 
            metodoDePagoDataGridViewTextBoxColumn.DataPropertyName = "metodoDePago";
            metodoDePagoDataGridViewTextBoxColumn.HeaderText = "Metodo de pago";
            metodoDePagoDataGridViewTextBoxColumn.Name = "metodoDePagoDataGridViewTextBoxColumn";
            metodoDePagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucPintarFilasPares1
            // 
            ucPintarFilasPares1._dataGridView = dataGridView1;
            ucPintarFilasPares1.BackColor = Color.FromArgb(103, 58, 183);
            ucPintarFilasPares1.Location = new Point(141, 100);
            ucPintarFilasPares1.Name = "ucPintarFilasPares1";
            ucPintarFilasPares1.Size = new Size(33, 27);
            ucPintarFilasPares1.TabIndex = 80;
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
            btnImprimir.Location = new Point(107, 101);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.PenWidth = 15;
            btnImprimir.Rounding = true;
            btnImprimir.RoundingInt = 70;
            btnImprimir.Size = new Size(99, 40);
            btnImprimir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnImprimir.TabIndex = 81;
            btnImprimir.Tag = "Cyber";
            btnImprimir.TextButton = "Imprimir";
            btnImprimir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnImprimir.Timer_Effect_1 = 5;
            btnImprimir.Timer_RGB = 300;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FrmFacturasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(770, 548);
            Controls.Add(btnImprimir);
            Controls.Add(ucPintarFilasPares1);
            Controls.Add(ucCantidadregistros1);
            Controls.Add(btnConsultar);
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
            Load += FrmFacturasAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)bindingFactura).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCCantidadregistros ucCantidadregistros1;
        private BindingSource bindingFactura;
        private ReaLTaiizor.Controls.AloneTextBox txtNombreBack;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberButton btnConsultar;
        private DateTimePicker txtFechaHasta;
        private DateTimePicker txtFechaDesde;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private DataGridView dataGridView1;
        private CheckBox chkFecha;
        private UserControls.UCPintarFilasPares ucPintarFilasPares1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn metodoDePagoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private TextBox txtSocio;
        private UserControls.UCBuscar ucBuscar1;
        private UserControls.UCClearFilters ucClearFilters1;
        private ReaLTaiizor.Controls.CyberButton btnImprimir;
    }
}