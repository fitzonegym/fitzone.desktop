﻿using Fitzone.Front.FormsExtras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Front
{
    public static class Statics
    {
        static FrmWait frmWait = new FrmWait();        

        public static void WaitShow()
        {
            //var screen = Screen.PrimaryScreen.Bounds;

            //// Calcular la posición central
            //int x = (screen.Width - frmWait.Width) / 2;
            //int y = (screen.Height - frmWait.Height) / 2;

            //// Establecer la posición del formulario
            //frmWait.Location = new System.Drawing.Point(x, y);

            //frmWait.Show();
        }

        public static void WaitHide()
        {
            //frmWait.Hide();
        }

        public static DateTime DateTimeNowSinHora()
        {

            return Statics.DateTimeSinHora(DateTime.Now);
        }

        public static DateTime DateTime235959(DateTime fecha)
        {
            DateTime now = fecha;
            return new DateTime(now.Year, now.Month, now.Day, 23,59,59);            
        }

        public static DateTime DateTimeNow235959()
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
        }

        public static DateTime DateTimeSinHora(DateTime fecha)
        {
            DateTime now = fecha;
            return new DateTime(now.Year, now.Month, now.Day);
        }

        public static string DateTimeNowSinHoraString(DateTime fecha)
        {
            return fecha.ToString("d");
        }

        public static string GenerarNombreArchivoUnico(string baseName, string extension)
        {
            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;

            // Formatear la fecha y hora
            string dateTime = now.ToString("yyyyMMdd_HHmmss");

            // Crear el nombre de archivo único
            string fileName = $"{baseName}_{dateTime}.{extension}";

            return fileName;
        }

    }
}
