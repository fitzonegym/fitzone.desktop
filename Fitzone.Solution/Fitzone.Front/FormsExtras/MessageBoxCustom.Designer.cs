namespace Fitzone.Front.FormsExtras
{
    partial class MessageBoxCustom
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
            lblMensaje = new ReaLTaiizor.Controls.ThunderLabel();
            btn2 = new ReaLTaiizor.Controls.CyberButton();
            btn1 = new ReaLTaiizor.Controls.CyberButton();
            botonesForms1 = new UserControls.BotonesForms();
            thunderForm1.SuspendLayout();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BackColor = Color.FromArgb(255, 192, 128);
            thunderForm1.BodyColorA = Color.Black;
            thunderForm1.BodyColorB = Color.Black;
            thunderForm1.BodyColorC = Color.FromArgb(209, 196, 234);
            thunderForm1.BodyColorD = Color.FromArgb(209, 196, 234);
            thunderForm1.Controls.Add(lblMensaje);
            thunderForm1.Controls.Add(btn2);
            thunderForm1.Controls.Add(btn1);
            thunderForm1.Controls.Add(botonesForms1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(433, 185);
            thunderForm1.TabIndex = 1;
            thunderForm1.Text = "Fitzone";
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.FromArgb(209, 196, 234);
            lblMensaje.ForeColor = Color.BlueViolet;
            lblMensaje.Location = new Point(26, 43);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(391, 57);
            lblMensaje.TabIndex = 20;
            lblMensaje.Text = "¿Desea salir del sistema?";
            // 
            // btn2
            // 
            btn2.Alpha = 20;
            btn2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn2.BackColor = Color.Transparent;
            btn2.Background = true;
            btn2.Background_WidthPen = 4F;
            btn2.BackgroundPen = true;
            btn2.ColorBackground = Color.FromArgb(37, 52, 68);
            btn2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn2.ColorLighting = Color.FromArgb(29, 200, 238);
            btn2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn2.Effect_1 = true;
            btn2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn2.Effect_1_Transparency = 25;
            btn2.Effect_2 = true;
            btn2.Effect_2_ColorBackground = Color.White;
            btn2.Effect_2_Transparency = 20;
            btn2.Font = new Font("Arial", 11F);
            btn2.ForeColor = Color.FromArgb(245, 245, 245);
            btn2.Lighting = false;
            btn2.LinearGradient_Background = false;
            btn2.LinearGradientPen = false;
            btn2.Location = new Point(316, 133);
            btn2.Name = "btn2";
            btn2.PenWidth = 15;
            btn2.Rounding = true;
            btn2.RoundingInt = 70;
            btn2.Size = new Size(99, 40);
            btn2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn2.TabIndex = 19;
            btn2.Tag = "Cyber";
            btn2.TextButton = "No";
            btn2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn2.Timer_Effect_1 = 5;
            btn2.Timer_RGB = 300;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Alpha = 20;
            btn1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn1.BackColor = Color.Transparent;
            btn1.Background = true;
            btn1.Background_WidthPen = 4F;
            btn1.BackgroundPen = true;
            btn1.ColorBackground = Color.FromArgb(37, 52, 68);
            btn1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn1.ColorLighting = Color.FromArgb(29, 200, 238);
            btn1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn1.Effect_1 = true;
            btn1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn1.Effect_1_Transparency = 25;
            btn1.Effect_2 = true;
            btn1.Effect_2_ColorBackground = Color.White;
            btn1.Effect_2_Transparency = 20;
            btn1.Font = new Font("Arial", 11F);
            btn1.ForeColor = Color.FromArgb(245, 245, 245);
            btn1.Lighting = false;
            btn1.LinearGradient_Background = false;
            btn1.LinearGradientPen = false;
            btn1.Location = new Point(211, 133);
            btn1.Name = "btn1";
            btn1.PenWidth = 15;
            btn1.Rounding = true;
            btn1.RoundingInt = 70;
            btn1.Size = new Size(99, 40);
            btn1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn1.TabIndex = 18;
            btn1.Tag = "Cyber";
            btn1.TextButton = "Si";
            btn1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn1.Timer_Effect_1 = 5;
            btn1.Timer_RGB = 300;
            btn1.Click += btn1_Click;
            // 
            // botonesForms1
            // 
            botonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms1.BackColor = Color.Transparent;
            botonesForms1.Location = new Point(889, 4);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 0;
            // 
            // MessageBoxCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 185);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxCustom";
            StartPosition = FormStartPosition.CenterParent;
            TransparencyKey = Color.Fuchsia;
            Load += MessageBoxCustom_Load;
            thunderForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private UserControls.BotonesForms botonesForms1;
        private ReaLTaiizor.Controls.CyberButton btn2;
        private ReaLTaiizor.Controls.CyberButton btn1;
        private ReaLTaiizor.Controls.ThunderLabel lblMensaje;
    }
}