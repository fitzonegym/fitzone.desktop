namespace Fitzone.Front
{
    partial class FrmContenedorPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            sociosToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            clasesToolStripMenuItem = new ToolStripMenuItem();
            instructoresToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Estado";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelPrincipal);
            splitContainer1.Size = new Size(737, 501);
            splitContainer1.SplitterDistance = 179;
            splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 419);
            panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(81, 45, 168);
            flowLayoutPanel1.Controls.Add(menuStrip1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(179, 419);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { sociosToolStripMenuItem, clasesToolStripMenuItem, instructoresToolStripMenuItem, configuraciónToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(160, 220);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            sociosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administraciónToolStripMenuItem, altaToolStripMenuItem, informesToolStripMenuItem });
            sociosToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            sociosToolStripMenuItem.ForeColor = Color.White;
            sociosToolStripMenuItem.Margin = new Padding(5);
            sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            sociosToolStripMenuItem.Size = new Size(143, 29);
            sociosToolStripMenuItem.Text = "Socios";
            sociosToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.ForeColor = Color.FromArgb(81, 45, 168);
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(213, 30);
            administraciónToolStripMenuItem.Text = "Administración";
            administraciónToolStripMenuItem.Click += administraciónToolStripMenuItem_Click;
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.ForeColor = Color.FromArgb(81, 45, 168);
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(213, 30);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.ForeColor = Color.FromArgb(81, 45, 168);
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(213, 30);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // clasesToolStripMenuItem
            // 
            clasesToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            clasesToolStripMenuItem.ForeColor = Color.White;
            clasesToolStripMenuItem.Margin = new Padding(5);
            clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            clasesToolStripMenuItem.Size = new Size(143, 29);
            clasesToolStripMenuItem.Text = "Clases";
            clasesToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // instructoresToolStripMenuItem
            // 
            instructoresToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            instructoresToolStripMenuItem.ForeColor = Color.White;
            instructoresToolStripMenuItem.Margin = new Padding(5);
            instructoresToolStripMenuItem.Name = "instructoresToolStripMenuItem";
            instructoresToolStripMenuItem.Size = new Size(143, 29);
            instructoresToolStripMenuItem.Text = "Instructores";
            instructoresToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            configuraciónToolStripMenuItem.ForeColor = Color.White;
            configuraciónToolStripMenuItem.Margin = new Padding(5);
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(143, 29);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            salirToolStripMenuItem.ForeColor = Color.White;
            salirToolStripMenuItem.Margin = new Padding(5);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(143, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 82);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Black;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(554, 501);
            panelPrincipal.TabIndex = 0;
            // 
            // FrmContenedorPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmContenedorPrincipal";
            Text = "FrmContenedorPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmContenedorPrincipal_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem clasesToolStripMenuItem;
        private ToolStripMenuItem instructoresToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelPrincipal;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}



