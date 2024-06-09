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
    public partial class UCBotonesForms : UserControl
    {
        public UCBotonesForms()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Normal)
                this.ParentForm.WindowState = FormWindowState.Maximized;
            else
                this.ParentForm.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void BotonesForms_Load(object sender, EventArgs e)
        {
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
    }
}
