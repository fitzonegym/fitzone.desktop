using Fitzone.Front.Login;
using Fitzone.Front.Membresias;
using Fitzone.Front.Socios;
using QuestPDF.Infrastructure;

namespace Fitzone.Front
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmSociosAdmin());
            //Application.Run(new test2());
            //Application.Run(new FrmSociosAlta());
            //Application.Run(new TestDiseño());
            Application.Run(new FrmContenedorPrincipal());
            //Application.Run(new FrmMembresia());
            //Application.Run(new FrmMembresiaAdmin());
            //Application.Run(new FrmLogin());

        }
    }
}