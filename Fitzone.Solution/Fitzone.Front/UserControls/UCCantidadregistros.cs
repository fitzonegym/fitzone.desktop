using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.UserControls
{
    public partial class UCCantidadregistros : UserControl
    {

        private int cantidad = 0;
        public int _cantidad
        {
            get
            {
                return cantidad;
            }
            set { 
                cantidad = value;
                txtValor.Text = cantidad.ToString();
                txtValor.Refresh();
                
            }
        }
        public UCCantidadregistros()
        {
            InitializeComponent();
        }
    }
}
