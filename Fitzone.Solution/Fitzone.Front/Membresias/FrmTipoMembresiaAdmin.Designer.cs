namespace Fitzone.Front.Membresias
{
    partial class FrmTipoMembresiaAdmin
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
            dataGridView1 = new DataGridView();
            tipoMembresiaBindingSource = new BindingSource(components);
            btnModificar = new ReaLTaiizor.Controls.CyberButton();
            BtnAnular = new ReaLTaiizor.Controls.CyberButton();
            ucBordertd2 = new UserControls.UCBorderTD();
            ucBordertd1 = new UserControls.UCBorderTD();
            ucBorderlr2 = new UserControls.UCBorderLR();
            ucBorderlr1 = new UserControls.UCBorderLR();
            ucTituloLabel1 = new UserControls.UCTituloLabel();
            botonesForms2 = new UserControls.UCBotonesForms();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnAgregar = new ReaLTaiizor.Controls.CyberButton();
            btnConsultar = new ReaLTaiizor.Controls.CyberButton();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            ActividadNombre = new DataGridViewTextBoxColumn();
            InstructorNombreCompleto = new DataGridViewTextBoxColumn();
            horadesde = new DataGridViewTextBoxColumn();
            horaHasta = new DataGridViewTextBoxColumn();
            precioTotal = new DataGridViewTextBoxColumn();
            cantidadDiasSemanales = new DataGridViewTextBoxColumn();
            diasHabilitados = new DataGridViewTextBoxColumn();
            cantidadCuotas = new DataGridViewTextBoxColumn();
            cupoClase = new DataGridViewTextBoxColumn();
            cuotaUnica = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoMembresiaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(81, 45, 168);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, descripcion, ActividadNombre, InstructorNombreCompleto, horadesde, horaHasta, precioTotal, cantidadDiasSemanales, diasHabilitados, cantidadCuotas, cupoClase, cuotaUnica });
            dataGridView1.DataSource = tipoMembresiaBindingSource;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(9, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Size = new Size(1075, 378);
            dataGridView1.TabIndex = 69;
            // 
            // tipoMembresiaBindingSource
            // 
            tipoMembresiaBindingSource.DataSource = typeof(Entidades.TipoMembresia);
            // 
            // btnModificar
            // 
            btnModificar.Alpha = 20;
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.BackColor = Color.Transparent;
            btnModificar.Background = true;
            btnModificar.Background_WidthPen = 4F;
            btnModificar.BackgroundPen = true;
            btnModificar.ColorBackground = Color.Black;
            btnModificar.ColorBackground_1 = Color.Black;
            btnModificar.ColorBackground_2 = Color.Gray;
            btnModificar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnModificar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnModificar.ColorPen_1 = Color.Black;
            btnModificar.ColorPen_2 = Color.Gray;
            btnModificar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnModificar.Effect_1 = true;
            btnModificar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnModificar.Effect_1_Transparency = 25;
            btnModificar.Effect_2 = true;
            btnModificar.Effect_2_ColorBackground = Color.White;
            btnModificar.Effect_2_Transparency = 20;
            btnModificar.Font = new Font("Arial", 11F);
            btnModificar.ForeColor = Color.FromArgb(245, 245, 245);
            btnModificar.Lighting = false;
            btnModificar.LinearGradient_Background = false;
            btnModificar.LinearGradientPen = false;
            btnModificar.Location = new Point(115, 441);
            btnModificar.Name = "btnModificar";
            btnModificar.PenWidth = 15;
            btnModificar.Rounding = true;
            btnModificar.RoundingInt = 70;
            btnModificar.Size = new Size(99, 40);
            btnModificar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnModificar.TabIndex = 79;
            btnModificar.Tag = "Cyber";
            btnModificar.TextButton = "Modificar";
            btnModificar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnModificar.Timer_Effect_1 = 5;
            btnModificar.Timer_RGB = 300;
            btnModificar.Click += btnModificar_Click;
            // 
            // BtnAnular
            // 
            BtnAnular.Alpha = 20;
            BtnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnular.BackColor = Color.Transparent;
            BtnAnular.Background = true;
            BtnAnular.Background_WidthPen = 4F;
            BtnAnular.BackgroundPen = true;
            BtnAnular.ColorBackground = Color.Black;
            BtnAnular.ColorBackground_1 = Color.Black;
            BtnAnular.ColorBackground_2 = Color.Gray;
            BtnAnular.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            BtnAnular.ColorLighting = Color.FromArgb(81, 45, 168);
            BtnAnular.ColorPen_1 = Color.Black;
            BtnAnular.ColorPen_2 = Color.Gray;
            BtnAnular.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnAnular.Effect_1 = true;
            BtnAnular.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            BtnAnular.Effect_1_Transparency = 25;
            BtnAnular.Effect_2 = true;
            BtnAnular.Effect_2_ColorBackground = Color.White;
            BtnAnular.Effect_2_Transparency = 20;
            BtnAnular.Font = new Font("Arial", 11F);
            BtnAnular.ForeColor = Color.FromArgb(245, 245, 245);
            BtnAnular.Lighting = false;
            BtnAnular.LinearGradient_Background = false;
            BtnAnular.LinearGradientPen = false;
            BtnAnular.Location = new Point(310, 441);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.PenWidth = 15;
            BtnAnular.Rounding = true;
            BtnAnular.RoundingInt = 70;
            BtnAnular.Size = new Size(99, 40);
            BtnAnular.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnAnular.TabIndex = 71;
            BtnAnular.Tag = "Cyber";
            BtnAnular.TextButton = "Anular";
            BtnAnular.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnAnular.Timer_Effect_1 = 5;
            BtnAnular.Timer_RGB = 300;
            // 
            // ucBordertd2
            // 
            ucBordertd2.BackColor = Color.White;
            ucBordertd2.Dock = DockStyle.Bottom;
            ucBordertd2.Location = new Point(2, 487);
            ucBordertd2.Name = "ucBordertd2";
            ucBordertd2.Size = new Size(1091, 3);
            ucBordertd2.TabIndex = 76;
            // 
            // ucBordertd1
            // 
            ucBordertd1.BackColor = Color.White;
            ucBordertd1.Dock = DockStyle.Top;
            ucBordertd1.Location = new Point(2, 0);
            ucBordertd1.Name = "ucBordertd1";
            ucBordertd1.Size = new Size(1091, 3);
            ucBordertd1.TabIndex = 75;
            // 
            // ucBorderlr2
            // 
            ucBorderlr2.BackColor = Color.White;
            ucBorderlr2.Dock = DockStyle.Right;
            ucBorderlr2.Location = new Point(1093, 0);
            ucBorderlr2.Name = "ucBorderlr2";
            ucBorderlr2.Size = new Size(2, 490);
            ucBorderlr2.TabIndex = 74;
            // 
            // ucBorderlr1
            // 
            ucBorderlr1.BackColor = Color.White;
            ucBorderlr1.Dock = DockStyle.Left;
            ucBorderlr1.Location = new Point(0, 0);
            ucBorderlr1.Name = "ucBorderlr1";
            ucBorderlr1.Size = new Size(2, 490);
            ucBorderlr1.TabIndex = 73;
            // 
            // ucTituloLabel1
            // 
            ucTituloLabel1._titulo = "Administrar tipos de membresía";
            ucTituloLabel1.BackColor = Color.FromArgb(103, 58, 183);
            ucTituloLabel1.Location = new Point(8, 12);
            ucTituloLabel1.Name = "ucTituloLabel1";
            ucTituloLabel1.Size = new Size(289, 34);
            ucTituloLabel1.TabIndex = 72;
            // 
            // botonesForms2
            // 
            botonesForms2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms2.BackColor = Color.Transparent;
            botonesForms2.Location = new Point(1037, 7);
            botonesForms2.Name = "botonesForms2";
            botonesForms2.Size = new Size(46, 20);
            botonesForms2.TabIndex = 67;
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
            btnCancelar.Location = new Point(992, 441);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(99, 40);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 68;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Salir";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Alpha = 20;
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.Background = true;
            btnAgregar.Background_WidthPen = 4F;
            btnAgregar.BackgroundPen = true;
            btnAgregar.ColorBackground = Color.Black;
            btnAgregar.ColorBackground_1 = Color.Black;
            btnAgregar.ColorBackground_2 = Color.Gray;
            btnAgregar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnAgregar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnAgregar.ColorPen_1 = Color.Black;
            btnAgregar.ColorPen_2 = Color.Gray;
            btnAgregar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAgregar.Effect_1 = true;
            btnAgregar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnAgregar.Effect_1_Transparency = 25;
            btnAgregar.Effect_2 = true;
            btnAgregar.Effect_2_ColorBackground = Color.White;
            btnAgregar.Effect_2_Transparency = 20;
            btnAgregar.Font = new Font("Arial", 11F);
            btnAgregar.ForeColor = Color.FromArgb(245, 245, 245);
            btnAgregar.Lighting = false;
            btnAgregar.LinearGradient_Background = false;
            btnAgregar.LinearGradientPen = false;
            btnAgregar.Location = new Point(18, 441);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.PenWidth = 15;
            btnAgregar.Rounding = true;
            btnAgregar.RoundingInt = 70;
            btnAgregar.Size = new Size(99, 40);
            btnAgregar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAgregar.TabIndex = 70;
            btnAgregar.Tag = "Cyber";
            btnAgregar.TextButton = "Agregar";
            btnAgregar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAgregar.Timer_Effect_1 = 5;
            btnAgregar.Timer_RGB = 300;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Alpha = 20;
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConsultar.BackColor = Color.Transparent;
            btnConsultar.Background = true;
            btnConsultar.Background_WidthPen = 4F;
            btnConsultar.BackgroundPen = true;
            btnConsultar.ColorBackground = Color.Black;
            btnConsultar.ColorBackground_1 = Color.Black;
            btnConsultar.ColorBackground_2 = Color.Gray;
            btnConsultar.ColorBackground_Pen = Color.FromArgb(81, 45, 168);
            btnConsultar.ColorLighting = Color.FromArgb(81, 45, 168);
            btnConsultar.ColorPen_1 = Color.Black;
            btnConsultar.ColorPen_2 = Color.Gray;
            btnConsultar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnConsultar.Effect_1 = true;
            btnConsultar.Effect_1_ColorBackground = Color.FromArgb(81, 45, 168);
            btnConsultar.Effect_1_Transparency = 25;
            btnConsultar.Effect_2 = true;
            btnConsultar.Effect_2_ColorBackground = Color.White;
            btnConsultar.Effect_2_Transparency = 20;
            btnConsultar.Font = new Font("Arial", 11F);
            btnConsultar.ForeColor = Color.FromArgb(245, 245, 245);
            btnConsultar.Lighting = false;
            btnConsultar.LinearGradient_Background = false;
            btnConsultar.LinearGradientPen = false;
            btnConsultar.Location = new Point(213, 441);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.PenWidth = 15;
            btnConsultar.Rounding = true;
            btnConsultar.RoundingInt = 70;
            btnConsultar.Size = new Size(99, 40);
            btnConsultar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConsultar.TabIndex = 81;
            btnConsultar.Tag = "Cyber";
            btnConsultar.TextButton = "Consultar";
            btnConsultar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConsultar.Timer_Effect_1 = 5;
            btnConsultar.Timer_RGB = 300;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 150;
            // 
            // ActividadNombre
            // 
            ActividadNombre.DataPropertyName = "ActividadNombre";
            ActividadNombre.HeaderText = "Actividad";
            ActividadNombre.Name = "ActividadNombre";
            ActividadNombre.ReadOnly = true;
            // 
            // InstructorNombreCompleto
            // 
            InstructorNombreCompleto.DataPropertyName = "InstructorNombreCompleto";
            InstructorNombreCompleto.HeaderText = "Instructor";
            InstructorNombreCompleto.Name = "InstructorNombreCompleto";
            InstructorNombreCompleto.ReadOnly = true;
            // 
            // horadesde
            // 
            horadesde.DataPropertyName = "HoraDesdeString";
            horadesde.HeaderText = "Desde";
            horadesde.Name = "horadesde";
            horadesde.ReadOnly = true;
            horadesde.Width = 50;
            // 
            // horaHasta
            // 
            horaHasta.DataPropertyName = "HoraHastaString";
            horaHasta.HeaderText = "Hasta";
            horaHasta.Name = "horaHasta";
            horaHasta.ReadOnly = true;
            horaHasta.Width = 50;
            // 
            // precioTotal
            // 
            precioTotal.DataPropertyName = "precioTotal";
            precioTotal.HeaderText = "Precio";
            precioTotal.Name = "precioTotal";
            precioTotal.ReadOnly = true;
            precioTotal.Width = 70;
            // 
            // cantidadDiasSemanales
            // 
            cantidadDiasSemanales.DataPropertyName = "cantidadDiasSemanales";
            cantidadDiasSemanales.HeaderText = "Cant Dias";
            cantidadDiasSemanales.Name = "cantidadDiasSemanales";
            cantidadDiasSemanales.ReadOnly = true;
            cantidadDiasSemanales.Width = 50;
            // 
            // diasHabilitados
            // 
            diasHabilitados.DataPropertyName = "diasHabilitados";
            diasHabilitados.HeaderText = "Dias Habilitados";
            diasHabilitados.Name = "diasHabilitados";
            diasHabilitados.ReadOnly = true;
            // 
            // cantidadCuotas
            // 
            cantidadCuotas.DataPropertyName = "cantidadCuotas";
            cantidadCuotas.HeaderText = "Cant Meses";
            cantidadCuotas.Name = "cantidadCuotas";
            cantidadCuotas.ReadOnly = true;
            cantidadCuotas.Width = 50;
            // 
            // cupoClase
            // 
            cupoClase.DataPropertyName = "cupoClase";
            cupoClase.HeaderText = "Cupo";
            cupoClase.Name = "cupoClase";
            cupoClase.ReadOnly = true;
            cupoClase.Width = 50;
            // 
            // cuotaUnica
            // 
            cuotaUnica.DataPropertyName = "cuotaUnica";
            cuotaUnica.HeaderText = "Cuota Unica";
            cuotaUnica.Name = "cuotaUnica";
            cuotaUnica.ReadOnly = true;
            // 
            // FrmTipoMembresiaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 58, 183);
            ClientSize = new Size(1095, 490);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(BtnAnular);
            Controls.Add(ucBordertd2);
            Controls.Add(ucBordertd1);
            Controls.Add(ucBorderlr2);
            Controls.Add(ucBorderlr1);
            Controls.Add(ucTituloLabel1);
            Controls.Add(botonesForms2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTipoMembresiaAdmin";
            Text = "FrmTipoMembresiaAdmin";
            Load += FrmTipoMembresiaAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoMembresiaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.CyberButton btnModificar;
        private ReaLTaiizor.Controls.CyberButton BtnAnular;
        private UserControls.UCBorderTD ucBordertd2;
        private UserControls.UCBorderTD ucBordertd1;
        private UserControls.UCBorderLR ucBorderlr2;
        private UserControls.UCBorderLR ucBorderlr1;
        private UserControls.UCTituloLabel ucTituloLabel1;
        private UserControls.UCBotonesForms botonesForms2;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnAgregar;
        private ReaLTaiizor.Controls.CyberButton btnConsultar;
        private BindingSource tipoMembresiaBindingSource;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn ActividadNombre;
        private DataGridViewTextBoxColumn InstructorNombreCompleto;
        private DataGridViewTextBoxColumn horadesde;
        private DataGridViewTextBoxColumn horaHasta;
        private DataGridViewTextBoxColumn precioTotal;
        private DataGridViewTextBoxColumn cantidadDiasSemanales;
        private DataGridViewTextBoxColumn diasHabilitados;
        private DataGridViewTextBoxColumn cantidadCuotas;
        private DataGridViewTextBoxColumn cupoClase;
        private DataGridViewCheckBoxColumn cuotaUnica;
    }
}