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
using Color = System.Drawing.Color;
using Emgu.CV;
using Microsoft.VisualBasic.Logging;
using static ReaLTaiizor.Controls.ToggleEdit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitzone.Front
{
  
    public  class ReportesManager<T>
    {        

        public void GenerarPDF(string NombreReporte, string filtrosAplicados, List<T> data)
        {
            string fileName = "c:\\Reportes\\" + Statics.GenerarNombreArchivoUnico("ReporteSocios", "PDF");

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

                            //// Rellenar datos de la tabla
                            //for (int i = 0; i < data.Count; i++)  
                            //{
                            //    table.Cell().Element(CellStyle).Text(data[i].);
                            //    table.Cell().Element(CellStyle).Text(item.NombreCompleto);
                            //    table.Cell().Element(CellStyle).Text(item.numeroDocumento);
                            //    table.Cell().Element(CellStyle).Text(item.telefono1);
                            //    table.Cell().Element(CellStyle).Text(item.mail);
                            //    table.Cell().Element(CellStyle).Text(item.BarrioNombre);
                            //    table.Cell().Element(CellStyle).Text(item.fechaAlta.ToString("dd/MM/yyyy"));
                                
                            //}
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
                            .Text("       Informe de Socios")
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
