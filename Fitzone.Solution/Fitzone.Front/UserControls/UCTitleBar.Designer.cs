namespace Fitzone.Front.UserControls
{
    partial class UCTitleBar
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
            botonesForms1 = new BotonesForms();
            SuspendLayout();
            // 
            // botonesForms1
            // 
            botonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms1.BackColor = Color.Transparent;
            botonesForms1.Location = new Point(352, 3);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 0;
            // 
            // UCTitleBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 45, 168);
            Controls.Add(botonesForms1);
            Name = "UCTitleBar";
            Size = new Size(424, 26);
            ResumeLayout(false);
        }

        #endregion

        private BotonesForms botonesForms1;
    }
}
