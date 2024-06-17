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
            groupBox1 = new GroupBox();
            label1 = new Label();
            inicio = new Label();
            pictureBox1 = new PictureBox();
            txtusuario = new TextBox();
            txtcontrasena = new TextBox();
            ucBotonesForms1 = new UserControls.UCBotonesForms();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(inicio);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(txtcontrasena);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(387, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 427);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(117, 408);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 4;
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
            inicio.ForeColor = Color.Black;
            inicio.Location = new Point(117, 307);
            inicio.Name = "inicio";
            inicio.Size = new Size(129, 25);
            inicio.TabIndex = 4;
            inicio.Text = "Iniciar Sesión";
            inicio.TextAlign = ContentAlignment.MiddleCenter;
            inicio.Click += inicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 38);
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
            txtusuario.Location = new Point(89, 199);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "Usuario";
            txtusuario.Size = new Size(184, 25);
            txtusuario.TabIndex = 1;
            txtusuario.KeyPress += txtusuario_KeyPress;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasena.ForeColor = Color.Black;
            txtcontrasena.Location = new Point(89, 253);
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
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1251, 714);
            Controls.Add(ucBotonesForms1);
            Controls.Add(groupBox1);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login FitZone";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            SizeChanged += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtusuario;
        private TextBox txtcontrasena;
        private PictureBox pictureBox1;
        private Label inicio;
        private Label label1;
        private UserControls.UCBotonesForms ucBotonesForms1;
    }
}
