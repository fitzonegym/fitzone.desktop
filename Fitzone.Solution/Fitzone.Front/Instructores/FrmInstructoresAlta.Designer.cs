namespace Fitzone.Front.Instructores
{
    partial class FrmInstructoresAlta
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
            txtFechaNac = new DateTimePicker();
            ucErrorIconoApellido = new UserControls.UCErrorIcono();
            ucErrorIconoMail = new UserControls.UCErrorIcono();
            txtMail = new ReaLTaiizor.Controls.AloneTextBox();
            btnGuardar = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            thunderLabel11 = new ReaLTaiizor.Controls.ThunderLabel();
            rdbOtro = new ReaLTaiizor.Controls.AloneRadioButton();
            txtCelular = new MaskedTextBox();
            thunderLabel8 = new ReaLTaiizor.Controls.ThunderLabel();
            groupBox3 = new GroupBox();
            ucErrorIconoNombre = new UserControls.UCErrorIcono();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            rdbDNI = new ReaLTaiizor.Controls.AloneRadioButton();
            txtCelular2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel6 = new ReaLTaiizor.Controls.ThunderLabel();
            txtTelefono = new ReaLTaiizor.Controls.AloneTextBox();
            ucErrorIconoCel = new UserControls.UCErrorIcono();
            txtNroDoc = new MaskedTextBox();
            txtCalle = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel9 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            txtCalleNro = new ReaLTaiizor.Controls.AloneTextBox();
            ucAgregar1 = new UserControls.UCAgregar();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel10 = new ReaLTaiizor.Controls.ThunderLabel();
            ucErrorIconoNroDoc = new UserControls.UCErrorIcono();
            txtNroDoc2 = new ReaLTaiizor.Controls.AloneTextBox();
            cmbBarrio = new ReaLTaiizor.Controls.AloneComboBox();
            bindingSource1 = new BindingSource(components);
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorder2 = new UserControls.UCBorderLR();
            ucBorder1 = new UserControls.UCBorderLR();
            ucTitulo = new UserControls.UCTituloLabel();
            botonesForms3 = new UserControls.UCBotonesForms();
            thunderLabel12 = new ReaLTaiizor.Controls.ThunderLabel();
            cmbActividad = new ReaLTaiizor.Controls.AloneComboBox();
            bindingActividad = new BindingSource(components);
            ucAgregar2 = new UserControls.UCAgregar();
            groupBox1 = new GroupBox();
            ucEliminar1 = new UserControls.UCEliminar();
            dataGridView1 = new DataGridView();
            bindingGrilla = new BindingSource(components);
            actividadNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingActividad).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingGrilla).BeginInit();
            SuspendLayout();
            // 
            // txtFechaNac
            // 
            txtFechaNac.CustomFormat = "dd/MM/yyyy";
            txtFechaNac.Format = DateTimePickerFormat.Custom;
            txtFechaNac.Location = new Point(164, 88);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(116, 23);
            txtFechaNac.TabIndex = 59;
            // 
            // ucErrorIconoApellido
            // 
            ucErrorIconoApellido.BackColor = Color.Transparent;
            ucErrorIconoApellido.Location = new Point(7, 53);
            ucErrorIconoApellido.Name = "ucErrorIconoApellido";
            ucErrorIconoApellido.Size = new Size(20, 20);
            ucErrorIconoApellido.TabIndex = 39;
            // 
            // ucErrorIconoMail
            // 
            ucErrorIconoMail.BackColor = Color.Transparent;
            ucErrorIconoMail.Location = new Point(11, 352);
            ucErrorIconoMail.Name = "ucErrorIconoMail";
            ucErrorIconoMail.Size = new Size(20, 20);
            ucErrorIconoMail.TabIndex = 44;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.Transparent;
            txtMail.EnabledCalc = true;
            txtMail.Font = new Font("Segoe UI", 9F);
            txtMail.ForeColor = Color.Black;
            txtMail.Location = new Point(154, 349);
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
            // btnGuardar
            // 
            btnGuardar.Alpha = 20;
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Background = true;
            btnGuardar.Background_WidthPen = 4F;
            btnGuardar.BackgroundPen = true;
            btnGuardar.ColorBackground = Color.Black;
            btnGuardar.ColorBackground_1 = Color.Black;
            btnGuardar.ColorBackground_2 = Color.Gray;
            btnGuardar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnGuardar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnGuardar.ColorPen_1 = Color.Black;
            btnGuardar.ColorPen_2 = Color.Gray;
            btnGuardar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnGuardar.Effect_1 = true;
            btnGuardar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnGuardar.Effect_1_Transparency = 25;
            btnGuardar.Effect_2 = true;
            btnGuardar.Effect_2_ColorBackground = Color.White;
            btnGuardar.Effect_2_Transparency = 20;
            btnGuardar.Font = new Font("Arial", 11F);
            btnGuardar.ForeColor = Color.FromArgb(245, 245, 245);
            btnGuardar.Lighting = false;
            btnGuardar.LinearGradient_Background = false;
            btnGuardar.LinearGradientPen = false;
            btnGuardar.Location = new Point(258, 651);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PenWidth = 15;
            btnGuardar.Rounding = true;
            btnGuardar.RoundingInt = 70;
            btnGuardar.Size = new Size(99, 40);
            btnGuardar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnGuardar.TabIndex = 55;
            btnGuardar.Tag = "Cyber";
            btnGuardar.TextButton = "Guardar";
            btnGuardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnGuardar.Timer_Effect_1 = 5;
            btnGuardar.Timer_RGB = 300;
            btnGuardar.Click += btnGuardar_Click;
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
            cyberButton1.Location = new Point(356, 651);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(99, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 56;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Cancelar";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
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
            // rdbOtro
            // 
            rdbOtro.BackColor = Color.Transparent;
            rdbOtro.Checked = false;
            rdbOtro.EnabledCalc = true;
            rdbOtro.ForeColor = Color.White;
            rdbOtro.Location = new Point(212, 118);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(60, 17);
            rdbOtro.TabIndex = 12;
            rdbOtro.Text = "Otro";
            // 
            // txtCelular
            // 
            txtCelular.BorderStyle = BorderStyle.None;
            txtCelular.Font = new Font("Segoe UI", 9F);
            txtCelular.Location = new Point(164, 285);
            txtCelular.Mask = "(999)000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(89, 16);
            txtCelular.TabIndex = 3;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCelular.Validating += _Validating;
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(16, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 392);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos instructor";
            // 
            // ucErrorIconoNombre
            // 
            ucErrorIconoNombre.BackColor = Color.Transparent;
            ucErrorIconoNombre.Location = new Point(7, 21);
            ucErrorIconoNombre.Name = "ucErrorIconoNombre";
            ucErrorIconoNombre.Size = new Size(20, 20);
            ucErrorIconoNombre.TabIndex = 38;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.Enabled = false;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(36, 357);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(50, 18);
            thunderLabel7.TabIndex = 29;
            thunderLabel7.Text = "E-mail";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.EnabledCalc = true;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(154, 13);
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
            // thunderLabel5
            // 
            thunderLabel5.BackColor = Color.Transparent;
            thunderLabel5.Enabled = false;
            thunderLabel5.ForeColor = Color.WhiteSmoke;
            thunderLabel5.Location = new Point(36, 322);
            thunderLabel5.Name = "thunderLabel5";
            thunderLabel5.Size = new Size(72, 16);
            thunderLabel5.TabIndex = 25;
            thunderLabel5.Text = "Teléfono";
            // 
            // rdbDNI
            // 
            rdbDNI.BackColor = Color.Transparent;
            rdbDNI.Checked = true;
            rdbDNI.EnabledCalc = true;
            rdbDNI.ForeColor = Color.White;
            rdbDNI.Location = new Point(162, 119);
            rdbDNI.Name = "rdbDNI";
            rdbDNI.Size = new Size(57, 17);
            rdbDNI.TabIndex = 11;
            rdbDNI.Text = "DNI";
            // 
            // txtCelular2
            // 
            txtCelular2.BackColor = Color.Transparent;
            txtCelular2.EnabledCalc = false;
            txtCelular2.Font = new Font("Segoe UI", 9F);
            txtCelular2.ForeColor = Color.Black;
            txtCelular2.Location = new Point(154, 279);
            txtCelular2.MaxLength = 50;
            txtCelular2.MultiLine = false;
            txtCelular2.Name = "txtCelular2";
            txtCelular2.ReadOnly = false;
            txtCelular2.Size = new Size(110, 29);
            txtCelular2.TabIndex = 40;
            txtCelular2.TextAlign = HorizontalAlignment.Left;
            txtCelular2.UseSystemPasswordChar = false;
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
            // thunderLabel6
            // 
            thunderLabel6.BackColor = Color.Transparent;
            thunderLabel6.Enabled = false;
            thunderLabel6.ForeColor = Color.WhiteSmoke;
            thunderLabel6.Location = new Point(36, 287);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(62, 21);
            thunderLabel6.TabIndex = 15;
            thunderLabel6.Text = "Celular";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.EnabledCalc = true;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(154, 314);
            txtTelefono.MaxLength = 10;
            txtTelefono.MultiLine = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = false;
            txtTelefono.Size = new Size(234, 29);
            txtTelefono.TabIndex = 4;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // ucErrorIconoCel
            // 
            ucErrorIconoCel.BackColor = Color.Transparent;
            ucErrorIconoCel.Location = new Point(11, 284);
            ucErrorIconoCel.Name = "ucErrorIconoCel";
            ucErrorIconoCel.Size = new Size(20, 20);
            ucErrorIconoCel.TabIndex = 42;
            // 
            // txtNroDoc
            // 
            txtNroDoc.BorderStyle = BorderStyle.None;
            txtNroDoc.Font = new Font("Segoe UI", 9F);
            txtNroDoc.Location = new Point(164, 148);
            txtNroDoc.Mask = "00,000,000";
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(89, 16);
            txtNroDoc.TabIndex = 2;
            txtNroDoc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtNroDoc.Validating += _Validating;
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.Transparent;
            txtCalle.EnabledCalc = true;
            txtCalle.Font = new Font("Segoe UI", 9F);
            txtCalle.ForeColor = Color.Black;
            txtCalle.Location = new Point(154, 177);
            txtCalle.MaxLength = 30;
            txtCalle.MultiLine = false;
            txtCalle.Name = "txtCalle";
            txtCalle.ReadOnly = false;
            txtCalle.Size = new Size(233, 29);
            txtCalle.TabIndex = 7;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            txtCalle.UseSystemPasswordChar = false;
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
            // txtApellido
            // 
            txtApellido.BackColor = Color.Transparent;
            txtApellido.EnabledCalc = true;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(154, 48);
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
            // txtCalleNro
            // 
            txtCalleNro.BackColor = Color.Transparent;
            txtCalleNro.EnabledCalc = true;
            txtCalleNro.Font = new Font("Segoe UI", 9F);
            txtCalleNro.ForeColor = Color.Black;
            txtCalleNro.Location = new Point(154, 211);
            txtCalleNro.MaxLength = 5;
            txtCalleNro.MultiLine = false;
            txtCalleNro.Name = "txtCalleNro";
            txtCalleNro.ReadOnly = false;
            txtCalleNro.Size = new Size(123, 29);
            txtCalleNro.TabIndex = 8;
            txtCalleNro.TextAlign = HorizontalAlignment.Left;
            txtCalleNro.UseSystemPasswordChar = false;
            // 
            // ucAgregar1
            // 
            ucAgregar1.BackColor = Color.Transparent;
            ucAgregar1.Location = new Point(369, 249);
            ucAgregar1.Name = "ucAgregar1";
            ucAgregar1.Size = new Size(20, 20);
            ucAgregar1.TabIndex = 43;
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
            // thunderLabel10
            // 
            thunderLabel10.BackColor = Color.Transparent;
            thunderLabel10.Enabled = false;
            thunderLabel10.ForeColor = Color.WhiteSmoke;
            thunderLabel10.Location = new Point(36, 250);
            thunderLabel10.Name = "thunderLabel10";
            thunderLabel10.Size = new Size(77, 21);
            thunderLabel10.TabIndex = 35;
            thunderLabel10.Text = "Barrio";
            // 
            // ucErrorIconoNroDoc
            // 
            ucErrorIconoNroDoc.BackColor = Color.Transparent;
            ucErrorIconoNroDoc.Location = new Point(8, 145);
            ucErrorIconoNroDoc.Name = "ucErrorIconoNroDoc";
            ucErrorIconoNroDoc.Size = new Size(20, 20);
            ucErrorIconoNroDoc.TabIndex = 41;
            // 
            // txtNroDoc2
            // 
            txtNroDoc2.BackColor = Color.Transparent;
            txtNroDoc2.EnabledCalc = true;
            txtNroDoc2.Font = new Font("Segoe UI", 9F);
            txtNroDoc2.ForeColor = Color.Black;
            txtNroDoc2.Location = new Point(154, 142);
            txtNroDoc2.MaxLength = 10;
            txtNroDoc2.MultiLine = false;
            txtNroDoc2.Name = "txtNroDoc2";
            txtNroDoc2.ReadOnly = false;
            txtNroDoc2.Size = new Size(110, 29);
            txtNroDoc2.TabIndex = 30;
            txtNroDoc2.TextAlign = HorizontalAlignment.Left;
            txtNroDoc2.UseSystemPasswordChar = false;
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
            cmbBarrio.Location = new Point(164, 246);
            cmbBarrio.Name = "cmbBarrio";
            cmbBarrio.Size = new Size(196, 26);
            cmbBarrio.TabIndex = 6;
            cmbBarrio.ValueMember = "idBarrio";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Barrio);
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
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 697);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(463, 3);
            ucBordertd2.TabIndex = 63;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(463, 3);
            ucBordertd1.TabIndex = 62;
            // 
            // ucBorder2
            // 
            ucBorder2.BackColor = Color.White;
            ucBorder2.Dock = DockStyle.Right;
            ucBorder2.Location = new Point(465, 0);
            ucBorder2.Name = "ucBorder2";
            ucBorder2.Size = new Size(2, 700);
            ucBorder2.TabIndex = 61;
            // 
            // ucBorder1
            // 
            ucBorder1.BackColor = Color.White;
            ucBorder1.Dock = DockStyle.Left;
            ucBorder1.Location = new Point(0, 0);
            ucBorder1.Name = "ucBorder1";
            ucBorder1.Size = new Size(2, 700);
            ucBorder1.TabIndex = 60;
            // 
            // ucTitulo
            // 
            ucTitulo._titulo = "Agregar Instructor";
            ucTitulo.BackColor = Color.FromArgb(103, 58, 183);
            ucTitulo.Location = new Point(4, 4);
            ucTitulo.Name = "ucTitulo";
            ucTitulo.Size = new Size(166, 34);
            ucTitulo.TabIndex = 59;
            // 
            // botonesForms3
            // 
            botonesForms3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms3.BackColor = Color.Transparent;
            botonesForms3.Location = new Point(416, 6);
            botonesForms3.Name = "botonesForms3";
            botonesForms3.Size = new Size(44, 20);
            botonesForms3.TabIndex = 57;
            botonesForms3.TabStop = false;
            // 
            // thunderLabel12
            // 
            thunderLabel12.BackColor = Color.Transparent;
            thunderLabel12.Enabled = false;
            thunderLabel12.ForeColor = Color.WhiteSmoke;
            thunderLabel12.Location = new Point(43, 27);
            thunderLabel12.Name = "thunderLabel12";
            thunderLabel12.Size = new Size(77, 21);
            thunderLabel12.TabIndex = 66;
            thunderLabel12.Text = "Actividad";
            // 
            // cmbActividad
            // 
            cmbActividad.DataSource = bindingActividad;
            cmbActividad.DisplayMember = "nombre";
            cmbActividad.DrawMode = DrawMode.OwnerDrawFixed;
            cmbActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActividad.EnabledCalc = true;
            cmbActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbActividad.ForeColor = Color.Black;
            cmbActividad.FormattingEnabled = true;
            cmbActividad.ItemHeight = 20;
            cmbActividad.Location = new Point(142, 22);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(196, 26);
            cmbActividad.TabIndex = 65;
            cmbActividad.ValueMember = "idActividad";
            // 
            // bindingActividad
            // 
            bindingActividad.DataSource = typeof(Entidades.Actividad);
            // 
            // ucAgregar2
            // 
            ucAgregar2.BackColor = Color.Transparent;
            ucAgregar2.Location = new Point(357, 28);
            ucAgregar2.Name = "ucAgregar2";
            ucAgregar2.Size = new Size(20, 20);
            ucAgregar2.TabIndex = 67;
            ucAgregar2._ClickUCAgregar += ucAgregar2__ClickUCAgregar;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(ucEliminar1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(thunderLabel12);
            groupBox1.Controls.Add(ucAgregar2);
            groupBox1.Controls.Add(cmbActividad);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 428);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 217);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actividades";
            // 
            // ucEliminar1
            // 
            ucEliminar1.BackColor = Color.Transparent;
            ucEliminar1.Location = new Point(383, 28);
            ucEliminar1.Name = "ucEliminar1";
            ucEliminar1.Size = new Size(20, 20);
            ucEliminar1.TabIndex = 69;
            ucEliminar1._ClickUCEliminar += ucEliminar1__ClickUCEliminar;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { actividadNombreDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingGrilla;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(15, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(422, 157);
            dataGridView1.TabIndex = 68;
            // 
            // bindingGrilla
            // 
            bindingGrilla.DataSource = typeof(Entidades.InstructorActividad);
            // 
            // actividadNombreDataGridViewTextBoxColumn
            // 
            actividadNombreDataGridViewTextBoxColumn.DataPropertyName = "ActividadNombre";
            actividadNombreDataGridViewTextBoxColumn.HeaderText = "Actividad";
            actividadNombreDataGridViewTextBoxColumn.Name = "actividadNombreDataGridViewTextBoxColumn";
            actividadNombreDataGridViewTextBoxColumn.ReadOnly = true;
            actividadNombreDataGridViewTextBoxColumn.Width = 378;
            // 
            // FrmInstructoresAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(467, 700);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Controls.Add(cyberButton1);
            Controls.Add(groupBox3);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorder2);
            Controls.Add(ucBorder1);
            Controls.Add(ucTitulo);
            Controls.Add(botonesForms3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInstructoresAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInstructoresAlta";
            Load += FrmInstructoresAlta_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingActividad).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker txtFechaNac;
        private UserControls.UCErrorIcono ucErrorIconoApellido;
        private UserControls.UCErrorIcono ucErrorIconoMail;
        private ReaLTaiizor.Controls.AloneTextBox txtMail;
        private ReaLTaiizor.Controls.CyberButton btnGuardar;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel11;
        private ReaLTaiizor.Controls.AloneRadioButton rdbOtro;
        private MaskedTextBox txtCelular;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel8;
        private GroupBox groupBox3;
        private UserControls.UCErrorIcono ucErrorIconoNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel5;
        private ReaLTaiizor.Controls.AloneRadioButton rdbDNI;
        private ReaLTaiizor.Controls.AloneTextBox txtCelular2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel6;
        private ReaLTaiizor.Controls.AloneTextBox txtTelefono;
        private UserControls.UCErrorIcono ucErrorIconoCel;
        private MaskedTextBox txtNroDoc;
        private ReaLTaiizor.Controls.AloneTextBox txtCalle;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel9;
        private ReaLTaiizor.Controls.AloneTextBox txtApellido;
        private ReaLTaiizor.Controls.AloneTextBox txtCalleNro;
        private UserControls.UCAgregar ucAgregar1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel10;
        private UserControls.UCErrorIcono ucErrorIconoNroDoc;
        private ReaLTaiizor.Controls.AloneTextBox txtNroDoc2;
        private ReaLTaiizor.Controls.AloneComboBox cmbBarrio;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorder2;
        private UserControls.UCBorderLR ucBorder1;
        private UserControls.UCTituloLabel ucTitulo;
        private UserControls.UCBotonesForms botonesForms3;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel12;
        private ReaLTaiizor.Controls.AloneComboBox cmbActividad;
        private UserControls.UCAgregar ucAgregar2;
        private GroupBox groupBox1;
        private UserControls.UCEliminar ucEliminar1;
        private BindingSource bindingActividad;
        private BindingSource bindingGrilla;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn actividadNombreDataGridViewTextBoxColumn;
    }
}