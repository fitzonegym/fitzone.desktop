using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using Microsoft.IdentityModel.Tokens;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Diagnostics;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace Fitzone.Front.Facturas
{
    public partial class FrmFacturasAdmin : Form
    {
        List<Factura> _facturaList = new List<Factura>();
        Socio? _Socio;

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
        public FrmFacturasAdmin()
        {
            InitializeComponent();
        }

        private void FrmFacturasAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Limpiar();
            //CargarFacturas();

        }

        private void CargarFacturas()
        {
            Factura f = new Factura();

            f.idSocio = _Socio?.idSocio ?? 0; // Si _socio es null, asigna 0

            _facturaList = new FacturaController().GetAll(f);

            if (chkFecha.Checked)
            {
                var desde = Statics.DateTimeSinHora(txtFechaDesde.Value);
                var hasta = Statics.DateTime235959(txtFechaHasta.Value);

                _facturaList = _facturaList.Where(f => f.fecha >= desde
                    && f.fecha <= hasta).ToList();
            }



            bindingFactura.DataSource = _facturaList;

            ucCantidadregistros1._cantidad = _facturaList?.Count() ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var factura = bindingFactura.Current as Factura;

            if (factura == null)
                return;

            FrmDetalleAlta frm = new FrmDetalleAlta();
            frm._factura = factura;
            frm.ShowDialog();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var factura = bindingFactura.Current as Factura;

            if (factura == null)
                return;

            FrmDetalleAlta frm = new FrmDetalleAlta();
            frm._factura = factura;
            frm.ShowDialog();

        }
        private void ucBuscar1__ClickUC(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Consulta;

            frm.ShowDialog();

            if (frm._SocioSeleccionado == null)
            {
                return;
            }

            _Socio = frm._SocioSeleccionado;

            txtSocio.Text = _Socio.NombreCompleto;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtFechaDesde.Enabled = txtFechaHasta.Enabled = chkFecha.Checked;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void ucClearFilters1__ClickUCAgregar(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _Socio = null;
            txtSocio.Text = "";
            chkFecha.Checked = false;

            chkFecha.Checked = true;

            txtFechaDesde.Value = Statics.DateTimeSinHora(DateTime.Now.AddMonths(-1));
            txtFechaHasta.Value = Statics.DateTimeNow235959();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("Reporte_membresias", "PDF");
            string filtrosAplicados = "";

            if (!txtSocio.Text.IsNullOrEmpty())
                filtrosAplicados += "\nSocio: " + txtSocio.Text;

            if (chkFecha.Checked)
            {
                filtrosAplicados += "\nFecha desde: " + (!txtFechaDesde.Checked ? "Todos" : txtFechaDesde.Value.ToShortDateString());
                filtrosAplicados += "\nFecha hasta: " + (!txtFechaHasta.Checked ? "Todos" : txtFechaHasta.Value.ToShortDateString());
            }

            if (filtrosAplicados == "")
                filtrosAplicados = "\nFiltros: TODOS";
            else
                filtrosAplicados = "\nFiltros: " + filtrosAplicados;


            //if (!String.IsNullOrWhiteSpace(ordenadoPor))
            //  filtrosAplicados += "\nOrdenado por: " + ordenadoPor;


            var data = _facturaList;

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

                                columns.ConstantColumn(60);//fecha
                                columns.ConstantColumn(80);//nro
                                columns.ConstantColumn(80);//socio
                                columns.ConstantColumn(50);//tipo
                                columns.ConstantColumn(50);//letra
                                columns.ConstantColumn(50);//forma
                                columns.ConstantColumn(50);//total
                            });

                            // Encabezados de la tabla
                            table.Header(header =>
                            {

                                header.Cell().Element(CellStyle).Text("Fecha").Bold();
                                header.Cell().Element(CellStyle).Text("Nro").Bold();
                                header.Cell().Element(CellStyle).Text("Socio").Bold();
                                header.Cell().Element(CellStyle).Text("Tipo").Bold();
                                header.Cell().Element(CellStyle).Text("Letra").Bold();
                                header.Cell().Element(CellStyle).Text("Forma pago").Bold();
                                header.Cell().Element(CellStyle).Text("Total").Bold();
                            });

                            // Rellenar datos de la tabla
                            foreach (var item in data)
                            {
                                table.Cell().Element(CellStyle).Text(item.fecha.ToString("dd/MM/yyyy"));
                                table.Cell().Element(CellStyle).Text(item.numero);
                                table.Cell().Element(CellStyle).Text(item.clienteNombre);
                                table.Cell().Element(CellStyle).Text(item.tipoFactura);
                                table.Cell().Element(CellStyle).Text(item.letra);
                                table.Cell().Element(CellStyle).Text(item.metodoDePago);
                                table.Cell().Element(CellStyle).Text("$ " + item.total);
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
                            .Text("Informe de Facturas")
                            .SemiBold().FontSize(15).FontColor(Colors.Blue.Medium);

                        row.RelativeItem()
                            .AlignRight()
                            .Padding(10)
                            .Background(Colors.White)
                            .Text("Fecha: " + DateTime.Now.ToString() + filtrosAplicados)
                            .SemiBold().FontSize(10).FontColor(Colors.Grey.Medium);

                    });


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
    }
}
