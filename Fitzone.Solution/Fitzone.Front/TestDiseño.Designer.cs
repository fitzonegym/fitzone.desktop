namespace Fitzone.Front
{
    partial class TestDiseño
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
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            botonesForms3 = new UserControls.BotonesForms();
            cmbBarrio = new ReaLTaiizor.Controls.AloneComboBox();
            thunderLabel10 = new ReaLTaiizor.Controls.ThunderLabel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            txtNombre = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            thunderForm1.SuspendLayout();
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
            thunderForm1.Controls.Add(cyberButton1);
            thunderForm1.Controls.Add(cyberButton2);
            thunderForm1.Controls.Add(txtNombre);
            thunderForm1.Controls.Add(thunderLabel1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(800, 450);
            thunderForm1.TabIndex = 3;
            thunderForm1.Text = "Alta de socios";
            // 
            // botonesForms3
            // 
            botonesForms3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms3.BackColor = Color.Transparent;
            botonesForms3.Location = new Point(728, 4);
            botonesForms3.Name = "botonesForms3";
            botonesForms3.Size = new Size(69, 20);
            botonesForms3.TabIndex = 37;
            // 
            // cmbBarrio
            // 
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
            cyberButton1.Location = new Point(678, 398);
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
            cyberButton2.Location = new Point(573, 398);
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
            // 
            // TestDiseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestDiseño";
            Text = "TestDiseño";
            TransparencyKey = Color.Fuchsia;
            thunderForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private UserControls.BotonesForms botonesForms3;
        private ReaLTaiizor.Controls.AloneComboBox cmbBarrio;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel10;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.AloneTextBox txtNombre;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
    }
}