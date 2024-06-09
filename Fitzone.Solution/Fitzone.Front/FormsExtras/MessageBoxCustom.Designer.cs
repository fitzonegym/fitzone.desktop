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
            lblMensaje2 = new Label();
            btn2 = new ReaLTaiizor.Controls.CyberButton();
            btn1 = new ReaLTaiizor.Controls.CyberButton();
            botonesForms1 = new UserControls.UCBotonesForms();
            SuspendLayout();
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.BackColor = Color.Transparent;
            lblMensaje2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMensaje2.ForeColor = Color.FromArgb(81, 45, 168);
            lblMensaje2.Location = new Point(12, 25);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(172, 19);
            lblMensaje2.TabIndex = 21;
            lblMensaje2.Text = "¿Desea salir del sistema?";
            // 
            // btn2
            // 
            btn2.Alpha = 20;
            btn2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn2.BackColor = Color.Transparent;
            btn2.Background = true;
            btn2.Background_WidthPen = 4F;
            btn2.BackgroundPen = true;
            btn2.ColorBackground = Color.Black;
            btn2.ColorBackground_1 = Color.Black;
            btn2.ColorBackground_2 = Color.Gray;
            btn2.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btn2.ColorLighting = Color.FromArgb(81, 45, 168);
            btn2.ColorPen_1 = Color.Black;
            btn2.ColorPen_2 = Color.Gray;
            btn2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn2.Effect_1 = true;
            btn2.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btn2.Effect_1_Transparency = 25;
            btn2.Effect_2 = true;
            btn2.Effect_2_ColorBackground = Color.White;
            btn2.Effect_2_Transparency = 20;
            btn2.Font = new Font("Arial", 11F);
            btn2.ForeColor = Color.FromArgb(245, 245, 245);
            btn2.Lighting = false;
            btn2.LinearGradient_Background = false;
            btn2.LinearGradientPen = false;
            btn2.Location = new Point(215, 77);
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
            btn1.ColorBackground = Color.Black;
            btn1.ColorBackground_1 = Color.Black;
            btn1.ColorBackground_2 = Color.Gray;
            btn1.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btn1.ColorLighting = Color.FromArgb(81, 45, 168);
            btn1.ColorPen_1 = Color.Black;
            btn1.ColorPen_2 = Color.Gray;
            btn1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn1.Effect_1 = true;
            btn1.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btn1.Effect_1_Transparency = 25;
            btn1.Effect_2 = true;
            btn1.Effect_2_ColorBackground = Color.White;
            btn1.Effect_2_Transparency = 20;
            btn1.Font = new Font("Arial", 11F);
            btn1.ForeColor = Color.FromArgb(245, 245, 245);
            btn1.Lighting = false;
            btn1.LinearGradient_Background = false;
            btn1.LinearGradientPen = false;
            btn1.Location = new Point(115, 77);
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
            botonesForms1.Location = new Point(759, -29);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 0;
            // 
            // MessageBoxCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 196, 234);
            ClientSize = new Size(319, 122);
            Controls.Add(lblMensaje2);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(botonesForms1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "MessageBoxCustom";
            StartPosition = FormStartPosition.CenterParent;
            TransparencyKey = Color.Fuchsia;
            Load += MessageBoxCustom_Load;
            KeyPress += MessageBoxCustom_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UserControls.UCBotonesForms botonesForms1;
        private ReaLTaiizor.Controls.CyberButton btn2;
        private ReaLTaiizor.Controls.CyberButton btn1;
        private Label lblMensaje2;
    }
}