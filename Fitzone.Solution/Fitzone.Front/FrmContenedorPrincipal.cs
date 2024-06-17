using Fitzone.Front.FormsExtras;
using Fitzone.Front.Membresias;
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
            MyRenderer rend = new MyRenderer();
            menuStrip1.Renderer = rend;
        }
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSociosAdmin frm = new FrmSociosAdmin();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm._EnumModoFormulario = Enumeraciones.EnumModoFormulario.Administracion;
            
            frm.Show();
            frm.BringToFront();
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
            FrmSociosAlta frm = new FrmSociosAlta();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.Show();
            frm.BringToFront();
        }

        private void admnistraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembresiaAdmin frm = new FrmMembresiaAdmin();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;
      
            frm.Show();
            frm.BringToFront();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMembresiaAlta frm = new FrmMembresiaAlta();
            frm.TopMost = true;
            frm.MdiParent = this;
            panelPrincipal.Controls.Add(frm);
            frm.StartPosition = FormStartPosition.CenterParent;            
            frm.Show();
            frm.BringToFront();
        }

        private void BringToFrontForm(Form form)
        {
            form.Activated += (s, e) => { form.BringToFront(); };
            this.MdiChildActivate += (s, e) =>
            {
                if (this.ActiveMdiChild != form)
                {
                    form.BringToFront();
                }
            };
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
