using Fitzone.Controller;
using Fitzone.Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;

public class FacturaDocument : IDocument
{
    Factura fac;
    

    //public FacturaDocument(string nombreCliente, string direccionCliente, string fecha, List<(string, int, decimal)> items, decimal impuestoPorcentaje)
        public FacturaDocument(Factura f)
    {
        fac = f;    
        
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(2, Unit.Centimetre);
            page.PageColor(Colors.White);
            page.DefaultTextStyle(x => x.FontSize(12));

            page.Header().Element(ComposeHeader);  // Agregamos el método ComposeHeader como argumento
            page.Content().Element(ComposeContent);  // Agregamos el método ComposeContent como argumento
            page.Footer().Element(ComposeFooter);  // Agregamos el método ComposeFooter como argumento
        });
    }

    void ComposeHeader(IContainer container)
    {
        string imagePath = "D:\\Fitzone\\fitzone.desktop\\Fitzone.Solution\\Fitzone.Front\\Imagenes\\logo-factura.png"; // Actualiza 

        int size_font = 10;

        container
            .Border(1)
            .Row(row =>
                {
                    row.RelativeItem()
                    .Padding(5)
                    .Column(column =>
                    {
                        column.Item().Text(new ConfiguracionesController().GetValueByName("EmpresaNombre") ?? "FITZONE").SemiBold().FontSize(18);
                        column.Item().Text(new ConfiguracionesController().GetValueByName("EmpresaDireccion") ?? "San Jeronimo 2215").FontSize(size_font);                
                        column.Item().Text("Teléfono: " + (new ConfiguracionesController().GetValueByName("EmpresaTelefono") ?? "3516175681")).FontSize(size_font);               
                        column.Item().Text("Correo: " + (new ConfiguracionesController().GetValueByName("EmpresaMail") ?? "fitzone@gmail.com")).FontSize(size_font);
                        column.Item().Text("CUIT: " + (new ConfiguracionesController().GetValueByName("EmpresaCUIT") ?? "20-12345678-2")).FontSize(size_font);
                        column.Item().Text("IngresosBrutos: " + (new ConfiguracionesController().GetValueByName("EmpresaIngresosBrutos") ?? "4512478955")).FontSize(size_font);
                        column.Item().Text("Inicio Actividades: " + (new ConfiguracionesController().GetValueByName("EmpresaInicioActividades") ?? "01/10/2020")).FontSize(size_font);

                    });

                    string spaces = "      ";
                    row.RelativeItem()
                    .PaddingTop(10)                        
                    .Column(col =>
                    {
                        col.Item().Text(spaces+"Factura").AlignStart();
                        col.Item().Text(spaces+"  C").AlignStart().FontSize(16);
                    });
                    row.ConstantItem(150).Image(imagePath).FitArea();//logo  
                });
    }

    void ComposeContent(IContainer container)
    {
        int size_col1 = 12;

        //datos cliente + detalle
        container
            .Border(1) 
            .PaddingVertical(10).Column(column =>
        {
            // Información del cliente
            column.Item().Row(row =>
            {
                row.RelativeItem().Padding(5).Column(column =>
                {
                    column.Item().Text($"Cliente: {fac.clienteNombre}").Bold().FontSize(size_col1);
                    column.Item().Text($"Dirección: {fac.clienteDireccion}").FontSize(size_col1);
                });

                row.ConstantItem(150).Padding(5).Column(column =>
                {
                    column.Item().Text($"Fecha: {fac.fecha.ToShortDateString()}").FontSize(size_col1);
                    column.Item().Text($"N° Factura: {fac.numero}").FontSize(size_col1);  // Simulación de número de factura
                });
            });

            column.Item().PaddingVertical(10).Element(ComposeTable);  // Agregamos ComposeTable como argumento

            // Subtotal, impuestos y total
            column.Item()                
                .PaddingTop(20)
                .AlignRight()
                .Column(column =>
                {
                    decimal subtotal = 0;
                    foreach (var item in fac.DetalleFactura)
                        subtotal += item.total;

                    //decimal impuestos = subtotal * _impuestoPorcentaje / 100;
                    decimal total = subtotal;// + impuestos;

                    //stack.Item().Text($"Subtotal: {subtotal:C}").FontSize(12);
                    //stack.Item().Text($"Descuentos ({_impuestoPorcentaje}%): {impuestos:C}").FontSize(12);
                    column.Item().Text($"Total: {total:C}").Bold().FontSize(14);
                });
        });
    }

    void ComposeTable(IContainer container)
    {
        int size_col1 = 10;

        container
            .Border(1)
            .Table(table =>
        {
            
            // Definir el encabezado de la tabla
            table.ColumnsDefinition(columns =>
            {
                columns.ConstantColumn(50);  // Cantidad
                columns.RelativeColumn();    // Descripción
                columns.ConstantColumn(100); // Precio unitario
                columns.ConstantColumn(100); // Total
            });

            // Fila del encabezado
            table            
            .Header(header =>
            {
                
                header.Cell().Border(1).Element(CellStyle).Text("Cant.").FontSize(size_col1); 
                header.Cell().Border(1).Element(CellStyle).Text("Descripción").FontSize(size_col1); 
                header.Cell().Border(1).Element(CellStyle).AlignRight().Text("Precio Unitario").FontSize(size_col1); 
                header.Cell().Border(1).Element(CellStyle).AlignRight().Text("Total").FontSize(size_col1);
            });

            // Añadir filas con los ítems
            foreach (DetalleFactura det in fac.DetalleFactura)
            {
                table.Cell().Element(CellStyle).Text(det.cantidad.ToString()).FontSize(size_col1);
                table.Cell().Element(CellStyle).Text(det.descripcion).FontSize(size_col1);
                table.Cell().Element(CellStyle).AlignRight().Text($"{det.precioUnitario:C}").FontSize(size_col1);
                table.Cell().Element(CellStyle).AlignRight().Text($"{det.total:C}").FontSize(size_col1);
            }
        });
    }

    void ComposeFooter(IContainer container)
    {
        container.AlignCenter().Text("Gracias por su compra.").FontSize(12);
        //container.AlignCenter().Text("Términos y condiciones aplicables.").FontSize(10).Italic();
    }

    // Método auxiliar para darle estilo a las celdas
    IContainer CellStyle(IContainer container)
    {
        return container.PaddingVertical(5).PaddingHorizontal(10);
    }
}
