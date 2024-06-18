namespace Fitzone.Front.Login
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            inicio = new Label();
            pictureBox1 = new PictureBox();
            txtusuario = new TextBox();
            txtcontrasena = new TextBox();
            ucBotonesForms1 = new UserControls.UCBotonesForms();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 383);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 3;
            label1.Text = "¿Olvido su contraseña?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += inicio_Click;
            // 
            // inicio
            // 
            inicio.AutoSize = true;
            inicio.BackColor = Color.Transparent;
            inicio.Cursor = Cursors.Hand;
            inicio.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inicio.ForeColor = Color.White;
            inicio.Location = new Point(121, 282);
            inicio.Name = "inicio";
            inicio.Size = new Size(129, 25);
            inicio.TabIndex = 2;
            inicio.Text = "Iniciar Sesión";
            inicio.TextAlign = ContentAlignment.MiddleCenter;
            inicio.Click += inicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 73);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario.ForeColor = Color.Black;
            txtusuario.Location = new Point(93, 174);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "Usuario";
            txtusuario.Size = new Size(184, 25);
            txtusuario.TabIndex = 0;
            txtusuario.KeyPress += txtusuario_KeyPress;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasena.ForeColor = Color.Black;
            txtcontrasena.Location = new Point(93, 228);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.PlaceholderText = "Contraseña";
            txtcontrasena.Size = new Size(184, 25);
            txtcontrasena.TabIndex = 1;
            txtcontrasena.KeyPress += txtusuario_KeyPress;
            // 
            // ucBotonesForms1
            // 
            ucBotonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ucBotonesForms1.BackColor = Color.Transparent;
            ucBotonesForms1.Location = new Point(1164, 12);
            ucBotonesForms1.Name = "ucBotonesForms1";
            ucBotonesForms1.Size = new Size(43, 20);
            ucBotonesForms1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(inicio);
            panel1.Controls.Add(txtcontrasena);
            panel1.Controls.Add(txtusuario);
            panel1.Location = new Point(412, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 423);
            panel1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondologin2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1251, 714);
            Controls.Add(panel1);
            Controls.Add(ucBotonesForms1);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login FitZone";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            SizeChanged += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtusuario;
        private TextBox txtcontrasena;
        private PictureBox pictureBox1;
        private Label inicio;
        private Label label1;
        private UserControls.UCBotonesForms ucBotonesForms1;
        private Panel panel1;
    }
}
