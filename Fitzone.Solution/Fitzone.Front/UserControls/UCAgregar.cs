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
    public partial class UCAgregar : UserControl
    {
        public event EventHandler _ClickUCAgregar;

        public UCAgregar()
        {
            InitializeComponent();
            pictureBox1.Click += Picture_Click;
        }      

        private void Picture_Click(object sender, EventArgs e)
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
