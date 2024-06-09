using Fitzone.Controller;
using Fitzone.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.Socios
{
    public partial class FrmSociosAdmin : Form
    {
        List<Socio> listaSocios = new List<Socio>();
        public FrmSociosAdmin()
        {
            InitializeComponent();
        }

        private void FrmSociosAdmin_Load(object sender, EventArgs e)
        {

        }

        private void CargarGrilla()
        {
            Statics.WaitShow();
            SocioController c = new SocioController();
            listaSocios = c.GetAll();
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = listaSocios;
            Statics.WaitHide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            FrmSociosAlta frm = new FrmSociosAlta();    
            frm.ShowDialog();
        }
    }
}
