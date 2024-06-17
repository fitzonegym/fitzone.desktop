
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
                       
                             INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Evergreen Terrace');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Maple Street');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Springfield Blvd');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Walnut Street');
                            INSERT INTO [dbo].[Barrio] ([nombre]) VALUES ('Circus Lane');
                         

                            GO                            

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Homer', 'Simpson', '123456789', '555-1234', NULL, 'homer.simpson@springfield.com', 'DNI', 'Evergreen Terrace', '742', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Marge', 'Simpson', '234567890', '555-5678', NULL, 'marge.simpson@springfield.com', 'DNI', 'Evergreen Terrace', '742', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Bart', 'Simpson', '345678901', '555-8765', NULL, 'bart.simpson@springfield.com', 'DNI', 'Evergreen Terrace', '742', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Lisa', 'Simpson', '456789012', '555-4321', NULL, 'lisa.simpson@springfield.com', 'DNI', 'Evergreen Terrace', '742', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Maggie', 'Simpson', '567890123', '555-9876', NULL, 'maggie.simpson@springfield.com', 'DNI', 'Evergreen Terrace', '742', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Ned', 'Flanders', '678901234', '555-2468', NULL, 'ned.flanders@springfield.com', 'DNI', 'Maple Street', '744', 0, NULL, GETDATE(), 2);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Milhouse', 'Van Houten', '789012345', '555-1357', NULL, 'milhouse.vanhouten@springfield.com', 'DNI', 'Maple Street', '34', 0, NULL, GETDATE(), 2);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Apu', 'Nahasapeemapetilon', '890123456', '555-2468', NULL, 'apu.nahasapeemapetilon@kwikemart.com', 'DNI', 'Springfield Blvd', '82', 0, NULL, GETDATE(), 3);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Moe', 'Szyslak', '901234567', '555-9753', NULL, 'moe.szyslak@moes.com', 'DNI', 'Walnut Street', '3', 0, NULL, GETDATE(), 4);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Krusty', 'the Clown', '012345678', '555-2468', NULL, 'krusty.theclown@krustylu.com', 'DNI', 'Circus Lane', '1', 0, NULL, GETDATE(), 5);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Seymour', 'Skinner', '112233445', '555-2244', NULL, 'seymour.skinner@springfield.com', 'DNI', 'Springfield Blvd', '43', 0, NULL, GETDATE(), 3);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Edna', 'Krabappel', '223344556', '555-3344', NULL, 'edna.krabappel@springfield.com', 'DNI', 'Maple Street', '23', 0, NULL, GETDATE(), 2);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Nelson', 'Muntz', '334455667', '555-4455', NULL, 'nelson.muntz@springfield.com', 'DNI', 'Evergreen Terrace', '10', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Waylon', 'Smithers', '445566778', '555-5566', NULL, 'waylon.smithers@springfield.com', 'DNI', 'Walnut Street', '21', 0, NULL, GETDATE(), 4);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Montgomery', 'Burns', '556677889', '555-6677', NULL, 'montgomery.burns@springfield.com', 'DNI', 'Walnut Street', '1', 0, NULL, GETDATE(), 4);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Ralph', 'Wiggum', '667788990', '555-7788', NULL, 'ralph.wiggum@springfield.com', 'DNI', 'Maple Street', '15', 0, NULL, GETDATE(), 2);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Clancy', 'Wiggum', '778899001', '555-8899', NULL, 'clancy.wiggum@springfield.com', 'DNI', 'Springfield Blvd', '7', 0, NULL, GETDATE(), 3);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Carl', 'Carlson', '889900112', '555-9900', NULL, 'carl.carlson@springfield.com', 'DNI', 'Evergreen Terrace', '94', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Lenny', 'Leonard', '990011223', '555-1010', NULL, 'lenny.leonard@springfield.com', 'DNI', 'Evergreen Terrace', '95', 0, NULL, GETDATE(), 1);

                                INSERT INTO [dbo].[Socio] 
                                ([nombre], [apellido], [numeroDocumento], [telefono1], [telefono2], [mail], [tipoDocumento], [calle], [calleNumero], [anulado], [imagen], [fechaAlta], [idBarrio])
                                VALUES
                                ('Barney', 'Gumble', '001122334', '555-1212', NULL, 'barney.gumble@springfield.com', 'DNI', 'Maple Street', '5', 0, NULL, GETDATE(), 2);



                                GO
                            
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
                                    '[lunes,martes,miercoles,jueves,viernes,sabado]')
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
                                    '[lunes,martes,miercoles,jueves,viernes,sabado]')
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
                                               ,'ACTIVA')
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
                                            ,diasHabilitados)
                                     VALUES
                                           (12000
                                           ,getdate()
                                           ,'20240101'
                                           ,'20240131'
                                           ,'DETALLE DE MEMBRESIA'
                                           ,1
                                           ,1
                                           ,1
                                           , 3
                                    ,'[lunes.miercoles,viernes]')
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
