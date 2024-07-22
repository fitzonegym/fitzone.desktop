
/*   
  .\Fitzone.EF\ActualizarMigrations.bat
    
  add-migration Init
  add-migration Agregar-datos-migrations
  update-database  

 */
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Agregardatosmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                     migrationBuilder.Sql(@"
                       
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Centro');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Alta Córdoba');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Nueva Córdoba');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Cerro de las Rosas');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Pueyrredon');                         

                            GO        
                            


                           INSERT INTO [dbo].[Socio] (nombre, apellido, numeroDocumento, telefono1, telefono2, mail, tipoDocumento, calle, calleNumero, anulado, imagen, fechaAlta, fechaNacimiento, idBarrio) VALUES
                            ('Juan', 'Pérez', '12345678', '1234567', '3518765432', 'juan.perez@gmail.com', 'DNI', 'Av. Colón', '123', 0, NULL, '2024-07-15 12:34:56', '1980-05-14 00:00:00', 1),
                            ('María', 'González', '87654321', '7654321', '3512345678', 'maria.gonzalez@gmail.com', 'DNI', 'Av. General Paz', '456', 0, NULL, '2024-07-14 09:45:30', '1985-08-22 00:00:00', 2),
                            ('Carlos', 'Rodríguez', '11223344', '1122334', '3511122334', 'carlos.rodriguez@gmail.com', 'DNI', 'Calle San Martín', '789', 0, NULL, '2024-07-13 15:20:10', '1990-03-12 00:00:00', 3),
                            ('Ana', 'López', '22334455', '2233445', '3512233445', 'ana.lopez@gmail.com', 'DNI', 'Calle Rivadavia', '101', 0, NULL, '2024-07-12 08:12:45', '1982-11-30 00:00:00', 4),
                            ('Luis', 'Martínez', '33445566', '3344556', '3513344556', 'luis.martinez@gmail.com', 'DNI', 'Calle Belgrano', '202', 0, NULL, '2024-06-11 16:50:00', '1979-07-18 00:00:00', 5),
                            ('Laura', 'Gómez', '44556677', '4455667', '3514455667', 'laura.gomez@gmail.com', 'DNI', 'Calle Sarmiento', '303', 0, NULL, '2024-07-10 14:25:00', '1992-02-25 00:00:00', 1),
                            ('Jorge', 'Fernández', '55667788', '5566778', '3515566778', 'jorge.fernandez@gmail.com', 'DNI', 'Calle Velez Sarsfield', '404', 0, NULL, '2024-06-09 18:30:00', '1984-06-10 00:00:00', 2),
                            ('Marta', 'Díaz', '66778899', '6677889', '3516677889', 'marta.diaz@gmail.com', 'DNI', 'Calle Caseros', '505', 0, NULL, '2024-06-08 11:11:11', '1987-09-15 00:00:00', 3),
                            ('Pedro', 'Sánchez', '77889900', '7788990', '3517788990', 'pedro.sanchez@gmail.com', 'DNI', 'Calle Duarte Quirós', '606', 0, NULL, '2024-06-07 13:45:00', '1995-12-20 00:00:00', 4),
                            ('Lucía', 'Ramírez', '88990011', '8899001', '3518899001', 'lucia.ramirez@gmail.com', 'DNI', 'Calle Obispo Trejo', '707', 0, NULL, '2024-07-06 10:20:30', '1989-01-05 00:00:00', 5),
                            ('Gustavo', 'Torres', '99001122', '9900112', '3519900112', 'gustavo.torres@gmail.com', 'DNI', 'Calle La Tablada', '808', 0, NULL, '2024-06-05 17:00:00', '1983-04-17 00:00:00', 1),
                            ('Patricia', 'Molina', '10112233', '1011223', '3511011223', 'patricia.molina@gmail.com', 'DNI', 'Calle Hipólito Yrigoyen', '909', 0, NULL, '2024-06-04 20:00:00', '1997-10-10 00:00:00', 2),
                            ('Raúl', 'Cabrera', '11223344', '1122334', '3511122334', 'raul.cabrera@gmail.com', 'DNI', 'Calle Tucumán', '1010', 0, NULL, '2024-06-03 09:30:00', '1988-11-11 00:00:00', 3),
                            ('Elena', 'Reyes', '22334455', '2233445', '3512233445', 'elena.reyes@gmail.com', 'DNI', 'Calle San Jerónimo', '111', 0, NULL, '2024-06-02 12:00:00', '1986-03-23 00:00:00', 4),
                            ('José', 'Vega', '33445566', '3344556', '3513344556', 'jose.vega@gmail.com', 'DNI', 'Calle Deán Funes', '222', 0, NULL, '2024-07-01 07:15:00', '1994-06-27 00:00:00', 5),
                            ('Clara', 'Herrera', '44556677', '4455667', '3514455667', 'clara.herrera@gmail.com', 'DNI', 'Calle Santa Rosa', '333', 0, NULL, '2024-05-31 14:00:00', '1981-09-19 00:00:00', 1),
                            ('Hernán', 'Aguilar', '55667788', '5566778', '3515566778', 'hernan.aguilar@gmail.com', 'DNI', 'Calle Avellaneda', '444', 0, NULL, '2024-07-30 17:00:00', '1990-12-30 00:00:00', 2),
                            ('Silvia', 'Ríos', '66778899', '6677889', '3516677889', 'silvia.rios@gmail.com', 'DNI', 'Calle Libertad', '555', 0, NULL, '2024-05-29 11:30:00', '1987-02-11 00:00:00', 3),
                            ('Rafael', 'Campos', '77889900', '7788990', '3517788990', 'rafael.campos@gmail.com', 'DNI', 'Calle General Paz', '666', 0, NULL, '2024-05-28 08:00:00', '1992-05-15 00:00:00', 4),
                            ('Alicia', 'Fuentes', '88990011', '8899001', '3518899001', 'alicia.fuentes@gmail.com', 'DNI', 'Calle Santa Fe', '777', 0, NULL, '2024-07-27 10:45:00', '1984-08-21 00:00:00', 5),
                            ('Roberto', 'Luna', '99001122', '9900112', '3519900112', 'roberto.luna@gmail.com', 'DNI', 'Calle Catamarca', '888', 0, NULL, '2024-05-26 09:00:00', '1979-10-10 00:00:00', 1),
                            ('Inés', 'Miranda', '10112233', '1011223', '3511011223', 'ines.miranda@gmail.com', 'DNI', 'Calle Santiago del Estero', '999', 0, NULL, '2024-05-25 15:30:00', '1993-01-01 00:00:00', 2),
                            ('Diego', 'Navarro', '11223344', '1122334', '3511122334', 'diego.navarro@gmail.com', 'DNI', 'Calle Mendoza', '1110', 0, NULL, '2024-07-24 14:20:00', '1991-04-04 00:00:00', 3)
                                   
                            go
                            
                              INSERT INTO [dbo].[TipoMembresia]
                                    ([nombre]
                                    ,[descripcion],
                                    precioTotal,
                                    cantidadCuotas,
                                    cantidadDiasSemanales,
                                    diasHabilitados)
                                VALUES
                                    ('PASE LIBRE MUSCULACIÓN',
                                    'PASE FULL TODOS LOS DIAS A CUALQUIER HORA PARA MUSCULACIÓN',
                                    15000,
                                    1,
                                    6,
                                    '[lunes,martes,miercoles,jueves,viernes,sabado]'
                                    )
                        GO

                            INSERT INTO [dbo].[TipoMembresia]
                                    (nombre,
                                    descripcion,
                                    precioTotal,
                                    cantidadCuotas,
                                    cantidadDiasSemanales,
                                    diasHabilitados)                                    
                                VALUES
                                    ('PASE MUSCULACIÓN X 3 DIAS'
                                    ,'PASE LIBRE MUSCULACIÓN X 3 DIAS A LA SEMANA - CUALQUIER DIA',
                                    36000,
                                    3,
                                    3,
                                    '[lunes,martes,miercoles,jueves,viernes,sabado]'
                                    )
                        GO

                        INSERT INTO [dbo].[TipoMembresia]
                                    (nombre,
                                    descripcion,
                                    precioTotal,
                                    cantidadCuotas,
                                    cantidadDiasSemanales,
                                    diasHabilitados)
                                VALUES
                                    ('ZUMBA 3 DIAS - ANUAL'
                                    ,'ZUMBA 3 DIAS A LA SEMANA - PASE POR UN AÑO',
                                    120000,
                                    12,
                                    3,
                                    '[lunes,miercoles,viernes]')
                        GO


                                INSERT INTO [dbo].EstadoMembresia
                                   ([nombre]
                                   ,[descripcion])
                                         VALUES
                                               ('ACTIVA'
                                               ,'MEMBRESIA ACTIVA')
                                    GO

                                    INSERT INTO [dbo].EstadoMembresia
                                               ([nombre]
                                               ,[descripcion])
                                         VALUES
                                               ('VENCIDA'
                                               ,'NO PAGO LA CUOTA EN TERMINO')
                                    GO

                                    INSERT INTO [dbo].EstadoMembresia
                                               ([nombre]
                                               ,[descripcion])
                                         VALUES
                                               ('CANCELADA'
                                               ,'CANCELADA MANUALMENTE')
                                    GO
                                    
                                GO
                                  INSERT INTO [dbo].[Membresia]
                                            ([precio]
                                           ,[fechaAlta]
                                           ,[fechaDesde]
                                           ,[fechaHasta]
                                           ,[detalle]
                                           ,[idSocio]
                                           ,[idEstadoMembresia]
                                           ,[idTipoMembresia]
                                           ,cantidadDiasSemanales
                                           ,diasHabilitados
                                           ,[fechaModificacion])
                                     VALUES
                                           (12000
                                           ,getdate()
                                           ,'20240101'
                                           ,'20240131'
                                           ,'DETALLE DE MEMBRESIA'
                                           ,1
                                           ,1
                                           ,1
                                           ,3
                                           ,'[lunes.miercoles,viernes]'
                                           ,null
                                           )
                                GO

                                                   

                            INSERT INTO [dbo].[Configuraciones]
                                       ([nombre]
                                       ,[valor]                                       
                                       )
                                 VALUES
                                       ('CuotaCantDiasVencimiento'
                                       ,'10'
                                       )
                            GO

                          
                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" truncate table  Socio  ;
                                --delete from departamento  ;
                                --DBCC CHECKIDENT (departamento , RESEED, 0);    ");
        }
    }
}
