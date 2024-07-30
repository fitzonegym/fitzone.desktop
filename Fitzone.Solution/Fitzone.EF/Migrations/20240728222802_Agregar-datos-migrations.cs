﻿
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
                       
                           INSERT INTO [dbo].[Barrio] (nombre)
							VALUES
								('Centro'),
								('Alta Córdoba'),
								('Nueva Córdoba'),
								('Cerro de las Rosas'),
								('Pueyrredon');     

                            GO


                           INSERT INTO [dbo].[Socio] (nombre, apellido, numeroDocumento, telefono1, telefono2, mail, tipoDocumento, calle, calleNumero, anulado, imagen, fechaAlta, fechaNacimiento, idBarrio) VALUES
                            ('Juan', 'Perez', '24345678', '1234567', '3518765432', 'juan.perez@gmail.com', 'DNI', 'Av. Colón', '123', 0, NULL, '2024-07-15 12:34:56', '1980-05-14 00:00:00', 1),
                            ('María', 'González', '30654321', '7654321', '3512345678', 'maria.gonzalez@gmail.com', 'DNI', 'Av. General Paz', '456', 0, NULL, '2024-07-14 09:45:30', '1985-08-22 00:00:00', 2),
                            ('Carlos', 'Rodríguez', '35223344', '1122334', '3511122334', 'carlos.rodriguez@gmail.com', 'DNI', 'Calle San Martín', '789', 0, NULL, '2024-07-13 15:20:10', '1990-03-12 00:00:00', 3),
                            ('Ana', 'López', '29334455', '2233445', '3512233445', 'ana.lopez@gmail.com', 'DNI', 'Calle Rivadavia', '101', 0, NULL, '2024-07-12 08:12:45', '1982-11-30 00:00:00', 4),
                            ('Luis', 'Martínez', '27445566', '3344556', '3513344556', 'luis.martinez@gmail.com', 'DNI', 'Calle Belgrano', '202', 0, NULL, '2024-06-11 16:50:00', '1979-07-18 00:00:00', 5),
                            ('Laura', 'Gómez', '36556677', '4455667', '3514455667', 'laura.gomez@gmail.com', 'DNI', 'Calle Sarmiento', '303', 0, NULL, '2024-07-10 14:25:00', '1992-02-25 00:00:00', 1),
                            ('Jorge', 'Fernández', '31667788', '5566778', '3515566778', 'jorge.fernandez@gmail.com', 'DNI', 'Calle Velez Sarsfield', '404', 0, NULL, '2024-06-09 18:30:00', '1984-06-10 00:00:00', 2),
                            ('Marta', 'Díaz', '32778899', '6677889', '3516677889', 'marta.diaz@gmail.com', 'DNI', 'Calle Caseros', '505', 0, NULL, '2024-06-08 11:11:11', '1987-09-15 00:00:00', 3),
                            ('Pedro', 'Sánchez', '39889900', '7788990', '3517788990', 'pedro.sanchez@gmail.com', 'DNI', 'Calle Duarte Quirós', '606', 0, NULL, '2024-06-07 13:45:00', '1995-12-20 00:00:00', 4),
                            ('Lucía', 'Ramírez', '34990011', '8899001', '3518899001', 'lucia.ramirez@gmail.com', 'DNI', 'Calle Obispo Trejo', '707', 0, NULL, '2024-07-06 10:20:30', '1989-01-05 00:00:00', 5),
                            ('Gustavo', 'Torres', '30001122', '9900112', '3519900112', 'gustavo.torres@gmail.com', 'DNI', 'Calle La Tablada', '808', 0, NULL, '2024-06-05 17:00:00', '1983-04-17 00:00:00', 1),
                            ('Patricia', 'Molina', '40112233', '1011223', '3511011223', 'patricia.molina@gmail.com', 'DNI', 'Calle Hipólito Yrigoyen', '909', 0, NULL, '2024-06-04 20:00:00', '1997-10-10 00:00:00', 2),
                            ('Raúl', 'Cabrera', '36223344', '1122334', '3511122334', 'raul.cabrera@gmail.com', 'DNI', 'Calle Tucumán', '1010', 0, NULL, '2024-06-03 09:30:00', '1988-11-11 00:00:00', 3),
                            ('Elena', 'Reyes', '32334455', '2233445', '3512233445', 'elena.reyes@gmail.com', 'DNI', 'Calle San Jerónimo', '111', 0, NULL, '2024-06-02 12:00:00', '1986-03-23 00:00:00', 4),
                            ('José', 'Vega', '38445566', '3344556', '3513344556', 'jose.vega@gmail.com', 'DNI', 'Calle Deán Funes', '222', 0, NULL, '2024-07-01 07:15:00', '1994-06-27 00:00:00', 5),
                            ('Clara', 'Herrera', '29556677', '4455667', '3514455667', 'clara.herrera@gmail.com', 'DNI', 'Calle Santa Rosa', '333', 0, NULL, '2024-05-31 14:00:00', '1981-09-19 00:00:00', 1),
                            ('Hernán', 'Aguilar', '35667788', '5566778', '3515566778', 'hernan.aguilar@gmail.com', 'DNI', 'Calle Avellaneda', '444', 0, NULL, '2024-07-30 17:00:00', '1990-12-30 00:00:00', 2),
                            ('Silvia', 'Ríos', '32778890', '6677889', '3516677889', 'silvia.rios@gmail.com', 'DNI', 'Calle Libertad', '555', 0, NULL, '2024-05-29 11:30:00', '1987-02-11 00:00:00', 3),
                            ('Rafael', 'Campos', '36889900', '7788990', '3517788990', 'rafael.campos@gmail.com', 'DNI', 'Calle General Paz', '666', 0, NULL, '2024-05-28 08:00:00', '1992-05-15 00:00:00', 4),
                            ('Alicia', 'Fuentes', '31990011', '8899001', '3518899001', 'alicia.fuentes@gmail.com', 'DNI', 'Calle Santa Fe', '777', 0, NULL, '2024-07-27 10:45:00', '1984-08-21 00:00:00', 5),
                            ('Roberto', 'Luna', '27001122', '9900112', '3519900112', 'roberto.luna@gmail.com', 'DNI', 'Calle Catamarca', '888', 0, NULL, '2024-05-26 09:00:00', '1979-10-10 00:00:00', 1),
                            ('Inés', 'Miranda', '37112233', '1011223', '3511011223', 'ines.miranda@gmail.com', 'DNI', 'Calle Santiago del Estero', '999', 0, NULL, '2024-05-25 15:30:00', '1993-01-01 00:00:00', 2),
                            ('Diego', 'Navarro', '35223344', '1122334', '3511122334', 'diego.navarro@gmail.com', 'DNI', 'Calle Mendoza', '1110', 0, NULL, '2024-07-24 14:20:00', '1991-04-04 00:00:00', 3)
                                   
                           go                                          

                            INSERT INTO [dbo].[Configuraciones]
                                       ([nombre]
                                       ,[valor]                                       
                                       )
                                 VALUES
                                       ('CuotaCantDiasVencimiento'
                                       ,'10'
                                       )
                            GO
							
							INSERT INTO [dbo].[Actividad] 
								(nombre) 
								values 
								('Gimnasio'), ('Zumba'),('Pilates'),('Karate'),('Boxeo')
								
							GO
							
							INSERT INTO [dbo].EstadoEquipamiento (nombre)
							VALUES
								('HABILITADO'),
								('NO UTILIZABLE'),
								('PRONTO A ROMPERSE')
							
							GO
							
							INSERT INTO [dbo].Marca (nombre)
							VALUES
								('BALANCED BODY'),
								('AERO'),
								('ALIGN')
							
							GO
							
							INSERT INTO [dbo].[Equipamiento]
								   ([nombre]
								   ,[dimensiones]
								   ,[modelo]
								   ,[idEstadoEquipamiento]
								   ,[idMarca])
							 VALUES
									('Reformer'
								   ,'2.5 MTS X 0.8 MTS'           
								   ,'Reformer Pilares'           
								   ,1
								   ,1),
								   ('Fitball'
								   ,'80 cm diametro'           
								   ,'Gama-Fit'           
								   ,1
								   ,2)
								   
							GO
							
								INSERT INTO [dbo].[EstadoMembresia] (nombre, descripcion)
								VALUES
									('ACTIVA', 'MEMBRESIA ACTIVA'),
									('VENCIDA', 'NO PAGO LA CUOTA EN TERMINO'),
									('CANCELADA', 'CANCELADA MANUALMENTE');
									
							GO
									
								INSERT INTO [dbo].[Instructor] 
								(nombre, apellido, telefono1, telefono2, mail, tipoDocumento, numeroDocumento, calle, calleNumero, fechaAlta, fechaNacimiento, anulado, idBarrio)
							VALUES
								('Juan', 'Perez', '3511234567', NULL, 'juan.perez@example.com', 'DNI', '12345678', 'Calle Falsa', '123', GETDATE(), '1985-05-15', 0, 1),
								('Maria', 'Gonzalez', '3512345678', NULL, 'maria.gonzalez@example.com', 'DNI', '23456789', 'Avenida Siempreviva', '456', GETDATE(), '1990-10-22', 0, 2),
								('Luis', 'Martinez', '3513456789', NULL, 'luis.martinez@example.com', 'DNI', '34567890', 'Calle Los Pinos', '789', GETDATE(), '1988-08-30', 0, 3),
								('Ana', 'Lopez', '3514567890', NULL, 'ana.lopez@example.com', 'DNI', '45678901', 'Boulevard Las Flores', '101', GETDATE(), '1992-01-17', 0, 4),
								('Carlos', 'Fernandez', '3515678901', NULL, 'carlos.fernandez@example.com', 'DNI', '56789012', 'Calle Las Palmas', '202', GETDATE(), '1987-07-09', 0, 5);
		

                          GO	
						  
						    INSERT INTO [dbo].[TipoMembresia]
								(nombre, descripcion, precioTotal, cantidadCuotas, cantidadDiasSemanales, 
								diasHabilitados,
								horadesde, horahasta, idActividad, idInstructor,cupoClase)
							VALUES
								
								('PASE LIBRE MUSCULACIÓN',
								 'PASE FULL TODOS LOS DIAS A CUALQUIER HORA PARA MUSCULACIÓN',
								 15000,
								 1,
								 6,
								 '[lunes,martes,miercoles,jueves,viernes,sabado]'
								 ,'20000101 00:00:00'
								 ,'20000101 23:59:59'
								 ,1
								 ,null,
								 null),
								 
								('PASE MUSCULACIÓN X 3 DIAS',
								 'PASE LIBRE MUSCULACIÓN X 3 DIAS A LA SEMANA - CUALQUIER DIA',
								 36000,
								 3,
								 3,
								 '[lunes,martes,miercoles,jueves,viernes,sabado]'								 
								 ,'20000101 00:00:00'
								 ,'20000101 23:59:59'
								 ,1
								 ,null,
								 null),								 		
								 
								('ZUMBA 3 DIAS - ANUAL',
								 'ZUMBA 3 DIAS A LA SEMANA - PASE POR UN AÑO',
								 120000,
								 12,
								 3,
								 '[lunes,miercoles,viernes]'
								  ,'20000101 20:00:00'
								 ,'20000101 21:00:00'
								 ,2
								 ,1,
								 20),
								 
								  
								('PILATES 3 DIAS - 6 MESES',
								 'PILATES 3 DIAS A LA SEMANA - PASE POR 6 MESES',
								 90000,
								 12,
								 3,
								 '[martes,jueves,viernes]'
								  ,'20000101 19:00:00'
								 ,'20000101 20:30:00'
								 ,3
								 ,2,
								 15);
								 ;

							GO						
							

							INSERT INTO [dbo].[Membresia]
									   ([precio]
									   ,[fechaAlta]
									   ,[fechaModificacion]
									   ,[fechaDesde]
									   ,[fechaHasta]
									   ,[detalle]
									   ,[cantidadDiasSemanales]
									   ,[diasHabilitados]
									   ,[horadesde]
									   ,[horaHasta]
									   ,[idEstadoMembresia]
									   ,[idSocio]
									   ,[idInstructor]
									   ,[idActividad]
									   ,[idTipoMembresia])
								 VALUES
									   (120000 					--<precio, decimal(8,2),>
									   ,'20240720 15:10:00'		--<fechaAlta, datetime2(7),>
									   ,null					--<fechaModificacion, datetime2(7),>
									   ,'20240721 00:00:00'		--<fechaDesde, datetime2(7),>
									   ,'20250720 00:00:00'		--<fechaHasta, datetime2(7),>
									   ,'ZUMBA 3 DIAS A LA SEMANA - PASE POR UN AÑO'		--<detalle, nvarchar(1000),>
									   ,3						--<cantidadDiasSemanales, int,>
									   ,'[lunes,miercoles,viernes]'		--<diasHabilitados, nvarchar(max),>
									   ,'2000-01-01 21:00:00'	--<horadesde, datetime2(7),>
									   ,'2000-01-01 21:00:00'	--<horaHasta, datetime2(7),>
									   ,1						--<idEstadoMembresia, int,>
									   ,1						--<idSocio, int,>
									   ,1						--<idInstructor, int,>
									   ,3						--<idActividad, int,>
									   ,3						-- idTipoMembresia
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
