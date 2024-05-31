using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Front.FormsExtras
{
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.professionalcolortable?view=windowsdesktop-8.0&redirectedfrom=MSDN

        //Color color = Color.FromArgb(81, 45, 168);
        Color color = Color.Black;
        //public override Color ToolStripDropDownBackground
        //{
        //    get { return color; }
        //}

        //public override Color MenuItemSelected
        //{
        //    get { return color; }
        //}

        public override Color MenuItemSelectedGradientBegin
        {
            get { return color; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return color; }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get { return color; }
        }
     


    }
}
