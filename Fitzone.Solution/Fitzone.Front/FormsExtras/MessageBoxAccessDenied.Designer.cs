namespace Fitzone.Front.FormsExtras
{
    partial class MessageBoxAccessDenied
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
            btn1 = new ReaLTaiizor.Controls.CyberButton();
            botonesForms1 = new UserControls.UCBotonesForms();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.BackColor = Color.Transparent;
            lblMensaje2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMensaje2.ForeColor = Color.FromArgb(81, 45, 168);
            lblMensaje2.Location = new Point(28, 92);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(325, 19);
            lblMensaje2.TabIndex = 25;
            lblMensaje2.Text = "No tiene acceso al modulo que intenta ingresar";
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
            btn1.Location = new Point(287, 129);
            btn1.Name = "btn1";
            btn1.PenWidth = 15;
            btn1.Rounding = true;
            btn1.RoundingInt = 70;
            btn1.Size = new Size(99, 40);
            btn1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn1.TabIndex = 23;
            btn1.Tag = "Cyber";
            btn1.TextButton = "Aceptar";
            btn1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn1.Timer_Effect_1 = 5;
            btn1.Timer_RGB = 300;
            btn1.Click += btn1_Click;
            // 
            // botonesForms1
            // 
            botonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms1.BackColor = Color.Transparent;
            botonesForms1.Location = new Point(348, 3);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(81, 45, 168);
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 26;
            label1.Text = "Acceso denegado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.obligatorio;
            pictureBox1.Location = new Point(5, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // MessageBoxAccessDenied
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 196, 234);
            ClientSize = new Size(394, 176);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblMensaje2);
            Controls.Add(btn1);
            Controls.Add(botonesForms1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxAccessDenied";
            Text = "MessageBoxAccessDenied";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje2;
        private ReaLTaiizor.Controls.CyberButton btn1;
        private UserControls.UCBotonesForms botonesForms1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}