using Microsoft.Identity.Client;
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
    public partial class UCTituloLabel : UserControl
    {
        public string _titulo
        {         
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public UCTituloLabel()
        {
            InitializeComponent();
            //this.Dock = DockStyle.Top;
        }
    }
}
