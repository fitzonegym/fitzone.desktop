namespace Fitzone.Front.Socios
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
            BtnAnular = new ReaLTaiizor.Controls.CyberButton();
            btnAgregar = new ReaLTaiizor.Controls.CyberButton();
            dataGridView1 = new DataGridView();
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
            idBarrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TieneImagen = new DataGridViewCheckBoxColumn();
            anuladoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            btnModificar.Location = new Point(107, 443);
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
            // BtnAnular
            // 
            BtnAnular.Alpha = 20;
            BtnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            BtnAnular.Location = new Point(205, 443);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.PenWidth = 15;
            BtnAnular.Rounding = true;
            BtnAnular.RoundingInt = 70;
            BtnAnular.Size = new Size(99, 40);
            BtnAnular.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnAnular.TabIndex = 22;
            BtnAnular.Tag = "Cyber";
            BtnAnular.TextButton = "Anular";
            BtnAnular.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnAnular.Timer_Effect_1 = 5;
            BtnAnular.Timer_RGB = 300;
            BtnAnular.Click += BtnAnular_Click;
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
            btnAgregar.Location = new Point(8, 443);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idSocioDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, tipoDocumentoDataGridViewTextBoxColumn, numeroDocumentoDataGridViewTextBoxColumn, telefono1DataGridViewTextBoxColumn, telefono2DataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, calleDataGridViewTextBoxColumn, calleNumeroDataGridViewTextBoxColumn, barrioDataGridViewTextBoxColumn, idBarrioDataGridViewTextBoxColumn, TieneImagen, anuladoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(765, 275);
            dataGridView1.TabIndex = 20;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            idSocioDataGridViewTextBoxColumn.HeaderText = "Id";
            idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            idSocioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            anuladoDataGridViewCheckBoxColumn.DataPropertyName = "anulado";
            anuladoDataGridViewCheckBoxColumn.HeaderText = "anulado";
            anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            anuladoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Socio);
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
            btnCancelar.Location = new Point(681, 443);
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
            btnAceptar.Location = new Point(576, 443);
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
            btnFiltrar.Location = new Point(12, 116);
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
            txtDocumento.Location = new Point(421, 50);
            txtDocumento.MaxLength = 32767;
            txtDocumento.MultiLine = false;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = false;
            txtDocumento.Size = new Size(233, 29);
            txtDocumento.TabIndex = 15;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.UseSystemPasswordChar = false;
            txtDocumento.KeyPress += txtCualquierFiltro_KeyPress;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(313, 59);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(107, 16);
            thunderLabel3.TabIndex = 14;
            thunderLabel3.Text = "Nro. Documento";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Transparent;
            txtApellido.EnabledCalc = true;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(79, 81);
            txtApellido.MaxLength = 32767;
            txtApellido.MultiLine = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = false;
            txtApellido.Size = new Size(233, 29);
            txtApellido.TabIndex = 13;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.UseSystemPasswordChar = false;
            txtApellido.KeyPress += txtCualquierFiltro_KeyPress;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(16, 90);
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
            txtNombre.Location = new Point(79, 50);
            txtNombre.MaxLength = 32767;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 6;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(16, 59);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(57, 16);
            thunderLabel1.TabIndex = 2;
            thunderLabel1.Text = "Nombre";
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(743, 6);
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
            ucBorderlr1.Size = new Size(2, 490);
            ucBorderlr1.TabIndex = 25;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(790, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 490);
            ucBorderlr2.TabIndex = 26;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(788, 3);
            ucBordertd1.TabIndex = 27;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 487);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(788, 3);
            ucBordertd2.TabIndex = 28;
            // 
            // FrmSociosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(792, 490);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(btnModificar);
            Controls.Add(BtnAnular);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(botonesForms2);
            Controls.Add(dataGridView1);
            Controls.Add(thunderLabel1);
            Controls.Add(btnCancelar);
            Controls.Add(thunderLabel2);
            Controls.Add(btnAceptar);
            Controls.Add(txtApellido);
            Controls.Add(btnFiltrar);
            Controls.Add(thunderLabel3);
            Controls.Add(txtDocumento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAdmin";
            Text = "FrmSociosConsulta";
            Load += FrmSociosAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private ReaLTaiizor.Controls.CyberButton BtnAnular;
        private ReaLTaiizor.Controls.CyberButton btnAgregar;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderTD ucBordertd2;
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
        private DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn TieneImagen;
        private DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
    }
}