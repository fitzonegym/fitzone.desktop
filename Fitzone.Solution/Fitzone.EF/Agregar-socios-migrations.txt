
// add-migration Agregar-socios-migrations
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Agregarsociosmigrations : Migration
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
                                       ,0)
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
                                       ,[anulado])
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
                                       ,0)
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
