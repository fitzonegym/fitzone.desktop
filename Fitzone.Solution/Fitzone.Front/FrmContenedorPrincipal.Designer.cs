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
            toolStripStatusLabelUsuario = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            sociosToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            membresíaToolStripMenuItem = new ToolStripMenuItem();
            admnistraciónToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem1 = new ToolStripMenuItem();
            facturaStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem1 = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            tipoDeMembresíaToolStripMenuItem = new ToolStripMenuItem();
            instructoresToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            controlDeAccesosToolStripMenuItem = new ToolStripMenuItem();
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
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuario });
            statusStrip.Location = new Point(0, 645);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1197, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabelUsuario
            // 
            toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            toolStripStatusLabelUsuario.Size = new Size(42, 17);
            toolStripStatusLabelUsuario.Text = "Estado";
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
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelPrincipal);
            splitContainer1.Size = new Size(1197, 645);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 563);
            panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(103, 58, 183);
            flowLayoutPanel1.BackgroundImage = Properties.Resources.fondovioleta;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Controls.Add(menuStrip1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 563);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { sociosToolStripMenuItem, membresíaToolStripMenuItem, facturaStripMenuItem, configuraciónToolStripMenuItem, controlDeAccesosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(191, 240);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            sociosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administraciónToolStripMenuItem, altaToolStripMenuItem });
            sociosToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            sociosToolStripMenuItem.ForeColor = Color.Black;
            sociosToolStripMenuItem.Margin = new Padding(5);
            sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            sociosToolStripMenuItem.Size = new Size(174, 29);
            sociosToolStripMenuItem.Text = "Socios";
            sociosToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.BackColor = Color.FromArgb(81, 45, 168);
            administraciónToolStripMenuItem.ForeColor = Color.White;
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(213, 30);
            administraciónToolStripMenuItem.Text = "Administración";
            administraciónToolStripMenuItem.Click += administraciónToolStripMenuItem_Click;
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.BackColor = Color.FromArgb(81, 45, 168);
            altaToolStripMenuItem.ForeColor = Color.White;
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(213, 30);
            altaToolStripMenuItem.Text = "Agregar";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // membresíaToolStripMenuItem
            // 
            membresíaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { admnistraciónToolStripMenuItem, altaToolStripMenuItem1 });
            membresíaToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            membresíaToolStripMenuItem.Margin = new Padding(5);
            membresíaToolStripMenuItem.Name = "membresíaToolStripMenuItem";
            membresíaToolStripMenuItem.Size = new Size(174, 29);
            membresíaToolStripMenuItem.Text = "Membresía";
            membresíaToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // admnistraciónToolStripMenuItem
            // 
            admnistraciónToolStripMenuItem.BackColor = Color.FromArgb(81, 45, 168);
            admnistraciónToolStripMenuItem.ForeColor = Color.White;
            admnistraciónToolStripMenuItem.Name = "admnistraciónToolStripMenuItem";
            admnistraciónToolStripMenuItem.Size = new Size(208, 30);
            admnistraciónToolStripMenuItem.Text = "Admnistración";
            admnistraciónToolStripMenuItem.Click += admnistraciónToolStripMenuItem_Click;
            // 
            // altaToolStripMenuItem1
            // 
            altaToolStripMenuItem1.BackColor = Color.FromArgb(81, 45, 168);
            altaToolStripMenuItem1.ForeColor = Color.White;
            altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            altaToolStripMenuItem1.Size = new Size(208, 30);
            altaToolStripMenuItem1.Text = "Agregar";
            altaToolStripMenuItem1.Click += altaToolStripMenuItem1_Click;
            // 
            // facturaStripMenuItem
            // 
            facturaStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administraciónToolStripMenuItem1 });
            facturaStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            facturaStripMenuItem.Margin = new Padding(5);
            facturaStripMenuItem.Name = "facturaStripMenuItem";
            facturaStripMenuItem.Size = new Size(174, 29);
            facturaStripMenuItem.Text = "Facturas";
            facturaStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // administraciónToolStripMenuItem1
            // 
            administraciónToolStripMenuItem1.BackColor = Color.FromArgb(81, 45, 168);
            administraciónToolStripMenuItem1.ForeColor = Color.White;
            administraciónToolStripMenuItem1.Name = "administraciónToolStripMenuItem1";
            administraciónToolStripMenuItem1.Size = new Size(213, 30);
            administraciónToolStripMenuItem1.Text = "Administración";
            administraciónToolStripMenuItem1.Click += administraciónToolStripMenuItem1_Click_1;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tipoDeMembresíaToolStripMenuItem, instructoresToolStripMenuItem1, usuariosToolStripMenuItem });
            configuraciónToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            configuraciónToolStripMenuItem.ForeColor = Color.Black;
            configuraciónToolStripMenuItem.Margin = new Padding(5);
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(174, 29);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tipoDeMembresíaToolStripMenuItem
            // 
            tipoDeMembresíaToolStripMenuItem.BackColor = Color.FromArgb(81, 45, 168);
            tipoDeMembresíaToolStripMenuItem.ForeColor = Color.White;
            tipoDeMembresíaToolStripMenuItem.Name = "tipoDeMembresíaToolStripMenuItem";
            tipoDeMembresíaToolStripMenuItem.Size = new Size(246, 30);
            tipoDeMembresíaToolStripMenuItem.Text = "Tipo de membresía";
            tipoDeMembresíaToolStripMenuItem.Click += tipoDeMembresíaToolStripMenuItem_Click;
            // 
            // instructoresToolStripMenuItem1
            // 
            instructoresToolStripMenuItem1.BackColor = Color.FromArgb(81, 45, 168);
            instructoresToolStripMenuItem1.ForeColor = Color.White;
            instructoresToolStripMenuItem1.Name = "instructoresToolStripMenuItem1";
            instructoresToolStripMenuItem1.Size = new Size(246, 30);
            instructoresToolStripMenuItem1.Text = "Instructores";
            instructoresToolStripMenuItem1.Click += instructoresToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(81, 45, 168);
            usuariosToolStripMenuItem.ForeColor = Color.White;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(246, 30);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // controlDeAccesosToolStripMenuItem
            // 
            controlDeAccesosToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            controlDeAccesosToolStripMenuItem.Margin = new Padding(5);
            controlDeAccesosToolStripMenuItem.Name = "controlDeAccesosToolStripMenuItem";
            controlDeAccesosToolStripMenuItem.Padding = new Padding(0);
            controlDeAccesosToolStripMenuItem.Size = new Size(174, 29);
            controlDeAccesosToolStripMenuItem.Text = "Control de accesos";
            controlDeAccesosToolStripMenuItem.Click += controlDeAccesosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            salirToolStripMenuItem.ForeColor = Color.Black;
            salirToolStripMenuItem.Margin = new Padding(5);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Padding = new Padding(0);
            salirToolStripMenuItem.Size = new Size(174, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 45, 168);
            panel1.BackgroundImage = Properties.Resources.fondovioleta;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(200, 82);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.fondovioleta;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.logo3;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(202, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += panelPrincipal_DoubleClick;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.MediumPurple;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(993, 645);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            panelPrincipal.DoubleClick += panelPrincipal_DoubleClick;
            panelPrincipal.MouseDown += panelPrincipal_MouseDown;
            // 
            // FrmContenedorPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 667);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelPrincipal;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem membresíaToolStripMenuItem;
        private ToolStripMenuItem admnistraciónToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem1;
        private ToolStripMenuItem tipoDeMembresíaToolStripMenuItem;
        private ToolStripMenuItem controlDeAccesosToolStripMenuItem;
        private ToolStripMenuItem instructoresToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem facturaStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem1;
    }
}



