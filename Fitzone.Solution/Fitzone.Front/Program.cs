using Fitzone.Front.Membresias;
using Fitzone.Front.Socios;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmSociosAdmin());            
            //Application.Run(new FrmSociosAlta());
            //Application.Run(new TestDiseņo());
            //Application.Run(new FrmContenedorPrincipal());
            //Application.Run(new FrmMembresia());
            Application.Run(new FrmMembresiaAdmin());

        }
    }
}