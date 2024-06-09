namespace Fitzone.Front.FormsExtras
{
    partial class FrmWait
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
            SuspendLayout();
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.BackColor = Color.Transparent;
            lblMensaje2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMensaje2.ForeColor = Color.White;
            lblMensaje2.Location = new Point(108, 41);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(87, 19);
            lblMensaje2.TabIndex = 22;
            lblMensaje2.Text = "Cargando...";
            // 
            // FrmWait
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 45, 168);
            ClientSize = new Size(315, 107);
            Controls.Add(lblMensaje2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmWait";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmWait";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje2;
    }
}