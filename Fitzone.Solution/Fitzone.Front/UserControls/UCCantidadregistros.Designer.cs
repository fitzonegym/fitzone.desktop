namespace Fitzone.Front.UserControls
{
    partial class UCCantidadregistros
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
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            txtValor = new ReaLTaiizor.Controls.ThunderLabel();
            SuspendLayout();
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(-2, -2);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(69, 19);
            thunderLabel4.TabIndex = 31;
            thunderLabel4.Text = "Cantidad";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.Transparent;
            txtValor.ForeColor = Color.WhiteSmoke;
            txtValor.Location = new Point(69, -1);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(30, 16);
            txtValor.TabIndex = 32;
            txtValor.Text = "0";
            // 
            // UCCantidadregistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(txtValor);
            Controls.Add(thunderLabel4);
            Name = "UCCantidadregistros";
            Size = new Size(103, 16);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private ReaLTaiizor.Controls.ThunderLabel txtValor;
    }
}
