﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.FormsExtras
{
    
    public partial class MessageBoxAccessDenied : Form
    {
        public string modulo = "";
        public MessageBoxAccessDenied()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
