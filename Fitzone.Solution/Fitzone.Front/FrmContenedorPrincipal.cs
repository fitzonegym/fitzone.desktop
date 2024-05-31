using Fitzone.Front.FormsExtras;
using Fitzone.Front.Socios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front
{
    public partial class FrmContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void FrmContenedorPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosAdmin frmSociosAdmin = new FrmSociosAdmin();
            frmSociosAdmin.MdiParent = this;
            panelPrincipal.Controls.Add(frmSociosAdmin);
            frmSociosAdmin.StartPosition = FormStartPosition.CenterParent;
            frmSociosAdmin.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxCustom msg = new MessageBoxCustom("¿Desea salir del sistema?", Enumeraciones.EnumModoMessageBoxCustom.YesNo);
            msg.ShowDialog();
            if (msg.response == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosAlta frmSociosAlta = new FrmSociosAlta();
            frmSociosAlta.MdiParent = this;
            panelPrincipal.Controls.Add(frmSociosAlta);
            frmSociosAlta.StartPosition = FormStartPosition.CenterParent;
            frmSociosAlta.Show();
        }
    }
}
