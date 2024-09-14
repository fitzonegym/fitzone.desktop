using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using IContainer = QuestPDF.Infrastructure.IContainer;
using System.Diagnostics;
using ReaLTaiizor.Controls;
using Fitzone.Front.Membresias;


namespace Fitzone.Front.Socios
{
    public partial class FrmSociosAdmin : Form
    {
        List<Socio> _listaSocios = new List<Socio>();
        public Socio? _SocioSeleccionado = null;
        public EnumModoFormulario _EnumModoFormulario = EnumModoFormulario.Administracion;

        bool primeraCarga = true;

        string ordenadoPor = "";

        #region redimensionar

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int BORDER_SIZE = 15; // Tamaño de los bordes para redimensionar
                                            //   // Funciones necesarias para permitir el movimiento del formulario
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x84) // WM_NCHITTEST
            {
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X < BORDER_SIZE && cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X < BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X < BORDER_SIZE)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X > this.ClientSize.Width - BORDER_SIZE)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y < BORDER_SIZE)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }
        public void OnMouseDownForm(MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Permitir que el formulario se mueva cuando el usuario lo arrastre
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public FrmSociosAdmin()
        {
            InitializeComponent();
            txtNombre.TB.KeyPress += txtCualquierFiltro_KeyPress;
            txtApellido.TB.KeyPress += txtCualquierFiltro_KeyPress;
            txtDocumento.TB.KeyPress += txtCualquierFiltro_KeyPress;
        }
        private void VisibleBotones(bool visible)
        {
            btnAceptar.Visible = btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnMembresía.Visible = btnConsultar.Visible = btnCuota.Visible = visible;
        }

        private void LimpiarFiltros()
        {
            txtFechaDesde.Checked = true;
            txtFechaHasta.Checked = true;
            txtFechaDesde.Value = Statics.DateTimeNowSinHora().AddMonths(-6);
            txtFechaHasta.Value = Statics.DateTimeNow235959();
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
        }

        private void FrmSociosAdmin_Load(object sender, EventArgs e)
        {
            VisibleBotones(false);

            LimpiarFiltros();

            //txtFechaDesde.Checked = false;
            //txtFechaHasta.Checked = false;

            // this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (_EnumModoFormulario == EnumModoFormulario.Consulta)
            {
                btnAceptar.Visible = true;
                btnCancelar.Visible = true;
                // btnAceptar.Location = btnCancelar.Location;
                // CargarGrilla();
            }
            if (_EnumModoFormulario == EnumModoFormulario.Administracion)
            {
                //   btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnAnular.Visible = btnConsultar.Visible = btnCuota.Visible = true;
                VisibleBotones(true);
                btnAceptar.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }

            //dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);
            CargarGrilla();
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //    DataGridView dataGridView = sender as DataGridView;

            //    if (e.RowIndex % 2 == 0) // Si es una fila par
            //    {
            //        dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(209, 196, 234); // Cambia el color de fondo
            //    }
        }

        private void CargarGrilla()
        {
            Statics.WaitShow();
            SocioController c = new SocioController();

            Socio filter = new Socio();

            filter.nombre = txtNombre.Text;
            filter.apellido = txtApellido.Text;
            filter.numeroDocumento = txtDocumento.Text;

            _listaSocios = c.GetAll(filter, txtFechaDesde.Checked ? txtFechaDesde.Value : null, txtFechaHasta.Checked ? txtFechaHasta.Value : null);

            bindingSource1.DataSource = null;
            bindingSource1.DataSource = _listaSocios;

            ucCantidadregistros1._cantidad = _listaSocios.Count();

            if (_listaSocios.Count == 0 && !primeraCarga)
            {
                new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.NoSeEncontraronDatos).ShowDialog();
                return;
            }

            //dataGridView1.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }



            primeraCarga = false;

            Statics.WaitHide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();



        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Alta;
            frmSociosAlta._id_socio = 0;

            frmSociosAlta.ShowDialog();

            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _SocioSeleccionado = null;
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            //return;

            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Modificacion;

            frmSociosAlta._id_socio = ((Socio)bindingSource1.Current).idSocio;

            frmSociosAlta.ShowDialog();

            CargarGrilla();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            _SocioSeleccionado = ((Socio)bindingSource1.Current);
            Close();
        }

        private void txtCualquierFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarGrilla();
                // Prevenir el sonido de beep
                e.Handled = true;

            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (_EnumModoFormulario != EnumModoFormulario.Consulta)
                return;

            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            _SocioSeleccionado = ((Socio)bindingSource1.Current);
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //CargarGrilla();
            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("ReporteSocios", "PDF");
            string filtrosAplicados = "\nFiltros: ";

            filtrosAplicados += "\nNombre: " + (txtNombre.Text.IsNullOrEmpty() ? "Todos" : txtNombre.Text);
            filtrosAplicados += "\nApellido: " + (txtApellido.Text.IsNullOrEmpty() ? "Todos" : txtApellido.Text);
            filtrosAplicados += "\nNro Doc: " + (txtDocumento.Text.IsNullOrEmpty() ? "Todos" : txtDocumento.Text);
            filtrosAplicados += "\nAlta desde: " + (!txtFechaDesde.Checked ? "Todos" : txtFechaDesde.Value.ToShortDateString());
            filtrosAplicados += "\nAlta hasta: " + (!txtFechaHasta.Checked ? "Todos" : txtFechaHasta.Value.ToShortDateString());

            if (!String.IsNullOrWhiteSpace(ordenadoPor))
                filtrosAplicados += "\nOrdenado por: " + ordenadoPor;

            // code in your main method
            // Datos de ejemplo para la tabla
            var data = _listaSocios;
            // Ruta de la imagen para el encabezado

            System.Drawing.Image im = Fitzone.Front.Properties.Resources.logo3;
            var logo = Fitzone.Front.Statics.ImageToByteArray(im);

            // Crear el documento PDF
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(8))
                    ;

                    page.Header()
                    .Background(Colors.White) // Asegurar que el fondo del encabezado sea blanco
                    .Padding(5)
                    .Element(ComposeHeader(logo, filtrosAplicados));

                    /*page.Header()                    
                        .Text("Informe de Socios")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium)
                        ;
                    */
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Table(table =>
                        {
                            // Definir columnas de la tabla
                            table.ColumnsDefinition(columns =>
                            {   //columns.RelativeColumn();

                                columns.ConstantColumn(25);//id
                                columns.ConstantColumn(90);//nombre
                                columns.ConstantColumn(60);//doc
                                columns.ConstantColumn(50);//tel
                                columns.ConstantColumn(70);//mail
                                columns.ConstantColumn(90);//barrio
                                columns.ConstantColumn(70);//alta
                            });

                            // Encabezados de la tabla
                            table.Header(header =>
                            {

                                header.Cell().Element(CellStyle).Text("Nro").Bold();
                                header.Cell().Element(CellStyle).Text("Apellido y Nombre").Bold();
                                header.Cell().Element(CellStyle).Text("Documento").Bold();
                                header.Cell().Element(CellStyle).Text("Teléfono").Bold();
                                header.Cell().Element(CellStyle).Text("E-Mail").Bold();
                                header.Cell().Element(CellStyle).Text("Barrio").Bold();
                                header.Cell().Element(CellStyle).Text("Alta").Bold();
                            });

                            // Rellenar datos de la tabla
                            foreach (var item in data)
                            {
                                table.Cell().Element(CellStyle).Text(item.idSocio);
                                table.Cell().Element(CellStyle).Text(item.NombreCompleto);
                                table.Cell().Element(CellStyle).Text(item.numeroDocumento);
                                table.Cell().Element(CellStyle).Text(item.telefono1);
                                table.Cell().Element(CellStyle).Text(item.mail);
                                table.Cell().Element(CellStyle).Text(item.BarrioNombre);
                                table.Cell().Element(CellStyle).Text(item.fechaAlta.ToString("dd/MM/yyyy"));
                                //table.Cell().Element(CellStyle).Text(item.Price.ToString("C"));
                            }
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                });
            })
            .GeneratePdf(fileName);


            var mes = new MessageBoxCustom(fileName, EnumModoMessageBoxCustom.ReporteGenerado, 250, 50);
            mes.ShowDialog();
            if (mes.response == DialogResult.Yes)
            {
                try
                {
                    Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se pudo abrir el archivo PDF: " + ex.Message);
                }
            }
        }

        static Action<IContainer> ComposeHeader(byte[] imagePath, string filtrosAplicados)
        {
            return container =>
            {
                container.Column(column =>
                {
                    column.Item().Row(row =>
                    {
                        /*row.ConstantItem(100)
                            .Height(50)
                            .Background(Colors.White)
                            .Image(imagePath);*/

                        row.ConstantItem(100)
                            .AlignLeft()
                            //.Height(150)
                            .Background(Colors.White)
                            .Image(imagePath);


                        row.RelativeItem()
                            .AlignMiddle()
                            .AlignTop()
                            .Padding(10)
                            .Background(Colors.White)
                            .Text("       Informe de Socios")
                            .SemiBold().FontSize(15).FontColor(Colors.Blue.Medium);

                        row.RelativeItem()
                            .AlignRight()
                            .Padding(10)
                            .Background(Colors.White)
                            .Text("Fecha: " + DateTime.Now.ToString() + filtrosAplicados)
                            .SemiBold().FontSize(10).FontColor(Colors.Grey.Medium);

                    });

                    //column.Item().AlignRight().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                    //    .FontSize(12)
                    //    .FontColor(Colors.Grey.Medium);
                });
            };
        }
        static IContainer CellStyle(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(3)
                .AlignMiddle()
                .AlignCenter();
        }

        //static IContainer CellStyleHeaders(IContainer container)
        //{
        //    return container
        //        .Border(1)
        //        .BorderColor(Colors.Grey.Lighten2)
        //        .Padding(5)
        //        .AlignMiddle()
        //        .AlignCenter();
        //}
        bool sortAscending;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            ordenadoPor = columnName;

            if (sortAscending)
                _listaSocios = _listaSocios.OrderBy(s => s.GetType().GetProperty(columnName).GetValue(s, null)).ToList();
            else
                _listaSocios = _listaSocios.OrderByDescending(s => s.GetType().GetProperty(columnName).GetValue(s, null)).ToList();


            sortAscending = !sortAscending;

            // Volver a vincular la lista ordenada al DataGridView
            bindingSource1.DataSource = _listaSocios;

        }

        private void ucClearFilters1__ClickUCAgregar(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            AloneTextBox textBox = sender as AloneTextBox;
            if (textBox != null)
            {
                // Guarda la posición actual del cursor
                int selectionStart = textBox.TB.SelectionStart;
                int selectionLength = textBox.TB.SelectionLength;

                // Filtra el texto permitiendo solo los números
                string newText = string.Empty;
                foreach (char c in textBox.Text)
                {
                    if (char.IsDigit(c))
                    {
                        newText += c;
                    }
                }

                // Actualiza el texto del TextBox sin perder la posición del cursor
                textBox.Text = newText;
                textBox.TB.SelectionStart = selectionStart > textBox.Text.Length ? textBox.Text.Length : selectionStart;
                textBox.TB.SelectionLength = selectionLength;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            AloneTextBox textBox = sender as AloneTextBox;
            if (textBox != null)
            {
                // Guarda la posición actual del cursor
                int selectionStart = textBox.TB.SelectionStart;
                int selectionLength = textBox.TB.SelectionLength;

                // Filtra el texto permitiendo solo los números
                string newText = string.Empty;
                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        newText += c;
                    }
                }

                // Actualiza el texto del TextBox sin perder la posición del cursor
                textBox.Text = newText;
                textBox.TB.SelectionStart = selectionStart > textBox.Text.Length ? textBox.Text.Length : selectionStart;
                textBox.TB.SelectionLength = selectionLength;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            AloneTextBox textBox = sender as AloneTextBox;
            if (textBox != null)
            {
                // Guarda la posición actual del cursor
                int selectionStart = textBox.TB.SelectionStart;
                int selectionLength = textBox.TB.SelectionLength;

                // Filtra el texto permitiendo solo los números
                string newText = string.Empty;
                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        newText += c;
                    }
                }

                // Actualiza el texto del TextBox sin perder la posición del cursor
                textBox.Text = newText;
                textBox.TB.SelectionStart = selectionStart > textBox.Text.Length ? textBox.Text.Length : selectionStart;
                textBox.TB.SelectionLength = selectionLength;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bindingSource1 == null || bindingSource1.Current == null)
            {
                new MessageBoxCustom("Seleccione un socio", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Consulta;
            frmSociosAlta._id_socio = ((Socio)bindingSource1.Current).idSocio;

            frmSociosAlta.ShowDialog();

            CargarGrilla();
        }

        private void Cuota_Click(object sender, EventArgs e)
        {
            if (bindingSource1 == null || bindingSource1.Current == null)
            {
                new MessageBoxCustom("Seleccione un socio", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmPagarCuota frm = new FrmPagarCuota();
            frm._idSocio = ((Socio)bindingSource1.Current).idSocio;
            frm.ShowDialog();

        }

        private void BtnMembresía_Click(object sender, EventArgs e)
        {

            var socio = bindingSource1.Current as Socio;

            if (socio == null)
            {
                return;
            }


            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Alta;
            frm._id_membresia = 0;
            frm.SetSocio(socio);
            frm.ShowDialog();
            
            
        }
    }
}
