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


namespace Fitzone.Front.Socios
{
    public partial class FrmSociosAdmin : Form
    {
        List<Socio> _listaSocios = new List<Socio>();
        public Socio? _SocioSeleccionado = null;
        public EnumModoFormulario _EnumModoFormulario = EnumModoFormulario.Administracion;

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
            btnAceptar.Visible = btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnAnular.Visible = visible;
        }

        private void FrmSociosAdmin_Load(object sender, EventArgs e)
        {
            VisibleBotones(false);

            txtFechaDesde.Value = Statics.DateTimeNowSinHora().AddMonths(-1);
            txtFechaHasta.Value = Statics.DateTimeNow235959();

            // this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (_EnumModoFormulario == EnumModoFormulario.Consulta)
            {
                btnAceptar.Visible = true;
                btnCancelar.Visible = true;
                // btnAceptar.Location = btnCancelar.Location;
                CargarGrilla();
            }
            if (_EnumModoFormulario == EnumModoFormulario.Administracion)
            {
                btnAgregar.Visible = btnCancelar.Visible = btnModificar.Visible = BtnAnular.Visible = true;
                btnImprimir.Location = btnAceptar.Location;
                btnAceptar.Visible = false;
            }

            //dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);

        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (e.RowIndex % 2 == 0) // Si es una fila par
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(209, 196, 234); // Cambia el color de fondo
            }
        }

        private void CargarGrilla()
        {
            Statics.WaitShow();
            SocioController c = new SocioController();

            Socio filter = new Socio();

            filter.nombre = txtNombre.Text;
            filter.apellido = txtApellido.Text;
            filter.numeroDocumento = txtDocumento.Text;

            _listaSocios = c.GetAll(filter, txtFechaDesde.Value, txtFechaHasta.Value);

            bindingSource1.DataSource = null;
            bindingSource1.DataSource = _listaSocios;


            if (_listaSocios.Count == 0)
            {
                new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.NoSeEncontraronDatos).ShowDialog();
                return;
            }

            //dataGridView1.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            Statics.WaitHide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            /*
             
              FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta.MdiParent = this;
            panelPrincipal.Controls.Add(frmSociosAlta);
            frmSociosAlta.StartPosition = FormStartPosition.CenterParent;
            frmSociosAlta.Show();
             */

            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta._EnumModoForm = EnumModoForm.Alta;

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
            new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            return;

            //if (bindingSource1.DataSource == null || bindingSource1.Current == null)
            //    return;

            //FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            //frmSociosAlta._EnumModoForm = EnumModoForm.Modificacion;

            //frmSociosAlta._id_socio = ((Socio)bindingSource1.Current).idSocio;

            //frmSociosAlta.ShowDialog();

            //CargarGrilla();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            return;
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
            CargarGrilla();
            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("ReporteSocios", "PDF");
            string filtrosAplicados = "\nFiltros: ";


            filtrosAplicados += "\nNombre: " + (txtNombre.Text.IsNullOrEmpty() ? "Todos" : txtNombre.Text);
            filtrosAplicados += "\nApellido: " + (txtApellido.Text.IsNullOrEmpty() ? "Todos" : txtApellido.Text);
            filtrosAplicados += "\nNro Doc: " + (txtDocumento.Text.IsNullOrEmpty() ? "Todos" : txtDocumento.Text);
            filtrosAplicados += "\nAlta desde: " + (txtFechaDesde.Checked ? "Todos" : txtFechaDesde.Value.ToShortDateString());
            filtrosAplicados += "\nAlta hasta: " + (txtFechaHasta.Checked ? "Todos" : txtFechaHasta.Value.ToShortDateString());

            // code in your main method
            // Datos de ejemplo para la tabla
            var data = _listaSocios;
            // Ruta de la imagen para el encabezado
            string imagePath = "D:\\Fitzone\\fitzone.desktop\\Fitzone.Solution\\Fitzone.Front\\Imagenes\\logo2.png"; // Actualiza esta ruta con la ubicación de tu imagen


            // Crear el documento PDF
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12))
                    ;

                    page.Header()
                    .Background(Colors.White) // Asegurar que el fondo del encabezado sea blanco
                    .Padding(10)
                    .Element(ComposeHeader(imagePath, filtrosAplicados));

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
                            {
                                columns.ConstantColumn(90);
                                columns.ConstantColumn(90);
                                //columns.RelativeColumn();
                                columns.ConstantColumn(90);
                                columns.ConstantColumn(90);
                                columns.ConstantColumn(90);
                            });

                            // Encabezados de la tabla
                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Alta").Bold();
                                header.Cell().Element(CellStyle).Text("Nombre").Bold();
                                header.Cell().Element(CellStyle).Text("Documento").Bold();
                                header.Cell().Element(CellStyle).Text("Telefono").Bold();
                                header.Cell().Element(CellStyle).Text("Barrio").Bold();
                            });

                            // Rellenar datos de la tabla
                            foreach (var item in data)
                            {
                                table.Cell().Element(CellStyle).Text(item.fechaAlta.ToString("dd/MM/yyyy"));
                                table.Cell().Element(CellStyle).Text(item.NombreCompleto);
                                table.Cell().Element(CellStyle).Text(item.numeroDocumento);
                                table.Cell().Element(CellStyle).Text(item.telefono1);
                                table.Cell().Element(CellStyle).Text(item.BarrioNombre);
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


            var mes = new MessageBoxCustom(fileName, EnumModoMessageBoxCustom.ReporteGenerado, 250,50);
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

        static Action<IContainer> ComposeHeader(string imagePath, string filtrosAplicados)
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
                            .Padding(15)
                            .Background(Colors.White)
                            .Text("       Informe de Socios")
                            .SemiBold().FontSize(15).FontColor(Colors.Blue.Medium);

                        row.RelativeItem()
                            .AlignRight()
                            .Padding(15)
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
                .Padding(5)
                .AlignMiddle()
                .AlignCenter();
        }

        static IContainer CellStyleHeaders(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(5)
                .AlignMiddle()
                .AlignCenter();
        }
        bool sortAscending;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;


            if (sortAscending)
                _listaSocios = _listaSocios.OrderBy(s => s.GetType().GetProperty(columnName).GetValue(s, null)).ToList();
            else
                _listaSocios = _listaSocios.OrderByDescending(s => s.GetType().GetProperty(columnName).GetValue(s, null)).ToList();


            sortAscending = !sortAscending;

            // Volver a vincular la lista ordenada al DataGridView
            bindingSource1.DataSource = _listaSocios;
            
        }
    }
}
