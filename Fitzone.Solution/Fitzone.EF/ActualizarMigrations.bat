@echo off

@echo off
echo Eliminando la carpeta y su contenido...

REM Ruta de la carpeta a eliminar
set carpeta=D:\Fitzone\fitzone.desktop\Fitzone.Solution\Fitzone.EF\Migrations

REM Eliminar la carpeta y todo su contenido
rmdir /s /q "%carpeta%"

echo Carpeta eliminada exitosamente.

echo Ejecutando add-migration...

REM Ruta del proyecto donde se ejecutará el comando add-migration
set proyectoDir=D:\Fitzone\fitzone.desktop\Fitzone.Solution\Fitzone.EF

REM Nombre de la migración ----------------------
set migracionNombre=Init

REM Cambiar al directorio del proyecto
cd /d "%proyectoDir%"

REM Ejecutar el comando add-migration Init
dotnet ef migrations add %migracionNombre% --project ..\Fitzone.EF

echo Comando add-migration-Init ejecutado exitosamente.


REM Nombre de la migración ------------------
echo Ejecutando add-migration Agregar-datos-migrations...

set migracionNombre=Agregar-datos-migrations

REM Ejecutar el comando add-migration Agregar-datos-migrations
dotnet ef migrations add %migracionNombre% --project ..\Fitzone.EF

echo Comando add-migration ejecutado exitosamente.

REM ------------------------------


echo Copiando contenido del archivo origen al archivo destino...

REM Ruta del archivo origen
set origen=D:\Fitzone\fitzone.desktop\Fitzone.Solution\Fitzone.EF\Agregar-datos-migrations.txt

REM Ruta del directorio destino
set destinoDir=D:\Fitzone\fitzone.desktop\Fitzone.Solution\Fitzone.EF\Migrations

REM Buscar el archivo destino que contiene 'Agregar-datos-migrations' en el nombre
for /f "delims=" %%f in ('dir /b "%destinoDir%\*Agregar-datos-migrations.cs"') do (
    set destino=%%f
)

REM Comprobar si se encontro un archivo que coincida
if "%destino%"=="" (
    echo No se encontro un archivo que coincida en el directorio destino.
    pause
    exit /b
)

REM Ruta completa del archivo destino
set destino=%destinoDir%\%destino%

REM Copiar el contenido del archivo origen al archivo destino
type "%origen%" > "%destino%"

echo Contenido copiado exitosamente.

REM ---------------
echo Ejecutando update-database

dotnet ef database update

exit /b
