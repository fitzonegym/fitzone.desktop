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


    }
}
