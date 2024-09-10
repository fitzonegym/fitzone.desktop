using Fitzone.Controller;
using Fitzone.Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;

public class FacturaDocument : IDocument
{
    private string _nombreCliente;
    private string _direccionCliente;
    private string _fecha;
    private List<DetalleFactura> _items;  // (nombre, cantidad, precio unitario)
    private decimal _impuestoPorcentaje;

    //public FacturaDocument(string nombreCliente, string direccionCliente, string fecha, List<(string, int, decimal)> items, decimal impuestoPorcentaje)
        public FacturaDocument(Factura f)
    {
        _nombreCliente = f.clienteNombre;
        _direccionCliente = f.clienteDireccion;
        _fecha = f.fecha.ToShortDateString();
        _items = f.DetalleFactura;
        //_impuestoPorcentaje = impuestoPorcentaje;
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
        container
            .Border(1)
            .Row(row =>
        {
            row.RelativeColumn().Stack(stack =>
            {                
                stack.Item().Text(new ConfiguracionesController().GetValueByName("EmpresaNombre") ?? "").SemiBold().FontSize(18);
                stack.Item().Text("San jeronimo 123").FontSize(12);
                stack.Item().Text("Teléfono: +54 9 381 123 4567").FontSize(12);
                stack.Item().Text("Correo: fitzone@gmail.com").FontSize(12);
            });
            string imagePath = "D:\\Fitzone\\fitzone.desktop\\Fitzone.Solution\\Fitzone.Front\\Imagenes\\logo2.png"; // Actualiza 
            //row.ConstantColumn(100).Image(Placeholders.Image(100, 50));  // Aquí podrías poner un logo real
            row.ConstantColumn(100).Image(imagePath);  // Aquí podrías poner un logo real
        });
    }

    void ComposeContent(IContainer container)
    {
        //datos cliente + detalle
        container
            .Border(1) 
            .PaddingVertical(10).Column(column =>
        {
            // Información del cliente
            column.Item().Row(row =>
            {
                row.RelativeColumn().Stack(stack =>
                {
                    stack.Item().Text($"Cliente: {_nombreCliente}").Bold();
                    stack.Item().Text($"Dirección: {_direccionCliente}");
                });

                row.ConstantColumn(100).Stack(stack =>
                {
                    stack.Item().Text($"Fecha: {_fecha}");
                    stack.Item().Text($"N° Factura: {Guid.NewGuid().ToString().Substring(0, 8)}");  // Simulación de número de factura
                });
            });

            column.Item().PaddingVertical(10).Element(ComposeTable);  // Agregamos ComposeTable como argumento

            // Subtotal, impuestos y total
            column.Item().PaddingTop(20).AlignRight().Stack(stack =>
            {
                decimal subtotal = 0;
                foreach (var item in _items)
                    subtotal += item.total;

                //decimal impuestos = subtotal * _impuestoPorcentaje / 100;
                decimal total = subtotal;// + impuestos;

                //stack.Item().Text($"Subtotal: {subtotal:C}").FontSize(12);
                //stack.Item().Text($"Descuentos ({_impuestoPorcentaje}%): {impuestos:C}").FontSize(12);
                stack.Item().Text($"Total: {total:C}").Bold().FontSize(14);
            });
        });
    }

    void ComposeTable(IContainer container)
    {
        
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
                
                header.Cell().Border(1).Element(CellStyle).Text("Cant.");
                header.Cell().Border(1).Element(CellStyle).Text("Descripción");
                header.Cell().Border(1).Element(CellStyle).AlignRight().Text("Precio Unitario");
                header.Cell().Border(1).Element(CellStyle).AlignRight().Text("Total");
            });

            // Añadir filas con los ítems
            foreach (DetalleFactura det in _items)
            {
                table.Cell().Element(CellStyle).Text(det.cantidad.ToString()).FontSize(10);
                table.Cell().Element(CellStyle).Text(det.descripcion).FontSize(10);
                table.Cell().Element(CellStyle).AlignRight().Text($"{det.precioUnitario:C}").FontSize(10);
                table.Cell().Element(CellStyle).AlignRight().Text($"{det.total:C}").FontSize(10);
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
