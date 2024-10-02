﻿namespace Fitzone.Front.Socios
{
    partial class FrmSociosAdmin
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
            btnModificar = new ReaLTaiizor.Controls.CyberButton();
            BtnMembresía = new ReaLTaiizor.Controls.CyberButton();
            btnAgregar = new ReaLTaiizor.Controls.CyberButton();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAceptar = new ReaLTaiizor.Controls.CyberButton();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            txtDocumento = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBordertd2 = new UserControls.UCBorderTD();
            btnImprimir = new ReaLTaiizor.Controls.CyberButton();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            txtFechaDesde = new DateTimePicker();
            txtFechaHasta = new DateTimePicker();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            groupBox1 = new GroupBox();
            chkAnulados = new ReaLTaiizor.Controls.AloneCheckBox();
            ucClearFilters1 = new UserControls.UCClearFilters();
            ucCantidadregistros1 = new UserControls.UCCantidadregistros();
            toolTip1 = new ToolTip(components);
            btnConsultar = new ReaLTaiizor.Controls.CyberButton();
            btnCuota = new ReaLTaiizor.Controls.CyberButton();
            btnAnular = new ReaLTaiizor.Controls.CyberButton();
            idSocioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calleNumeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            idBarrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TieneImagen = new DataGridViewCheckBoxColumn();
            colAnulado = new DataGridViewCheckBoxColumn();
            colDeudor = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            btnModificar.Location = new Point(104, 429);
            btnModificar.Name = "btnModificar";
            btnModificar.PenWidth = 15;
            btnModificar.Rounding = true;
            btnModificar.RoundingInt = 70;
            btnModificar.Size = new Size(99, 40);
            btnModificar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnModificar.TabIndex = 23;
            btnModificar.Tag = "Cyber";
            btnModificar.TextButton = "Modificar";
            btnModificar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnModificar.Timer_Effect_1 = 5;
            btnModificar.Timer_RGB = 300;
            btnModificar.Click += btnModificar_Click;
            // 
            // BtnMembresía
            // 
            BtnMembresía.Alpha = 20;
            BtnMembresía.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnMembresía.BackColor = Color.Transparent;
            BtnMembresía.Background = true;
            BtnMembresía.Background_WidthPen = 4F;
            BtnMembresía.BackgroundPen = true;
            BtnMembresía.ColorBackground = Color.Black;
            BtnMembresía.ColorBackground_1 = Color.Black;
            BtnMembresía.ColorBackground_2 = Color.Gray;
            BtnMembresía.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            BtnMembresía.ColorLighting = Color.FromArgb(81, 45, 168);
            BtnMembresía.ColorPen_1 = Color.Black;
            BtnMembresía.ColorPen_2 = Color.Gray;
            BtnMembresía.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnMembresía.Effect_1 = true;
            BtnMembresía.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            BtnMembresía.Effect_1_Transparency = 25;
            BtnMembresía.Effect_2 = true;
            BtnMembresía.Effect_2_ColorBackground = Color.White;
            BtnMembresía.Effect_2_Transparency = 20;
            BtnMembresía.Font = new Font("Arial", 10F);
            BtnMembresía.ForeColor = Color.FromArgb(245, 245, 245);
            BtnMembresía.Lighting = false;
            BtnMembresía.LinearGradient_Background = false;
            BtnMembresía.LinearGradientPen = false;
            BtnMembresía.Location = new Point(549, 428);
            BtnMembresía.Name = "BtnMembresía";
            BtnMembresía.PenWidth = 15;
            BtnMembresía.Rounding = true;
            BtnMembresía.RoundingInt = 70;
            BtnMembresía.Size = new Size(99, 40);
            BtnMembresía.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnMembresía.TabIndex = 22;
            BtnMembresía.Tag = "Cyber";
            BtnMembresía.TextButton = "Agregar Membresía";
            BtnMembresía.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnMembresía.Timer_Effect_1 = 5;
            BtnMembresía.Timer_RGB = 300;
            BtnMembresía.Click += BtnMembresía_Click;
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
            btnAgregar.Location = new Point(7, 429);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.PenWidth = 15;
            btnAgregar.Rounding = true;
            btnAgregar.RoundingInt = 70;
            btnAgregar.Size = new Size(99, 40);
            btnAgregar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAgregar.TabIndex = 21;
            btnAgregar.Tag = "Cyber";
            btnAgregar.TextButton = "Agregar";
            btnAgregar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAgregar.Timer_Effect_1 = 5;
            btnAgregar.Timer_RGB = 300;
            btnAgregar.Click += cyberButton1_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idSocioDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, tipoDocumentoDataGridViewTextBoxColumn, numeroDocumentoDataGridViewTextBoxColumn, telefono1DataGridViewTextBoxColumn, telefono2DataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, calleDataGridViewTextBoxColumn, calleNumeroDataGridViewTextBoxColumn, barrioDataGridViewTextBoxColumn, fechaAlta, idBarrioDataGridViewTextBoxColumn, TieneImagen, colAnulado, colDeudor });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(981, 215);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Socio);
            bindingSource1.PositionChanged += bindingSource1_PositionChanged;
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
            btnCancelar.Location = new Point(894, 429);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 19;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            toolTip1.SetToolTip(btnCancelar, "Cancelar");
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
            btnAceptar.Location = new Point(798, 429);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.PenWidth = 15;
            btnAceptar.Rounding = true;
            btnAceptar.RoundingInt = 70;
            btnAceptar.Size = new Size(99, 40);
            btnAceptar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAceptar.TabIndex = 18;
            btnAceptar.Tag = "Cyber";
            btnAceptar.TextButton = "Aceptar";
            btnAceptar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAceptar.Timer_Effect_1 = 5;
            btnAceptar.Timer_RGB = 300;
            btnAceptar.Click += btnAceptar_Click;
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
            btnFiltrar.TabIndex = 17;
            btnFiltrar.Tag = "Cyber";
            btnFiltrar.TextButton = "Filtrar";
            btnFiltrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFiltrar.Timer_Effect_1 = 5;
            btnFiltrar.Timer_RGB = 300;
            btnFiltrar.Click += btnFiltrar_Click;
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
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            txtDocumento.KeyPress += txtCualquierFiltro_KeyPress;
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
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.KeyPress += txtCualquierFiltro_KeyPress;
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
            txtNombre.TextChanged += txtNombre_TextChanged;
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
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(959, 6);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 1;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Administrar socios";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(3, 2);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(165, 34);
            ucTituloLabel1.TabIndex = 24;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 0);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 480);
            ucBorderlr1.TabIndex = 25;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(1006, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 480);
            ucBorderlr2.TabIndex = 26;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(1004, 3);
            ucBordertd1.TabIndex = 27;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 477);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(1004, 3);
            ucBordertd2.TabIndex = 28;
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
            btnImprimir.TabIndex = 29;
            btnImprimir.Tag = "Cyber";
            btnImprimir.TextButton = "Imprimir";
            btnImprimir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnImprimir.Timer_Effect_1 = 5;
            btnImprimir.Timer_RGB = 300;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(424, 22);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(77, 16);
            thunderLabel4.TabIndex = 30;
            thunderLabel4.Text = "Fecha Alta";
            // 
            // txtFechaDesde
            // 
            txtFechaDesde.Checked = false;
            txtFechaDesde.CustomFormat = "dd/MM/yyyy";
            txtFechaDesde.Format = DateTimePickerFormat.Custom;
            txtFechaDesde.Location = new Point(424, 50);
            txtFechaDesde.Name = "txtFechaDesde";
            txtFechaDesde.ShowCheckBox = true;
            txtFechaDesde.Size = new Size(116, 23);
            txtFechaDesde.TabIndex = 58;
            // 
            // txtFechaHasta
            // 
            txtFechaHasta.Checked = false;
            txtFechaHasta.CustomFormat = "dd/MM/yyyy";
            txtFechaHasta.Format = DateTimePickerFormat.Custom;
            txtFechaHasta.Location = new Point(424, 82);
            txtFechaHasta.Name = "txtFechaHasta";
            txtFechaHasta.ShowCheckBox = true;
            txtFechaHasta.Size = new Size(116, 23);
            txtFechaHasta.TabIndex = 60;
            // 
            // thunderLabel5
            // 
            thunderLabel5.BackColor = Color.Transparent;
            thunderLabel5.ForeColor = Color.WhiteSmoke;
            thunderLabel5.Location = new Point(367, 57);
            thunderLabel5.Name = "thunderLabel5";
            thunderLabel5.Size = new Size(51, 16);
            thunderLabel5.TabIndex = 59;
            thunderLabel5.Text = "Desde";
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(367, 85);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(51, 16);
            thunderLabel6.TabIndex = 61;
            thunderLabel6.Text = "Hasta";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(chkAnulados);
            groupBox1.Controls.Add(ucClearFilters1);
            groupBox1.Controls.Add(thunderLabel6);
            groupBox1.Controls.Add(txtFechaHasta);
            groupBox1.Controls.Add(thunderLabel5);
            groupBox1.Controls.Add(txtFechaDesde);
            groupBox1.Controls.Add(thunderLabel4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(thunderLabel1);
            groupBox1.Controls.Add(thunderLabel2);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(thunderLabel3);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 118);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            // 
            // chkAnulados
            // 
            chkAnulados.BackColor = Color.Transparent;
            chkAnulados.Checked = false;
            chkAnulados.EnabledCalc = true;
            chkAnulados.ForeColor = Color.White;
            chkAnulados.Location = new Point(555, 50);
            chkAnulados.Name = "chkAnulados";
            chkAnulados.Size = new Size(118, 17);
            chkAnulados.TabIndex = 67;
            chkAnulados.Text = "Ver anulados";
            // 
            // ucClearFilters1
            // 
            ucClearFilters1.Location = new Point(555, 82);
            ucClearFilters1.Name = "ucClearFilters1";
            ucClearFilters1.Size = new Size(25, 25);
            ucClearFilters1.TabIndex = 65;
            toolTip1.SetToolTip(ucClearFilters1, "Limpiar filtros");
            ucClearFilters1._ClickUCAgregar += ucClearFilters1__ClickUCAgregar;
            // 
            // ucCantidadregistros1
            // 
            ucCantidadregistros1._cantidad = 0;
            ucCantidadregistros1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ucCantidadregistros1.BackColor = Color.Transparent;
            ucCantidadregistros1.Location = new Point(894, 186);
            ucCantidadregistros1.Name = "ucCantidadregistros1";
            ucCantidadregistros1.Size = new Size(103, 16);
            ucCantidadregistros1.TabIndex = 63;
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
            btnConsultar.Location = new Point(202, 429);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.PenWidth = 15;
            btnConsultar.Rounding = true;
            btnConsultar.RoundingInt = 70;
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConsultar.TabIndex = 65;
            btnConsultar.Tag = "Cyber";
            btnConsultar.TextButton = "Consultar";
            btnConsultar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConsultar.Timer_Effect_1 = 5;
            btnConsultar.Timer_RGB = 300;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCuota
            // 
            btnCuota.Alpha = 20;
            btnCuota.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCuota.BackColor = Color.Transparent;
            btnCuota.Background = true;
            btnCuota.Background_WidthPen = 4F;
            btnCuota.BackgroundPen = true;
            btnCuota.ColorBackground = Color.Black;
            btnCuota.ColorBackground_1 = Color.Black;
            btnCuota.ColorBackground_2 = Color.Gray;
            btnCuota.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnCuota.ColorLighting = Color.FromArgb(81, 45, 168);
            btnCuota.ColorPen_1 = Color.Black;
            btnCuota.ColorPen_2 = Color.Gray;
            btnCuota.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCuota.Effect_1 = true;
            btnCuota.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnCuota.Effect_1_Transparency = 25;
            btnCuota.Effect_2 = true;
            btnCuota.Effect_2_ColorBackground = Color.White;
            btnCuota.Effect_2_Transparency = 20;
            btnCuota.Font = new Font("Arial", 11F);
            btnCuota.ForeColor = Color.FromArgb(245, 245, 245);
            btnCuota.Lighting = false;
            btnCuota.LinearGradient_Background = false;
            btnCuota.LinearGradientPen = false;
            btnCuota.Location = new Point(453, 428);
            btnCuota.Name = "btnCuota";
            btnCuota.PenWidth = 15;
            btnCuota.Rounding = true;
            btnCuota.RoundingInt = 70;
            btnCuota.Size = new Size(99, 40);
            btnCuota.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCuota.TabIndex = 66;
            btnCuota.Tag = "Cyber";
            btnCuota.TextButton = "Cuotas";
            btnCuota.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCuota.Timer_Effect_1 = 5;
            btnCuota.Timer_RGB = 300;
            btnCuota.Click += Cuota_Click;
            // 
            // btnAnular
            // 
            btnAnular.Alpha = 20;
            btnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnular.BackColor = Color.Transparent;
            btnAnular.Background = true;
            btnAnular.Background_WidthPen = 4F;
            btnAnular.BackgroundPen = true;
            btnAnular.ColorBackground = Color.Black;
            btnAnular.ColorBackground_1 = Color.Black;
            btnAnular.ColorBackground_2 = Color.Gray;
            btnAnular.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnAnular.ColorLighting = Color.FromArgb(81, 45, 168);
            btnAnular.ColorPen_1 = Color.Black;
            btnAnular.ColorPen_2 = Color.Gray;
            btnAnular.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAnular.Effect_1 = true;
            btnAnular.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnAnular.Effect_1_Transparency = 25;
            btnAnular.Effect_2 = true;
            btnAnular.Effect_2_ColorBackground = Color.White;
            btnAnular.Effect_2_Transparency = 20;
            btnAnular.Font = new Font("Arial", 11F);
            btnAnular.ForeColor = Color.FromArgb(245, 245, 245);
            btnAnular.Lighting = false;
            btnAnular.LinearGradient_Background = false;
            btnAnular.LinearGradientPen = false;
            btnAnular.Location = new Point(300, 429);
            btnAnular.Name = "btnAnular";
            btnAnular.PenWidth = 15;
            btnAnular.Rounding = true;
            btnAnular.RoundingInt = 70;
            btnAnular.Size = new Size(99, 40);
            btnAnular.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAnular.TabIndex = 67;
            btnAnular.Tag = "Cyber";
            btnAnular.TextButton = "Anular";
            btnAnular.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAnular.Timer_Effect_1 = 5;
            btnAnular.Timer_RGB = 300;
            btnAnular.Click += btnAnular_Click;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            idSocioDataGridViewTextBoxColumn.HeaderText = "Nro";
            idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            idSocioDataGridViewTextBoxColumn.ReadOnly = true;
            idSocioDataGridViewTextBoxColumn.Visible = false;
            idSocioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
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
            numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro. Documento";
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
            mailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            calleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calleNumeroDataGridViewTextBoxColumn
            // 
            calleNumeroDataGridViewTextBoxColumn.DataPropertyName = "calleNumero";
            calleNumeroDataGridViewTextBoxColumn.HeaderText = "Calle Nro.";
            calleNumeroDataGridViewTextBoxColumn.Name = "calleNumeroDataGridViewTextBoxColumn";
            calleNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            barrioDataGridViewTextBoxColumn.DataPropertyName = "BarrioNombre";
            barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            barrioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAlta
            // 
            fechaAlta.DataPropertyName = "fechaAlta";
            fechaAlta.HeaderText = "Fecha Alta";
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            // 
            // idBarrioDataGridViewTextBoxColumn
            // 
            idBarrioDataGridViewTextBoxColumn.DataPropertyName = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.HeaderText = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.Name = "idBarrioDataGridViewTextBoxColumn";
            idBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            idBarrioDataGridViewTextBoxColumn.Visible = false;
            // 
            // TieneImagen
            // 
            TieneImagen.DataPropertyName = "TieneImagen";
            TieneImagen.HeaderText = "Imagen [S/N]";
            TieneImagen.Name = "TieneImagen";
            TieneImagen.ReadOnly = true;
            TieneImagen.Visible = false;
            // 
            // colAnulado
            // 
            colAnulado.DataPropertyName = "anulado";
            colAnulado.HeaderText = "Anulado";
            colAnulado.Name = "colAnulado";
            colAnulado.ReadOnly = true;
            // 
            // colDeudor
            // 
            colDeudor.DataPropertyName = "deudor";
            colDeudor.HeaderText = "Deudor";
            colDeudor.Name = "colDeudor";
            colDeudor.ReadOnly = true;
            // 
            // FrmSociosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(1008, 480);
            Controls.Add(btnAnular);
            Controls.Add(btnCuota);
            Controls.Add(btnConsultar);
            Controls.Add(ucCantidadregistros1);
            Controls.Add(groupBox1);
            Controls.Add(btnImprimir);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(btnModificar);
            Controls.Add(BtnMembresía);
            Controls.Add(btnAgregar);
            Controls.Add(botonesForms2);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSociosConsulta";
            Load += FrmSociosAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.AloneTextBox txtDocumento;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAceptar;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.CyberButton btnModificar;
        private ReaLTaiizor.Controls.CyberButton BtnMembresía;
        private ReaLTaiizor.Controls.CyberButton btnAgregar;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderTD ucBordertd2;
        private ReaLTaiizor.Controls.CyberButton btnImprimir;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private DateTimePicker txtFechaDesde;
        private DateTimePicker txtFechaHasta;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel5;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private GroupBox groupBox1;
        private UserControls.UCCantidadregistros ucCantidadregistros1;
        private UserControls.UCClearFilters ucClearFilters1;
        private ToolTip toolTip1;
        private ReaLTaiizor.Controls.CyberButton btnConsultar;
        private ReaLTaiizor.Controls.CyberButton Cuota;
        private ReaLTaiizor.Controls.CyberButton btnCuota;
        private ReaLTaiizor.Controls.CyberButton btnAnular;
        private ReaLTaiizor.Controls.AloneCheckBox chkAnulados;
        private DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleNumeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAlta;
        private DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn TieneImagen;
        private DataGridViewCheckBoxColumn colAnulado;
        private DataGridViewCheckBoxColumn colDeudor;
    }
}