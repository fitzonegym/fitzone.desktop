using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using Microsoft.IdentityModel.Tokens;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics;
using Color = System.Drawing.Color;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace Fitzone.Front.Membresias
{
    public partial class FrmMembresiaAdmin : Form
    {
        List<Membresia>? _listaMembresias = new List<Membresia>();
        Socio? _Socio = new Socio();

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
        public FrmMembresiaAdmin()
        {
            InitializeComponent();
            txtNombre.TB.KeyPress += txtNombre_KeyPress;
        }

        private void FrmMembresiaAdmin_Load(object sender, EventArgs e)
        {
            txtFechaDesde.Value = DateTime.Now.AddDays(-10);
            txtFechaHasta.Value = DateTime.Now.AddMonths(1);

            this.WindowState = FormWindowState.Maximized;
            CargarGrilla();

        }

        private void CargarGrilla()
        {
            Membresia filtro = new Membresia();

            if (chkFecha.Checked)
            {
                filtro.fechaDesde = Statics.DateTimeSinHora(txtFechaDesde.Value);
                filtro.fechaHasta = Statics.DateTimeSinHora(txtFechaHasta.Value);
            }
            else
            {
                filtro.fechaDesde = new DateTime(2000, 1, 1);
                filtro.fechaHasta = new DateTime(2030, 1, 1);
            }

            filtro.Socio = null;

            if (!String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                filtro.Socio = new Socio();
                filtro.Socio.nombre = txtNombre.Text.Trim();
                //filtro.Socio.apellido = txtNombre.Text.Trim();
                //filtro.Socio.numeroDocumento = txtNombre.Text.Trim();
            }

            _listaMembresias = new MembresiaController().GetAllFilters(filtro);

            bindingSource1.DataSource = _listaMembresias;

            ucCantidadregistros1._cantidad = _listaMembresias?.Count() ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucBuscar1__ClickUC(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Consulta;
            frm.ShowDialog();
            _Socio = frm._SocioSeleccionado;

            if (_Socio != null)
                txtNombre.Text = _Socio.nombre + " " + _Socio.apellido;
            else
                txtNombre.Text = "Seleccione un socio";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void ucBuscar1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Alta;
            frm._id_membresia = 0;
            frm.ShowDialog();
            CargarGrilla();
        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            if (bindingSource1 == null || bindingSource1.Current == null)
            {
                new MessageBoxCustom("Seleccione una membresia", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            FrmPagarCuota frm = new FrmPagarCuota();
            frm._idSocio = ((Membresia)bindingSource1.Current).idSocio;
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;

            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm._EnumModoForm = EnumModoForm.Consulta;

            frm._id_membresia = ((Membresia)bindingSource1.Current).idMembresia;

            frm.ShowDialog();
        }

        private void ucBuscar1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarGrilla();
                // Prevenir el sonido de beep
                //e.Handled = true;

            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtener la fila actual
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Verificar si la columna "anulado" tiene el valor true
            if (Convert.ToString(row.Cells["colEstado"].Value) == "Activa")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightGreen; // Cambia el color según tus preferencias
                //row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Vencida")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightCoral; // Cambia el color según tus preferencias
                                                                   //  row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Deshabilitada")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia el color según tus preferencias
                                                                  // row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
            else if (Convert.ToString(row.Cells["colEstado"].Value) == "Finalizada")
            {
                // Cambiar el color de fondo de la fila
                row.DefaultCellStyle.BackColor = Color.LightBlue; // Cambia el color según tus preferencias
                                                                  //  row.DefaultCellStyle.ForeColor = Color.White; // Cambia el color de texto si es necesario
            }
        }

        public void SetSocio(string nrodocumento)
        {
            txtNombre.Text = nrodocumento;
            chkFecha.Checked = false;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtFechaDesde.Enabled = txtFechaHasta.Enabled = chkFecha.Checked;


        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (bindingSource1.DataSource == null || bindingSource1.Current == null)
                return;


            var id = ((Membresia)bindingSource1.Current).idMembresia;

            var mes = new MessageBoxCustom("¿Desea deshabilitar la membresía seleccionada?", EnumModoMessageBoxCustom.YesNo, 75);
            mes.ShowDialog();
            if (mes.response == DialogResult.No)
            {
                return;
            }

            new MembresiaController().Deshabilitar(id);

            CargarGrilla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("Reporte_membresias", "PDF");
            string filtrosAplicados = "";

            if (!txtNombre.Text.IsNullOrEmpty())
                filtrosAplicados += "\nSocio: " + txtNombre.Text;

            if (chkFecha.Checked)
            {
                filtrosAplicados += "\nFecha desde: " + (!txtFechaDesde.Checked ? "Todos" : txtFechaDesde.Value.ToShortDateString());
                filtrosAplicados += "\nFecha hasta: " + (!txtFechaHasta.Checked ? "Todos" : txtFechaHasta.Value.ToShortDateString());
            }

            if (filtrosAplicados == "")
                filtrosAplicados = "\nFiltros: TODOS" ;
            else            
                filtrosAplicados = "\nFiltros: " + filtrosAplicados;
                

            //if (!String.IsNullOrWhiteSpace(ordenadoPor))
            //  filtrosAplicados += "\nOrdenado por: " + ordenadoPor;


            var data = _listaMembresias;

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

                                columns.ConstantColumn(90);//socio
                                columns.ConstantColumn(60);//tipo
                                columns.ConstantColumn(60);//estado
                                columns.ConstantColumn(50);//precio
                                columns.ConstantColumn(100);//dias
                                columns.ConstantColumn(50);//desde
                                columns.ConstantColumn(50);//hasta
                            });

                            // Encabezados de la tabla
                            table.Header(header =>
                            {

                                header.Cell().Element(CellStyle).Text("Socio").Bold();
                                header.Cell().Element(CellStyle).Text("Tipo").Bold();
                                header.Cell().Element(CellStyle).Text("Estado").Bold();
                                header.Cell().Element(CellStyle).Text("Precio").Bold();
                                header.Cell().Element(CellStyle).Text("Días").Bold();
                                header.Cell().Element(CellStyle).Text("Desde").Bold();
                                header.Cell().Element(CellStyle).Text("Hasta").Bold();
                            });

                            // Rellenar datos de la tabla
                            foreach (var item in data)
                            {
                                table.Cell().Element(CellStyle).Text(item.SocioNombre);
                                table.Cell().Element(CellStyle).Text(item.TipoMembresiaNombre);                                
                                table.Cell().Element(CellStyle).Text(item.EstadoMembresiaNombre);                                
                                table.Cell().Element(CellStyle).Text("$ "+item.precio);
                                table.Cell().Element(CellStyle).Text(item.diasHabilitados);
                                table.Cell().Element(CellStyle).Text(item.fechaDesde.ToString("dd/MM/yyyy"));
                                table.Cell().Element(CellStyle).Text(item.fechaHasta.ToString("dd/MM/yyyy"));

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
                            .Text("Informe de Membresías")
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
