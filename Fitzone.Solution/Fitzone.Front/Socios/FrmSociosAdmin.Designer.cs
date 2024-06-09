namespace Fitzone.Front.Socios
{
    partial class FrmSociosAdmin
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
            components = new System.ComponentModel.Container();
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            dataGridView1 = new DataGridView();
            idSocioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefono2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDocumentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calleNumeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBarrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barrioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anuladoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bindingSource1 = new BindingSource(components);
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAceptar = new ReaLTaiizor.Controls.CyberButton();
            btnFiltrar = new ReaLTaiizor.Controls.CyberButton();
            aloneTextBox3 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            aloneTextBox2 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            botonesForms2 = new UserControls.BotonesForms();
            thunderForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BackColor = Color.FromArgb(255, 192, 128);
            thunderForm1.BodyColorA = Color.Black;
            thunderForm1.BodyColorB = Color.Black;
            thunderForm1.BodyColorC = Color.FromArgb(103, 58, 183);
            thunderForm1.BodyColorD = Color.FromArgb(133, 110, 183);
            thunderForm1.Controls.Add(cyberButton3);
            thunderForm1.Controls.Add(cyberButton2);
            thunderForm1.Controls.Add(cyberButton1);
            thunderForm1.Controls.Add(dataGridView1);
            thunderForm1.Controls.Add(btnCancelar);
            thunderForm1.Controls.Add(btnAceptar);
            thunderForm1.Controls.Add(btnFiltrar);
            thunderForm1.Controls.Add(aloneTextBox3);
            thunderForm1.Controls.Add(thunderLabel3);
            thunderForm1.Controls.Add(aloneTextBox2);
            thunderForm1.Controls.Add(thunderLabel2);
            thunderForm1.Controls.Add(aloneTextBox1);
            thunderForm1.Controls.Add(thunderLabel1);
            thunderForm1.Controls.Add(botonesForms2);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(847, 483);
            thunderForm1.TabIndex = 1;
            thunderForm1.Text = "Adminstración de socios";
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 4F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.Black;
            cyberButton3.ColorBackground_1 = Color.Black;
            cyberButton3.ColorBackground_2 = Color.Gray;
            cyberButton3.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cyberButton3.ColorLighting = Color.FromArgb(81, 45, 168);
            cyberButton3.ColorPen_1 = Color.Black;
            cyberButton3.ColorPen_2 = Color.Gray;
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Arial", 11F);
            cyberButton3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(132, 431);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(99, 40);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 23;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Modificar";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.Black;
            cyberButton2.ColorBackground_1 = Color.Black;
            cyberButton2.ColorBackground_2 = Color.Gray;
            cyberButton2.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cyberButton2.ColorLighting = Color.FromArgb(81, 45, 168);
            cyberButton2.ColorPen_1 = Color.Black;
            cyberButton2.ColorPen_2 = Color.Gray;
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(244, 431);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(99, 40);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 22;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Eliminar";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.Black;
            cyberButton1.ColorBackground_1 = Color.Black;
            cyberButton1.ColorBackground_2 = Color.Gray;
            cyberButton1.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            cyberButton1.ColorLighting = Color.FromArgb(81, 45, 168);
            cyberButton1.ColorPen_1 = Color.Black;
            cyberButton1.ColorPen_2 = Color.Gray;
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(27, 431);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(99, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 21;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Agregar";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(81, 45, 168);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idSocioDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, numeroDocumentoDataGridViewTextBoxColumn, telefono1DataGridViewTextBoxColumn, telefono2DataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, tipoDocumentoDataGridViewTextBoxColumn, calleDataGridViewTextBoxColumn, calleNumeroDataGridViewTextBoxColumn, idBarrioDataGridViewTextBoxColumn, barrioDataGridViewTextBoxColumn, anuladoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(20, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(813, 268);
            dataGridView1.TabIndex = 20;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            idSocioDataGridViewTextBoxColumn.HeaderText = "idSocio";
            idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            idSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "numeroDocumento";
            numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "numeroDocumento";
            numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1";
            telefono1DataGridViewTextBoxColumn.HeaderText = "telefono1";
            telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2";
            telefono2DataGridViewTextBoxColumn.HeaderText = "telefono2";
            telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "mail";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipoDocumento";
            tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "tipoDocumento";
            tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            calleDataGridViewTextBoxColumn.HeaderText = "calle";
            calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            calleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calleNumeroDataGridViewTextBoxColumn
            // 
            calleNumeroDataGridViewTextBoxColumn.DataPropertyName = "calleNumero";
            calleNumeroDataGridViewTextBoxColumn.HeaderText = "calleNumero";
            calleNumeroDataGridViewTextBoxColumn.Name = "calleNumeroDataGridViewTextBoxColumn";
            calleNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idBarrioDataGridViewTextBoxColumn
            // 
            idBarrioDataGridViewTextBoxColumn.DataPropertyName = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.HeaderText = "idBarrio";
            idBarrioDataGridViewTextBoxColumn.Name = "idBarrioDataGridViewTextBoxColumn";
            idBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            barrioDataGridViewTextBoxColumn.DataPropertyName = "Barrio";
            barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            barrioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            anuladoDataGridViewCheckBoxColumn.DataPropertyName = "anulado";
            anuladoDataGridViewCheckBoxColumn.HeaderText = "anulado";
            anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Entidades.Socio);
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.Black;
            btnCancelar.ColorBackground_1 = Color.Black;
            btnCancelar.ColorBackground_2 = Color.Gray;
            btnCancelar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnCancelar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnCancelar.ColorPen_1 = Color.Black;
            btnCancelar.ColorPen_2 = Color.Gray;
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(734, 431);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 19;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            // 
            // btnAceptar
            // 
            btnAceptar.Alpha = 20;
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.Background = true;
            btnAceptar.Background_WidthPen = 4F;
            btnAceptar.BackgroundPen = true;
            btnAceptar.ColorBackground = Color.Black;
            btnAceptar.ColorBackground_1 = Color.Black;
            btnAceptar.ColorBackground_2 = Color.Gray;
            btnAceptar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnAceptar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnAceptar.ColorPen_1 = Color.Black;
            btnAceptar.ColorPen_2 = Color.Gray;
            btnAceptar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAceptar.Effect_1 = true;
            btnAceptar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnAceptar.Effect_1_Transparency = 25;
            btnAceptar.Effect_2 = true;
            btnAceptar.Effect_2_ColorBackground = Color.White;
            btnAceptar.Effect_2_Transparency = 20;
            btnAceptar.Font = new Font("Arial", 11F);
            btnAceptar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAceptar.Lighting = false;
            btnAceptar.LinearGradient_Background = false;
            btnAceptar.LinearGradientPen = false;
            btnAceptar.Location = new Point(629, 431);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.PenWidth = 15;
            btnAceptar.Rounding = true;
            btnAceptar.RoundingInt = 70;
            btnAceptar.Size = new Size(99, 40);
            btnAceptar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAceptar.TabIndex = 18;
            btnAceptar.Tag = "Cyber";
            btnAceptar.TextButton = "Aceptar";
            btnAceptar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAceptar.Timer_Effect_1 = 5;
            btnAceptar.Timer_RGB = 300;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Alpha = 20;
            btnFiltrar.BackColor = Color.Transparent;
            btnFiltrar.Background = true;
            btnFiltrar.Background_WidthPen = 4F;
            btnFiltrar.BackgroundPen = true;
            btnFiltrar.ColorBackground = Color.Black;
            btnFiltrar.ColorBackground_1 = Color.Black;
            btnFiltrar.ColorBackground_2 = Color.Gray;
            btnFiltrar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnFiltrar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnFiltrar.ColorPen_1 = Color.Black;
            btnFiltrar.ColorPen_2 = Color.Gray;
            btnFiltrar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnFiltrar.Effect_1 = true;
            btnFiltrar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnFiltrar.Effect_1_Transparency = 25;
            btnFiltrar.Effect_2 = true;
            btnFiltrar.Effect_2_ColorBackground = Color.White;
            btnFiltrar.Effect_2_Transparency = 20;
            btnFiltrar.Font = new Font("Arial", 11F);
            btnFiltrar.ForeColor = Color.FromArgb(245, 245, 245);
            btnFiltrar.Lighting = false;
            btnFiltrar.LinearGradient_Background = false;
            btnFiltrar.LinearGradientPen = false;
            btnFiltrar.Location = new Point(20, 111);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.PenWidth = 15;
            btnFiltrar.Rounding = true;
            btnFiltrar.RoundingInt = 70;
            btnFiltrar.Size = new Size(99, 40);
            btnFiltrar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFiltrar.TabIndex = 17;
            btnFiltrar.Tag = "Cyber";
            btnFiltrar.TextButton = "Filtrar";
            btnFiltrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFiltrar.Timer_Effect_1 = 5;
            btnFiltrar.Timer_RGB = 300;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // aloneTextBox3
            // 
            aloneTextBox3.BackColor = Color.Transparent;
            aloneTextBox3.EnabledCalc = true;
            aloneTextBox3.Font = new Font("Segoe UI", 9F);
            aloneTextBox3.ForeColor = Color.Black;
            aloneTextBox3.Location = new Point(421, 45);
            aloneTextBox3.MaxLength = 32767;
            aloneTextBox3.MultiLine = false;
            aloneTextBox3.Name = "aloneTextBox3";
            aloneTextBox3.ReadOnly = false;
            aloneTextBox3.Size = new Size(233, 29);
            aloneTextBox3.TabIndex = 15;
            aloneTextBox3.TextAlign = HorizontalAlignment.Left;
            aloneTextBox3.UseSystemPasswordChar = false;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(321, 54);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(109, 16);
            thunderLabel3.TabIndex = 14;
            thunderLabel3.Text = "Nro. Documento";
            // 
            // aloneTextBox2
            // 
            aloneTextBox2.BackColor = Color.Transparent;
            aloneTextBox2.EnabledCalc = true;
            aloneTextBox2.Font = new Font("Segoe UI", 9F);
            aloneTextBox2.ForeColor = Color.Black;
            aloneTextBox2.Location = new Point(81, 76);
            aloneTextBox2.MaxLength = 32767;
            aloneTextBox2.MultiLine = false;
            aloneTextBox2.Name = "aloneTextBox2";
            aloneTextBox2.ReadOnly = false;
            aloneTextBox2.Size = new Size(233, 29);
            aloneTextBox2.TabIndex = 13;
            aloneTextBox2.TextAlign = HorizontalAlignment.Left;
            aloneTextBox2.UseSystemPasswordChar = false;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(20, 85);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(96, 16);
            thunderLabel2.TabIndex = 12;
            thunderLabel2.Text = "Apellido";
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.Black;
            aloneTextBox1.Location = new Point(81, 45);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(233, 29);
            aloneTextBox1.TabIndex = 6;
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(20, 54);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(96, 16);
            thunderLabel1.TabIndex = 2;
            thunderLabel1.Text = "Nombre";
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(771, 5);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(69, 20);
            botonesForms2.TabIndex = 1;
            // 
            // FrmSociosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 483);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSociosAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSociosConsulta";
            TransparencyKey = Color.Fuchsia;
            Load += FrmSociosAdmin_Load;
            thunderForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private UserControls.BotonesForms botonesForms2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox3;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAceptar;
        private ReaLTaiizor.Controls.CyberButton btnFiltrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleNumeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}