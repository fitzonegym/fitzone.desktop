﻿namespace Fitzone.Front.Socios
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
            txtNroDoc = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            ucAgregar1 = new UserControls.UCAgregar();
            ucErrorIconoCel = new UserControls.UCErrorIcono();
            ucErrorIconoNroDoc = new UserControls.UCErrorIcono();
            ucErrorIconoApellido = new UserControls.UCErrorIcono();
            ucErrorIconoNombre = new UserControls.UCErrorIcono();
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
            txtCelular2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel5 = new ReaLTaiizor.Controls.ThunderLabel();
            rdbOtro = new ReaLTaiizor.Controls.AloneRadioButton();
            rdbDNI = new ReaLTaiizor.Controls.AloneRadioButton();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            txtNroDoc2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            txtApellido = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
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
            thunderForm1.Controls.Add(txtNroDoc);
            thunderForm1.Controls.Add(txtCelular);
            thunderForm1.Controls.Add(ucAgregar1);
            thunderForm1.Controls.Add(ucErrorIconoCel);
            thunderForm1.Controls.Add(ucErrorIconoNroDoc);
            thunderForm1.Controls.Add(ucErrorIconoApellido);
            thunderForm1.Controls.Add(ucErrorIconoNombre);
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
            thunderForm1.Controls.Add(txtCelular2);
            thunderForm1.Controls.Add(thunderLabel5);
            thunderForm1.Controls.Add(rdbOtro);
            thunderForm1.Controls.Add(rdbDNI);
            thunderForm1.Controls.Add(thunderLabel4);
            thunderForm1.Controls.Add(cyberButton1);
            thunderForm1.Controls.Add(cyberButton2);
            thunderForm1.Controls.Add(txtNroDoc2);
            thunderForm1.Controls.Add(thunderLabel3);
            thunderForm1.Controls.Add(txtApellido);
            thunderForm1.Controls.Add(thunderLabel2);
            thunderForm1.Controls.Add(txtNombre);
            thunderForm1.Controls.Add(thunderLabel1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(737, 362);
            thunderForm1.TabIndex = 0;
            thunderForm1.Text = "Alta de socios";
            // 
            // txtNroDoc
            // 
            txtNroDoc.BorderStyle = BorderStyle.None;
            txtNroDoc.Font = new Font("Segoe UI", 9F);
            txtNroDoc.Location = new Point(159, 161);
            txtNroDoc.Mask = "99.999.999";
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
            txtCelular.Location = new Point(159, 196);
            txtCelular.Mask = "(999)000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(89, 16);
            txtCelular.TabIndex = 3;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCelular.Click += txtCelular_Click;
            txtCelular.Validating += _Validating;
            // 
            // ucAgregar1
            // 
            ucAgregar1.BackColor = Color.Transparent;
            ucAgregar1.Location = new Point(690, 53);
            ucAgregar1.Name = "ucAgregar1";
            ucAgregar1.Size = new Size(20, 20);
            ucAgregar1.TabIndex = 43;
            // 
            // ucErrorIconoCel
            // 
            ucErrorIconoCel.BackColor = Color.Transparent;
            ucErrorIconoCel.Location = new Point(15, 194);
            ucErrorIconoCel.Name = "ucErrorIconoCel";
            ucErrorIconoCel.Size = new Size(20, 20);
            ucErrorIconoCel.TabIndex = 42;
            // 
            // ucErrorIconoNroDoc
            // 
            ucErrorIconoNroDoc.BackColor = Color.Transparent;
            ucErrorIconoNroDoc.Location = new Point(14, 159);
            ucErrorIconoNroDoc.Name = "ucErrorIconoNroDoc";
            ucErrorIconoNroDoc.Size = new Size(20, 20);
            ucErrorIconoNroDoc.TabIndex = 41;
            // 
            // ucErrorIconoApellido
            // 
            ucErrorIconoApellido.BackColor = Color.Transparent;
            ucErrorIconoApellido.Location = new Point(14, 82);
            ucErrorIconoApellido.Name = "ucErrorIconoApellido";
            ucErrorIconoApellido.Size = new Size(20, 20);
            ucErrorIconoApellido.TabIndex = 39;
            // 
            // ucErrorIconoNombre
            // 
            ucErrorIconoNombre.BackColor = Color.Transparent;
            ucErrorIconoNombre.Location = new Point(14, 49);
            ucErrorIconoNombre.Name = "ucErrorIconoNombre";
            ucErrorIconoNombre.Size = new Size(20, 20);
            ucErrorIconoNombre.TabIndex = 38;
            // 
            // botonesForms3
            // 
            botonesForms3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms3.BackColor = Color.Transparent;
            botonesForms3.Location = new Point(663, 4);
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
            cmbBarrio.Location = new Point(469, 48);
            cmbBarrio.Name = "cmbBarrio";
            cmbBarrio.Size = new Size(214, 26);
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
            thunderLabel10.Location = new Point(397, 54);
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
            txtCalleNro.Location = new Point(460, 113);
            txtCalleNro.MaxLength = 10;
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
            thunderLabel9.Location = new Point(397, 122);
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
            txtCalle.Location = new Point(460, 79);
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
            thunderLabel8.Location = new Point(397, 87);
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
            txtMail.MaxLength = 30;
            txtMail.MultiLine = false;
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = false;
            txtMail.Size = new Size(233, 29);
            txtMail.TabIndex = 5;
            txtMail.TextAlign = HorizontalAlignment.Left;
            txtMail.UseSystemPasswordChar = false;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.Transparent;
            thunderLabel7.Enabled = false;
            thunderLabel7.ForeColor = Color.WhiteSmoke;
            thunderLabel7.Location = new Point(46, 268);
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
            txtTelefono.MaxLength = 10;
            txtTelefono.MultiLine = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = false;
            txtTelefono.Size = new Size(174, 29);
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
            thunderLabel6.Location = new Point(46, 198);
            thunderLabel6.Name = "thunderLabel6";
            thunderLabel6.Size = new Size(96, 16);
            thunderLabel6.TabIndex = 15;
            thunderLabel6.Text = "Celular";
            // 
            // txtCelular2
            // 
            txtCelular2.BackColor = Color.Transparent;
            txtCelular2.EnabledCalc = false;
            txtCelular2.Font = new Font("Segoe UI", 9F);
            txtCelular2.ForeColor = Color.Black;
            txtCelular2.Location = new Point(149, 190);
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
            thunderLabel5.Location = new Point(46, 233);
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
            rdbOtro.ForeColor = Color.White;
            rdbOtro.Location = new Point(222, 126);
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
            rdbDNI.Location = new Point(159, 126);
            rdbDNI.Name = "rdbDNI";
            rdbDNI.Size = new Size(57, 17);
            rdbDNI.TabIndex = 11;
            rdbDNI.Text = "DNI";
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.Enabled = false;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(46, 126);
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
            cyberButton1.Location = new Point(624, 310);
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
            cyberButton2.Location = new Point(519, 310);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(99, 40);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 9;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Aceptar";
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
            txtNroDoc2.Location = new Point(149, 155);
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
            thunderLabel3.Location = new Point(46, 163);
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
            thunderLabel2.Location = new Point(46, 87);
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
            thunderLabel1.Location = new Point(46, 54);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(96, 16);
            thunderLabel1.TabIndex = 11;
            thunderLabel1.Text = "Nombre";
            // 
            // FrmSociosAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 362);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAlta";
            Text = "FrmSociosAlta";
            TransparencyKey = Color.Fuchsia;
            Load += FrmSociosAlta_Load;
            thunderForm1.ResumeLayout(false);
            thunderForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
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
        private UserControls.BotonesForms botonesForms3;
        private UserControls.UCErrorIcono ucErrorIconoApellido;
        private UserControls.UCErrorIcono ucErrorIconoNombre;
        private UserControls.UCErrorIcono ucErrorIconoCel;
        private UserControls.UCErrorIcono ucErrorIconoNroDoc;
        private UserControls.UCAgregar ucAgregar1;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtNroDoc;
    }
}