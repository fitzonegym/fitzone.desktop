
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
                       
                            insert into Barrio values ('SPRINGFIELD') 

                            GO                            

                            INSERT INTO [dbo].[Socio]
                                       ([nombre]
                                       ,[apellido]
                                       ,[numeroDocumento]
                                       ,[telefono1]
                                       ,[telefono2]
                                       ,[mail]
                                       ,[tipoDocumento]
                                       ,[calle]
                                       ,[calleNumero]
                                       ,[idBarrio]
                                       ,[anulado]
                                       ,[imagen]
                                       )
                                 VALUES
                                       ('Bart'
                                       ,'Simpsons'
                                       ,'27123456'
                                       ,'35161234'
                                       ,null
                                       ,'bart@gmail.com'
                                       ,'DNI'
                                       ,'Av. SIempre viva'
                                       ,'2215'
                                       ,1
                                       ,0
                                       ,null)
                            GO
                            
                            INSERT INTO [dbo].[Socio]
                                       ([nombre]
                                       ,[apellido]
                                       ,[numeroDocumento]
                                       ,[telefono1]
                                       ,[telefono2]
                                       ,[mail]
                                       ,[tipoDocumento]
                                       ,[calle]
                                       ,[calleNumero]
                                       ,[idBarrio]
                                       ,[anulado]
                                       ,[imagen])
                                 VALUES
                                       ('Lisa'
                                       ,'Simpsons'
                                       ,'123456779'
                                       ,'351687455'
                                       ,null
                                       ,'lisa@gmail.com'
                                       ,'DNI'
                                       ,'Calle 2'
                                       ,'4571'
                                       ,1
                                       ,0
                                       ,null)
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

                                   insert into Barrio values ('SPRINGFIELD') 

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
