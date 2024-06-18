para crear la BD 

******************************************************
*Para que funcione la creacoin de la BD, el proyecto debe estar en la carpeta 
    D:\Fitzone\fitzone.desktop\Fitzone.Solution\
*Si esta en el disco C se debe cambiar en el archivo "ActualizarMigrations.bat" la ruta adecuada
******************************************************

Con esto hecho. Se puede crear la BD

1-Verificar el nombre de la BD y la configuracion del servidor SQL en el archivo "ApplicationDesignTimeDbContextFactory.cs" en el proyecto Fitzone.EF
2-Hacer lo mismo en el app config en el proyecto del front
3-en la ventana consola del administrador de paquetes ejecutar el comando

     .\Fitzone.EF\ActualizarMigrations.bat

     Este comando hace todo, crea la BD e inserta algunos datos de prueba
4-Si todo va bien, en la ventana se muestra el mensaje


Applying migration '20240618142829_Init'.
Applying migration '20240618142832_Agregar-datos-migrations'.
Done.

