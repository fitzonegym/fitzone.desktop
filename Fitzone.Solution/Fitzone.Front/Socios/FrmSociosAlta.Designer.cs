namespace Fitzone.Front.Socios
{
    partial class FrmSociosAlta
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
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            pictureBoxImagen = new PictureBox();
            lblCargandoCamara = new Label();
            groupBox1 = new GroupBox();
            rdbCam2 = new RadioButton();
            rdbCam1 = new RadioButton();
            btnCapturar = new ReaLTaiizor.Controls.CyberButton();
            pictureBoxVideo = new PictureBox();
            rdbOtro = new ReaLTaiizor.Controls.AloneRadioButton();
            rdbDNI = new ReaLTaiizor.Controls.AloneRadioButton();
            txtNroDoc = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            ucErrorIconoCel = new UserControls.UCErrorIcono();
            ucAgregar1 = new UserControls.UCAgregar();
            ucErrorIconoNroDoc = new UserControls.UCErrorIcono();
            ucErrorIconoApellido = new UserControls.UCErrorIcono();
            ucErrorIconoNombre = new UserControls.UCErrorIcono();
            botonesForms3 = new UserControls.UCBotonesForms();
            cmbBarrio = new ReaLTaiizor.Controls.AloneComboBox();
            bindingSource1 = new BindingSource(components);
            thunderLabel10 = new ReaLTaiizor.Controls.ThunderLabel();
            txtCalleNro = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel9 = new ReaLTaiizor.Controls.ThunderLabel();
            txtCalle = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel8 = new ReaLTaiizor.Controls.ThunderLabel();
            txtMail = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            txtTelefono = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            txtCelular2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            txtNroDoc2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            ucBorder1 = new UserControls.UCBorderLR();
            ucBorder2 = new UserControls.UCBorderLR();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBordertd2 = new UserControls.UCBorderTD();
            groupBox3 = new GroupBox();
            txtFechaNac = new DateTimePicker();
            thunderLabel11 = new ReaLTaiizor.Controls.ThunderLabel();
            ucErrorIconoMail = new UserControls.UCErrorIcono();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBoxImagen);
            groupBox2.Controls.Add(lblCargandoCamara);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btnCapturar);
            groupBox2.Controls.Add(pictureBoxVideo);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(431, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(201, 395);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Imagen";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(147, 304);
            label2.Name = "label2";
            label2.Size = new Size(39, 12);
            label2.TabIndex = 52;
            label2.Text = "Imagen";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(150, 131);
            label1.Name = "label1";
            label1.Size = new Size(38, 12);
            label1.TabIndex = 51;
            label1.Text = "Cámara";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxImagen.BackColor = Color.Snow;
            pictureBoxImagen.Image = Properties.Resources.no_foto_img;
            pictureBoxImagen.Location = new Point(6, 19);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(189, 330);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 50;
            pictureBoxImagen.TabStop = false;
            // 
            // lblCargandoCamara
            // 
            lblCargandoCamara.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCargandoCamara.Font = new Font("Segoe UI", 7F);
            lblCargandoCamara.Location = new Point(24, 68);
            lblCargandoCamara.Name = "lblCargandoCamara";
            lblCargandoCamara.Size = new Size(152, 27);
            lblCargandoCamara.TabIndex = 49;
            lblCargandoCamara.Text = "Cargando cámara en segundo plano...";
            lblCargandoCamara.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rdbCam2);
            groupBox1.Controls.Add(rdbCam1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(76, 31);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cam. nro.";
            // 
            // rdbCam2
            // 
            rdbCam2.AutoSize = true;
            rdbCam2.Location = new Point(43, 10);
            rdbCam2.Name = "rdbCam2";
            rdbCam2.Size = new Size(31, 19);
            rdbCam2.TabIndex = 1;
            rdbCam2.Text = "2";
            rdbCam2.UseVisualStyleBackColor = true;
            rdbCam2.CheckedChanged += rdbCam2_CheckedChanged;
            // 
            // rdbCam1
            // 
            rdbCam1.AutoSize = true;
            rdbCam1.Checked = true;
            rdbCam1.Location = new Point(6, 10);
            rdbCam1.Name = "rdbCam1";
            rdbCam1.Size = new Size(31, 19);
            rdbCam1.TabIndex = 0;
            rdbCam1.TabStop = true;
            rdbCam1.Text = "1";
            rdbCam1.UseVisualStyleBackColor = true;
            rdbCam1.CheckedChanged += rdbCam1_CheckedChanged;
            // 
            // btnCapturar
            // 
            btnCapturar.Alpha = 20;
            btnCapturar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCapturar.BackColor = Color.Transparent;
            btnCapturar.Background = true;
            btnCapturar.Background_WidthPen = 4F;
            btnCapturar.BackgroundPen = true;
            btnCapturar.ColorBackground = Color.Black;
            btnCapturar.ColorBackground_1 = Color.Black;
            btnCapturar.ColorBackground_2 = Color.Gray;
            btnCapturar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnCapturar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnCapturar.ColorPen_1 = Color.Black;
            btnCapturar.ColorPen_2 = Color.Gray;
            btnCapturar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCapturar.Effect_1 = true;
            btnCapturar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnCapturar.Effect_1_Transparency = 25;
            btnCapturar.Effect_2 = true;
            btnCapturar.Effect_2_ColorBackground = Color.White;
            btnCapturar.Effect_2_Transparency = 20;
            btnCapturar.Enabled = false;
            btnCapturar.Font = new Font("Arial", 11F);
            btnCapturar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCapturar.Lighting = false;
            btnCapturar.LinearGradient_Background = false;
            btnCapturar.LinearGradientPen = false;
            btnCapturar.Location = new Point(88, 355);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.PenWidth = 15;
            btnCapturar.Rounding = true;
            btnCapturar.RoundingInt = 70;
            btnCapturar.Size = new Size(107, 31);
            btnCapturar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCapturar.TabIndex = 46;
            btnCapturar.Tag = "Cyber";
            btnCapturar.TextButton = "Capturar";
            btnCapturar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCapturar.Timer_Effect_1 = 5;
            btnCapturar.Timer_RGB = 300;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // pictureBoxVideo
            // 
            pictureBoxVideo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxVideo.BackColor = Color.Snow;
            pictureBoxVideo.Location = new Point(6, 19);
            pictureBoxVideo.Name = "pictureBoxVideo";
            pictureBoxVideo.Size = new Size(189, 130);
            pictureBoxVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVideo.TabIndex = 44;
            pictureBoxVideo.TabStop = false;
            // 
            // rdbOtro
            // 
            rdbOtro.BackColor = Color.Transparent;
            rdbOtro.Checked = false;
            rdbOtro.EnabledCalc = true;
            rdbOtro.ForeColor = Color.White;
            rdbOtro.Location = new Point(195, 118);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(60, 17);
            rdbOtro.TabIndex = 12;
            rdbOtro.Text = "Otro";
            // 
            // rdbDNI
            // 
            rdbDNI.BackColor = Color.Transparent;
            rdbDNI.Checked = true;
            rdbDNI.EnabledCalc = true;
            rdbDNI.ForeColor = Color.White;
            rdbDNI.Location = new Point(145, 119);
            rdbDNI.Name = "rdbDNI";
            rdbDNI.Size = new Size(57, 17);
            rdbDNI.TabIndex = 11;
            rdbDNI.Text = "DNI";
            // 
            // txtNroDoc
            // 
            txtNroDoc.BorderStyle = BorderStyle.None;
            txtNroDoc.Font = new Font("Segoe UI", 9F);
            txtNroDoc.Location = new Point(155, 148);
            txtNroDoc.Mask = "00,000,000";
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(89, 16);
            txtNroDoc.TabIndex = 2;
            txtNroDoc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtNroDoc.Click += txtNroDoc_Click_1;
            txtNroDoc.Validating += _Validating;
            // 
            // txtCelular
            // 
            txtCelular.BorderStyle = BorderStyle.None;
            txtCelular.Font = new Font("Segoe UI", 9F);
            txtCelular.Location = new Point(154, 285);
            txtCelular.Mask = "(999)000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(89, 16);
            txtCelular.TabIndex = 3;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCelular.Click += txtCelular_Click;
            txtCelular.Validating += _Validating;
            // 
            // ucErrorIconoCel
            // 
            ucErrorIconoCel.BackColor = Color.Transparent;
            ucErrorIconoCel.Location = new Point(9, 284);
            ucErrorIconoCel.Name = "ucErrorIconoCel";
            ucErrorIconoCel.Size = new Size(20, 20);
            ucErrorIconoCel.TabIndex = 42;
            // 
            // ucAgregar1
            // 
            ucAgregar1.BackColor = Color.Transparent;
            ucAgregar1.Location = new Point(351, 216);
            ucAgregar1.Name = "ucAgregar1";
            ucAgregar1.Size = new Size(20, 20);
            ucAgregar1.TabIndex = 43;
            ucAgregar1._ClickUCAgregar += ucAgregar1__ClickUCAgregar;
            // 
            // ucErrorIconoNroDoc
            // 
            ucErrorIconoNroDoc.BackColor = Color.Transparent;
            ucErrorIconoNroDoc.Location = new Point(8, 145);
            ucErrorIconoNroDoc.Name = "ucErrorIconoNroDoc";
            ucErrorIconoNroDoc.Size = new Size(20, 20);
            ucErrorIconoNroDoc.TabIndex = 41;
            // 
            // ucErrorIconoApellido
            // 
            ucErrorIconoApellido.BackColor = Color.Transparent;
            ucErrorIconoApellido.Location = new Point(7, 53);
            ucErrorIconoApellido.Name = "ucErrorIconoApellido";
            ucErrorIconoApellido.Size = new Size(20, 20);
            ucErrorIconoApellido.TabIndex = 39;
            // 
            // ucErrorIconoNombre
            // 
            ucErrorIconoNombre.BackColor = Color.Transparent;
            ucErrorIconoNombre.Location = new Point(7, 21);
            ucErrorIconoNombre.Name = "ucErrorIconoNombre";
            ucErrorIconoNombre.Size = new Size(20, 20);
            ucErrorIconoNombre.TabIndex = 38;
            // 
            // botonesForms3
            // 
            botonesForms3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms3.BackColor = Color.Transparent;
            botonesForms3.Location = new Point(592, 6);
            botonesForms3.Name = "botonesForms3";
            botonesForms3.Size = new Size(44, 20);
            botonesForms3.TabIndex = 37;
            botonesForms3.TabStop = false;
            // 
            // cmbBarrio
            // 
            cmbBarrio.DataSource = bindingSource1;
            cmbBarrio.DisplayMember = "nombre";
            cmbBarrio.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarrio.EnabledCalc = true;
            cmbBarrio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbBarrio.ForeColor = Color.Black;
            cmbBarrio.FormattingEnabled = true;
            cmbBarrio.ItemHeight = 20;
            cmbBarrio.Location = new Point(150, 246);
            cmbBarrio.Name = "cmbBarrio";
            cmbBarrio.Size = new Size(196, 26);
            cmbBarrio.TabIndex = 6;
            cmbBarrio.ValueMember = "idBarrio";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Barrio);
            // 
            // thunderLabel10
            // 
            thunderLabel10.BackColor = Color.Transparent;
            thunderLabel10.Enabled = false;
            thunderLabel10.ForeColor = Color.WhiteSmoke;
            thunderLabel10.Location = new Point(34, 250);
            thunderLabel10.Name = "thunderLabel10";
            thunderLabel10.Size = new Size(77, 21);
            thunderLabel10.TabIndex = 35;
            thunderLabel10.Text = "Barrio";
            // 
            // txtCalleNro
            // 
            txtCalleNro.BackColor = Color.Transparent;
            txtCalleNro.EnabledCalc = true;
            txtCalleNro.Font = new Font("Segoe UI", 9F);
            txtCalleNro.ForeColor = Color.Black;
            txtCalleNro.Location = new Point(142, 211);
            txtCalleNro.MaxLength = 5;
            txtCalleNro.MultiLine = false;
            txtCalleNro.Name = "txtCalleNro";
            txtCalleNro.ReadOnly = false;
            txtCalleNro.Size = new Size(123, 29);
            txtCalleNro.TabIndex = 8;
            txtCalleNro.TextAlign = HorizontalAlignment.Left;
            txtCalleNro.UseSystemPasswordChar = false;
            txtCalleNro.TextChanged += txtCalleNro_TextChanged;
            // 
            // thunderLabel9
            // 
            thunderLabel9.BackColor = Color.Transparent;
            thunderLabel9.Enabled = false;
            thunderLabel9.ForeColor = Color.WhiteSmoke;
            thunderLabel9.Location = new Point(34, 216);
            thunderLabel9.Name = "thunderLabel9";
            thunderLabel9.Size = new Size(75, 24);
            thunderLabel9.TabIndex = 33;
            thunderLabel9.Text = "Calle nro.";
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.Transparent;
            txtCalle.EnabledCalc = true;
            txtCalle.Font = new Font("Segoe UI", 9F);
            txtCalle.ForeColor = Color.Black;
            txtCalle.Location = new Point(142, 177);
            txtCalle.MaxLength = 30;
            txtCalle.MultiLine = false;
            txtCalle.Name = "txtCalle";
            txtCalle.ReadOnly = false;
            txtCalle.Size = new Size(233, 29);
            txtCalle.TabIndex = 7;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // thunderLabel8
            // 
            thunderLabel8.BackColor = Color.Transparent;
            thunderLabel8.Enabled = false;
            thunderLabel8.ForeColor = Color.WhiteSmoke;
            thunderLabel8.Location = new Point(34, 186);
            thunderLabel8.Name = "thunderLabel8";
            thunderLabel8.Size = new Size(77, 14);
            thunderLabel8.TabIndex = 31;
            thunderLabel8.Text = "Calle";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.Transparent;
            txtMail.EnabledCalc = true;
            txtMail.Font = new Font("Segoe UI", 9F);
            txtMail.ForeColor = Color.Black;
            txtMail.Location = new Point(145, 349);
            txtMail.MaxLength = 30;
            txtMail.MultiLine = false;
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = false;
            txtMail.Size = new Size(233, 29);
            txtMail.TabIndex = 5;
            txtMail.TextAlign = HorizontalAlignment.Left;
            txtMail.UseSystemPasswordChar = false;
            txtMail.Validating += _Validating;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.Enabled = false;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(34, 357);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(50, 18);
            thunderLabel7.TabIndex = 29;
            thunderLabel7.Text = "E-mail";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.EnabledCalc = true;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(145, 314);
            txtTelefono.MaxLength = 10;
            txtTelefono.MultiLine = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = false;
            txtTelefono.Size = new Size(234, 29);
            txtTelefono.TabIndex = 4;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.Enabled = false;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(34, 287);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(62, 21);
            thunderLabel6.TabIndex = 15;
            thunderLabel6.Text = "Celular";
            // 
            // txtCelular2
            // 
            txtCelular2.BackColor = Color.Transparent;
            txtCelular2.EnabledCalc = false;
            txtCelular2.Font = new Font("Segoe UI", 9F);
            txtCelular2.ForeColor = Color.Black;
            txtCelular2.Location = new Point(145, 279);
            txtCelular2.MaxLength = 50;
            txtCelular2.MultiLine = false;
            txtCelular2.Name = "txtCelular2";
            txtCelular2.ReadOnly = false;
            txtCelular2.Size = new Size(110, 29);
            txtCelular2.TabIndex = 40;
            txtCelular2.TextAlign = HorizontalAlignment.Left;
            txtCelular2.UseSystemPasswordChar = false;
            txtCelular2.Validating += _Validating;
            // 
            // thunderLabel5
            // 
            thunderLabel5.BackColor = Color.Transparent;
            thunderLabel5.Enabled = false;
            thunderLabel5.ForeColor = Color.WhiteSmoke;
            thunderLabel5.Location = new Point(34, 322);
            thunderLabel5.Name = "thunderLabel5";
            thunderLabel5.Size = new Size(72, 16);
            thunderLabel5.TabIndex = 25;
            thunderLabel5.Text = "Teléfono";
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.Enabled = false;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(34, 119);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(109, 16);
            thunderLabel4.TabIndex = 13;
            thunderLabel4.Text = "Tipo documento";
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.Black;
            cyberButton1.ColorBackground_1 = Color.Black;
            cyberButton1.ColorBackground_2 = Color.Gray;
            cyberButton1.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cyberButton1.ColorLighting = Color.FromArgb(81, 45, 168);
            cyberButton1.ColorPen_1 = Color.Black;
            cyberButton1.ColorPen_2 = Color.Gray;
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(532, 436);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(99, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 10;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Cancelar";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.Black;
            cyberButton2.ColorBackground_1 = Color.Black;
            cyberButton2.ColorBackground_2 = Color.Gray;
            cyberButton2.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cyberButton2.ColorLighting = Color.FromArgb(81, 45, 168);
            cyberButton2.ColorPen_1 = Color.Black;
            cyberButton2.ColorPen_2 = Color.Gray;
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(434, 436);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(99, 40);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 9;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Guardar";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // txtNroDoc2
            // 
            txtNroDoc2.BackColor = Color.Transparent;
            txtNroDoc2.EnabledCalc = true;
            txtNroDoc2.Font = new Font("Segoe UI", 9F);
            txtNroDoc2.ForeColor = Color.Black;
            txtNroDoc2.Location = new Point(145, 142);
            txtNroDoc2.MaxLength = 10;
            txtNroDoc2.MultiLine = false;
            txtNroDoc2.Name = "txtNroDoc2";
            txtNroDoc2.ReadOnly = false;
            txtNroDoc2.Size = new Size(110, 29);
            txtNroDoc2.TabIndex = 30;
            txtNroDoc2.TextAlign = HorizontalAlignment.Left;
            txtNroDoc2.UseSystemPasswordChar = false;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.Enabled = false;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(34, 150);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(109, 16);
            thunderLabel3.TabIndex = 14;
            thunderLabel3.Text = "Nro. Documento";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Transparent;
            txtApellido.EnabledCalc = true;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(144, 48);
            txtApellido.MaxLength = 50;
            txtApellido.MultiLine = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = false;
            txtApellido.Size = new Size(233, 29);
            txtApellido.TabIndex = 1;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.UseSystemPasswordChar = false;
            txtApellido.Validating += _Validating;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.Enabled = false;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(33, 56);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(96, 16);
            thunderLabel2.TabIndex = 12;
            thunderLabel2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.EnabledCalc = true;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(144, 13);
            txtNombre.MaxLength = 50;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.Validating += _Validating;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.Enabled = false;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(33, 23);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(96, 16);
            thunderLabel1.TabIndex = 11;
            thunderLabel1.Text = "Nombre";
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Agregar socio";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(4, 4);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(143, 34);
            ucTituloLabel1.TabIndex = 49;
            // 
            // ucBorder1
            // 
            ucBorder1.BackColor = Color.White;
            ucBorder1.Dock = DockStyle.Left;
            ucBorder1.Location = new Point(0, 0);
            ucBorder1.Name = "ucBorder1";
            ucBorder1.Size = new Size(2, 488);
            ucBorder1.TabIndex = 50;
            // 
            // ucBorder2
            // 
            ucBorder2.BackColor = Color.White;
            ucBorder2.Dock = DockStyle.Right;
            ucBorder2.Location = new Point(641, 0);
            ucBorder2.Name = "ucBorder2";
            ucBorder2.Size = new Size(2, 488);
            ucBorder2.TabIndex = 51;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(639, 3);
            ucBordertd1.TabIndex = 52;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 485);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(639, 3);
            ucBordertd2.TabIndex = 53;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFechaNac);
            groupBox3.Controls.Add(thunderLabel11);
            groupBox3.Controls.Add(ucErrorIconoApellido);
            groupBox3.Controls.Add(ucErrorIconoMail);
            groupBox3.Controls.Add(txtMail);
            groupBox3.Controls.Add(rdbOtro);
            groupBox3.Controls.Add(txtCelular);
            groupBox3.Controls.Add(ucErrorIconoNombre);
            groupBox3.Controls.Add(thunderLabel7);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(thunderLabel5);
            groupBox3.Controls.Add(rdbDNI);
            groupBox3.Controls.Add(txtCelular2);
            groupBox3.Controls.Add(thunderLabel1);
            groupBox3.Controls.Add(thunderLabel6);
            groupBox3.Controls.Add(thunderLabel8);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(ucErrorIconoCel);
            groupBox3.Controls.Add(txtNroDoc);
            groupBox3.Controls.Add(txtCalle);
            groupBox3.Controls.Add(thunderLabel2);
            groupBox3.Controls.Add(thunderLabel9);
            groupBox3.Controls.Add(txtApellido);
            groupBox3.Controls.Add(txtCalleNro);
            groupBox3.Controls.Add(ucAgregar1);
            groupBox3.Controls.Add(thunderLabel3);
            groupBox3.Controls.Add(thunderLabel10);
            groupBox3.Controls.Add(ucErrorIconoNroDoc);
            groupBox3.Controls.Add(txtNroDoc2);
            groupBox3.Controls.Add(cmbBarrio);
            groupBox3.Controls.Add(thunderLabel4);
            groupBox3.Location = new Point(16, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 395);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            // 
            // txtFechaNac
            // 
            txtFechaNac.CustomFormat = "dd/MM/yyyy";
            txtFechaNac.Format = DateTimePickerFormat.Custom;
            txtFechaNac.Location = new Point(154, 88);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(116, 23);
            txtFechaNac.TabIndex = 59;
            // 
            // thunderLabel11
            // 
            thunderLabel11.BackColor = Color.Transparent;
            thunderLabel11.Enabled = false;
            thunderLabel11.ForeColor = Color.WhiteSmoke;
            thunderLabel11.Location = new Point(33, 88);
            thunderLabel11.Name = "thunderLabel11";
            thunderLabel11.Size = new Size(96, 16);
            thunderLabel11.TabIndex = 45;
            thunderLabel11.Text = "Fecha. Nac";
            // 
            // ucErrorIconoMail
            // 
            ucErrorIconoMail.BackColor = Color.Transparent;
            ucErrorIconoMail.Location = new Point(9, 352);
            ucErrorIconoMail.Name = "ucErrorIconoMail";
            ucErrorIconoMail.Size = new Size(20, 20);
            ucErrorIconoMail.TabIndex = 44;
            // 
            // FrmSociosAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(643, 488);
            Controls.Add(groupBox3);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorder2);
            Controls.Add(ucBorder1);
            Controls.Add(botonesForms3);
            Controls.Add(groupBox2);
            Controls.Add(ucTituloLabel1);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSociosAlta";
            FormClosing += FrmSociosAlta_FormClosing;
            Load += FrmSociosAlta_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.AloneTextBox txtNroDoc2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private ReaLTaiizor.Controls.AloneRadioButton rdbOtro;
        private ReaLTaiizor.Controls.AloneRadioButton rdbDNI;
        private ReaLTaiizor.Controls.AloneTextBox txtTelefono;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private ReaLTaiizor.Controls.AloneTextBox txtCelular2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel5;
        private ReaLTaiizor.Controls.AloneTextBox txtMail;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.AloneTextBox txtCalleNro;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel9;
        private ReaLTaiizor.Controls.AloneTextBox txtCalle;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel8;
        private ReaLTaiizor.Controls.AloneComboBox cmbBarrio;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel10;
        private BindingSource bindingSource1;
        private UserControls.UCBotonesForms botonesForms3;
        private UserControls.UCErrorIcono ucErrorIconoApellido;
        private UserControls.UCErrorIcono ucErrorIconoNombre;
        private UserControls.UCErrorIcono ucErrorIconoCel;
        private UserControls.UCErrorIcono ucErrorIconoNroDoc;
        private UserControls.UCAgregar ucAgregar1;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtNroDoc;
        private PictureBox pictureBoxVideo;
        private ReaLTaiizor.Controls.CyberButton btnCapturar;
        private GroupBox groupBox1;
        private RadioButton rdbCam2;
        private RadioButton rdbCam1;
        private GroupBox groupBox2;
        private Label lblCargandoCamara;
        private PictureBox pictureBoxImagen;
        private Label label1;
        private Label label2;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBorderLR ucBorder1;
        private UserControls.UCBorderLR ucBorder2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderTD ucBordertd2;
        private GroupBox groupBox3;
        private UserControls.UCErrorIcono ucErrorIconoMail;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel11;
        private DateTimePicker txtFechaNac;
    }
}