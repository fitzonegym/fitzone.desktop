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
    public partial class UCClearFilters : UserControl
    {
        public event EventHandler _ClickUCAgregar;
        public UCClearFilters()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Lanza el evento cuando se hace clic en el control
            OnClickEnControl(EventArgs.Empty);
        }

        protected virtual void OnClickEnControl(EventArgs e)
        {
            _ClickUCAgregar?.Invoke(this, e);
        }
    }
}
