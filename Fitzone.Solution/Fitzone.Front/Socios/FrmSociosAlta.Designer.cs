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
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            botonesForms3 = new UserControls.BotonesForms();
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
            txtCelular = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            rdbOtro = new ReaLTaiizor.Controls.AloneRadioButton();
            rdbDNI = new ReaLTaiizor.Controls.AloneRadioButton();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAceptar = new ReaLTaiizor.Controls.CyberButton();
            txtNroDoc = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            botonesForms2 = new UserControls.BotonesForms();
            botonesForms1 = new UserControls.BotonesForms();
            thunderForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BodyColorA = Color.Black;
            thunderForm1.BodyColorB = Color.Black;
            thunderForm1.BodyColorC = Color.FromArgb(103, 58, 183);
            thunderForm1.BodyColorD = Color.FromArgb(133, 110, 183);
            thunderForm1.Controls.Add(botonesForms3);
            thunderForm1.Controls.Add(cmbBarrio);
            thunderForm1.Controls.Add(thunderLabel10);
            thunderForm1.Controls.Add(txtCalleNro);
            thunderForm1.Controls.Add(thunderLabel9);
            thunderForm1.Controls.Add(txtCalle);
            thunderForm1.Controls.Add(thunderLabel8);
            thunderForm1.Controls.Add(txtMail);
            thunderForm1.Controls.Add(thunderLabel7);
            thunderForm1.Controls.Add(txtTelefono);
            thunderForm1.Controls.Add(thunderLabel6);
            thunderForm1.Controls.Add(txtCelular);
            thunderForm1.Controls.Add(thunderLabel5);
            thunderForm1.Controls.Add(rdbOtro);
            thunderForm1.Controls.Add(rdbDNI);
            thunderForm1.Controls.Add(thunderLabel4);
            thunderForm1.Controls.Add(cyberButton1);
            thunderForm1.Controls.Add(cyberButton2);
            thunderForm1.Controls.Add(btnCancelar);
            thunderForm1.Controls.Add(btnAceptar);
            thunderForm1.Controls.Add(txtNroDoc);
            thunderForm1.Controls.Add(thunderLabel3);
            thunderForm1.Controls.Add(txtApellido);
            thunderForm1.Controls.Add(thunderLabel2);
            thunderForm1.Controls.Add(txtNombre);
            thunderForm1.Controls.Add(thunderLabel1);
            thunderForm1.Controls.Add(botonesForms2);
            thunderForm1.Controls.Add(botonesForms1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(744, 360);
            thunderForm1.TabIndex = 2;
            thunderForm1.Text = "Alta de socios";
            // 
            // botonesForms3
            // 
            botonesForms3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms3.BackColor = Color.Transparent;
            botonesForms3.Location = new Point(670, 4);
            botonesForms3.Name = "botonesForms3";
            botonesForms3.Size = new Size(69, 20);
            botonesForms3.TabIndex = 37;
            // 
            // cmbBarrio
            // 
            cmbBarrio.DataSource = bindingSource1;
            cmbBarrio.DisplayMember = "nombre";
            cmbBarrio.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarrio.EnabledCalc = true;
            cmbBarrio.ForeColor = Color.Black;
            cmbBarrio.FormattingEnabled = true;
            cmbBarrio.ItemHeight = 20;
            cmbBarrio.Location = new Point(503, 48);
            cmbBarrio.Name = "cmbBarrio";
            cmbBarrio.Size = new Size(214, 26);
            cmbBarrio.TabIndex = 8;
            cmbBarrio.ValueMember = "idBarrio";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Barrio);
            // 
            // thunderLabel10
            // 
            thunderLabel10.BackColor = Color.Transparent;
            thunderLabel10.ForeColor = Color.WhiteSmoke;
            thunderLabel10.Location = new Point(410, 54);
            thunderLabel10.Name = "thunderLabel10";
            thunderLabel10.Size = new Size(109, 16);
            thunderLabel10.TabIndex = 35;
            thunderLabel10.Text = "Barrio";
            // 
            // txtCalleNro
            // 
            txtCalleNro.BackColor = Color.Transparent;
            txtCalleNro.EnabledCalc = true;
            txtCalleNro.Font = new Font("Segoe UI", 9F);
            txtCalleNro.ForeColor = Color.Black;
            txtCalleNro.Location = new Point(494, 113);
            txtCalleNro.MaxLength = 32767;
            txtCalleNro.MultiLine = false;
            txtCalleNro.Name = "txtCalleNro";
            txtCalleNro.ReadOnly = false;
            txtCalleNro.Size = new Size(123, 29);
            txtCalleNro.TabIndex = 10;
            txtCalleNro.TextAlign = HorizontalAlignment.Left;
            txtCalleNro.UseSystemPasswordChar = false;
            // 
            // thunderLabel9
            // 
            thunderLabel9.BackColor = Color.Transparent;
            thunderLabel9.ForeColor = Color.WhiteSmoke;
            thunderLabel9.Location = new Point(410, 122);
            thunderLabel9.Name = "thunderLabel9";
            thunderLabel9.Size = new Size(109, 16);
            thunderLabel9.TabIndex = 33;
            thunderLabel9.Text = "Calle nro.";
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.Transparent;
            txtCalle.EnabledCalc = true;
            txtCalle.Font = new Font("Segoe UI", 9F);
            txtCalle.ForeColor = Color.Black;
            txtCalle.Location = new Point(494, 79);
            txtCalle.MaxLength = 32767;
            txtCalle.MultiLine = false;
            txtCalle.Name = "txtCalle";
            txtCalle.ReadOnly = false;
            txtCalle.Size = new Size(233, 29);
            txtCalle.TabIndex = 9;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // thunderLabel8
            // 
            thunderLabel8.BackColor = Color.Transparent;
            thunderLabel8.ForeColor = Color.WhiteSmoke;
            thunderLabel8.Location = new Point(410, 87);
            thunderLabel8.Name = "thunderLabel8";
            thunderLabel8.Size = new Size(109, 16);
            thunderLabel8.TabIndex = 31;
            thunderLabel8.Text = "Calle";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.Transparent;
            txtMail.EnabledCalc = true;
            txtMail.Font = new Font("Segoe UI", 9F);
            txtMail.ForeColor = Color.Black;
            txtMail.Location = new Point(149, 260);
            txtMail.MaxLength = 32767;
            txtMail.MultiLine = false;
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = false;
            txtMail.Size = new Size(233, 29);
            txtMail.TabIndex = 7;
            txtMail.TextAlign = HorizontalAlignment.Left;
            txtMail.UseSystemPasswordChar = false;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(34, 268);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(109, 16);
            thunderLabel7.TabIndex = 29;
            thunderLabel7.Text = "E-mail";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.EnabledCalc = true;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(149, 225);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MultiLine = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = false;
            txtTelefono.Size = new Size(174, 29);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(34, 198);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(109, 16);
            thunderLabel6.TabIndex = 27;
            thunderLabel6.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.BackColor = Color.Transparent;
            txtCelular.EnabledCalc = true;
            txtCelular.Font = new Font("Segoe UI", 9F);
            txtCelular.ForeColor = Color.Black;
            txtCelular.Location = new Point(149, 190);
            txtCelular.MaxLength = 32767;
            txtCelular.MultiLine = false;
            txtCelular.Name = "txtCelular";
            txtCelular.ReadOnly = false;
            txtCelular.Size = new Size(174, 29);
            txtCelular.TabIndex = 5;
            txtCelular.TextAlign = HorizontalAlignment.Left;
            txtCelular.UseSystemPasswordChar = false;
            // 
            // thunderLabel5
            // 
            thunderLabel5.BackColor = Color.Transparent;
            thunderLabel5.ForeColor = Color.WhiteSmoke;
            thunderLabel5.Location = new Point(34, 233);
            thunderLabel5.Name = "thunderLabel5";
            thunderLabel5.Size = new Size(109, 16);
            thunderLabel5.TabIndex = 25;
            thunderLabel5.Text = "Teléfono";
            // 
            // rdbOtro
            // 
            rdbOtro.BackColor = Color.Transparent;
            rdbOtro.Checked = false;
            rdbOtro.EnabledCalc = true;
            rdbOtro.ForeColor = Color.Black;
            rdbOtro.Location = new Point(222, 126);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(60, 17);
            rdbOtro.TabIndex = 3;
            rdbOtro.Text = "Otro";
            // 
            // rdbDNI
            // 
            rdbDNI.BackColor = Color.Transparent;
            rdbDNI.Checked = true;
            rdbDNI.EnabledCalc = true;
            rdbDNI.ForeColor = Color.Black;
            rdbDNI.Location = new Point(159, 126);
            rdbDNI.Name = "rdbDNI";
            rdbDNI.Size = new Size(57, 17);
            rdbDNI.TabIndex = 2;
            rdbDNI.Text = "DNI";
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(34, 126);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(109, 16);
            thunderLabel4.TabIndex = 22;
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
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(631, 308);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(99, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 12;
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
            cyberButton2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(526, 308);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(99, 40);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 11;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Aceptar";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(1194, 744);
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
            // 
            // btnAceptar
            // 
            btnAceptar.Alpha = 20;
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.Background = true;
            btnAceptar.Background_WidthPen = 4F;
            btnAceptar.BackgroundPen = true;
            btnAceptar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnAceptar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAceptar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAceptar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAceptar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAceptar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAceptar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAceptar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAceptar.Effect_1 = true;
            btnAceptar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAceptar.Effect_1_Transparency = 25;
            btnAceptar.Effect_2 = true;
            btnAceptar.Effect_2_ColorBackground = Color.White;
            btnAceptar.Effect_2_Transparency = 20;
            btnAceptar.Font = new Font("Arial", 11F);
            btnAceptar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAceptar.Lighting = false;
            btnAceptar.LinearGradient_Background = false;
            btnAceptar.LinearGradientPen = false;
            btnAceptar.Location = new Point(1089, 744);
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
            // 
            // txtNroDoc
            // 
            txtNroDoc.BackColor = Color.Transparent;
            txtNroDoc.EnabledCalc = true;
            txtNroDoc.Font = new Font("Segoe UI", 9F);
            txtNroDoc.ForeColor = Color.Black;
            txtNroDoc.Location = new Point(149, 155);
            txtNroDoc.MaxLength = 32767;
            txtNroDoc.MultiLine = false;
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.ReadOnly = false;
            txtNroDoc.Size = new Size(233, 29);
            txtNroDoc.TabIndex = 4;
            txtNroDoc.TextAlign = HorizontalAlignment.Left;
            txtNroDoc.UseSystemPasswordChar = false;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(34, 163);
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
            txtApellido.Location = new Point(149, 79);
            txtApellido.MaxLength = 32767;
            txtApellido.MultiLine = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = false;
            txtApellido.Size = new Size(233, 29);
            txtApellido.TabIndex = 1;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.UseSystemPasswordChar = false;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(34, 87);
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
            txtNombre.Location = new Point(149, 44);
            txtNombre.MaxLength = 32767;
            txtNombre.MultiLine = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = false;
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(34, 54);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(96, 16);
            thunderLabel1.TabIndex = 2;
            thunderLabel1.Text = "Nombre";
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(1231, 5);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(69, 20);
            botonesForms2.TabIndex = 1;
            // 
            // botonesForms1
            // 
            botonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms1.BackColor = Color.Transparent;
            botonesForms1.Location = new Point(1763, 4);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 0;
            // 
            // FrmSociosAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 360);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAlta";
            Text = "FrmSociosAlta";
            TransparencyKey = Color.Fuchsia;
            Load += FrmSociosAlta_Load;
            thunderForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAceptar;
        private ReaLTaiizor.Controls.AloneTextBox txtNroDoc;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private UserControls.BotonesForms botonesForms2;
        private UserControls.BotonesForms botonesForms1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private ReaLTaiizor.Controls.AloneRadioButton rdbOtro;
        private ReaLTaiizor.Controls.AloneRadioButton rdbDNI;
        private ReaLTaiizor.Controls.AloneTextBox txtTelefono;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private ReaLTaiizor.Controls.AloneTextBox txtCelular;
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
        private UserControls.BotonesForms botonesForms3;
    }
}