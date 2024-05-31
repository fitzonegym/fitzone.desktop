namespace Fitzone.Front.UserControls
{
    partial class BotonesForms
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Image = Properties.Resources.min;
            btnMin.Location = new Point(0, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(20, 20);
            btnMin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMin.TabIndex = 2;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Image = Properties.Resources.max;
            btnMax.Location = new Point(23, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(20, 20);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 3;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(46, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // BotonesForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnClose);
            Controls.Add(btnMax);
            Controls.Add(btnMin);
            Name = "BotonesForms";
            Size = new Size(69, 20);
            Load += BotonesForms_Load;
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnClose;
    }
}
