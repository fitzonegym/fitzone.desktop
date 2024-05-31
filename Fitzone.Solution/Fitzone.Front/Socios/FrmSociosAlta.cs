using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.FormsExtras;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class FrmSociosAlta : Form
    {
        public FrmSociosAlta()
        {
            InitializeComponent();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarBarrios()
        {
            BarrioController c = new BarrioController();
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = c.GetAll();

        }

        private void FrmSociosAlta_Load(object sender, EventArgs e)
        {
            CargarBarrios();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {   
            Guardar();            
        }
        private void Guardar()
        {
            Socio socio = new Socio();

            socio.idSocio = 0;
            socio.idBarrio = ((Barrio)bindingSource1.Current).idBarrio;
            
            socio.mail = txtMail.Text;
            socio.anulado = false;
            
            socio.calle = txtCalle.Text;
            socio.calleNumero = txtCalleNro.Text;

            socio.nombre = txtNombre.Text;
            socio.apellido = txtApellido.Text;
            socio.numeroDocumento = txtNroDoc.Text;
            if (rdbDNI.Checked)
                socio.tipoDocumento = "DNI";
            else
                socio.tipoDocumento = "OTRO";
            socio.telefono1 = txtCelular.Text;
            socio.telefono2 = txtTelefono.Text;

            MessageBoxCustom msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();   
            if (msg.response == DialogResult.No)
                return;

            SocioController c  = new SocioController();
            c.Insert(socio);

            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.DatosGuardadosCorrectamente);
            msg.ShowDialog();
            Close();
        }
    }
}
