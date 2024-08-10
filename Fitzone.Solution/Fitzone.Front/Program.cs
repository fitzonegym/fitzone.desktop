using Fitzone.Front.Login;
using Fitzone.Front.Membresias;
using Fitzone.Front.Socios;
using QuestPDF.Infrastructure;

namespace Fitzone.Front
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;        
            ApplicationConfiguration.Initialize();

            //                  SOCIOS
            //Application.Run(new FrmSociosAdmin());
            //Application.Run(new FrmSociosAlta());
            //Application.Run(new FrmPagarCuota());

            //              MEMBRESIAS
            //Application.Run(new FrmMembresiaAdmin());            
            //Application.Run(new FrmMembresiaAlta());

            //Application.Run(new FrmTipoMembresiaAdmin());            
            //Application.Run(new FrmTipoMembresiaAlta());

            //          CONTROL DE ACCESOS
            //Application.Run(new FRMIngresosRegistrar());


            //          MENU PRINCIPAL           
            Application.Run(new FrmContenedorPrincipal());
            //Application.Run(new FrmLogin());


        }
    }
}