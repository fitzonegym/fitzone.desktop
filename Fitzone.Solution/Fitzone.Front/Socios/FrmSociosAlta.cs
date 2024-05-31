using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.FormsExtras;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ReaLTaiizor.Controls;
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

        private bool ValidarEmpleado(ref string mensaje, Socio e)
        {
            mensaje = "";


            if (String.IsNullOrWhiteSpace(e.nombre))
            {
                mensaje += "\nIngrese el nombre";
            }

            if (String.IsNullOrWhiteSpace(e.apellido))
            {
                mensaje += "\nIngrese el apellido";
            }

            if (String.IsNullOrWhiteSpace(e.numeroDocumento))
            {
                mensaje += "\nIngrese el nro. de documento";
            }

            if (String.IsNullOrWhiteSpace(e.telefono1))
            {
                mensaje += "\nIngrese el celular";
            }

            if (!String.IsNullOrWhiteSpace(mensaje))
            {
                return false;
            }

            return true;

        }

        private void Guardar()
        {
            MessageBoxCustom msg;

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

            // validaciones
            string mensajeErrores = "";
            if (!ValidarEmpleado(ref mensajeErrores, socio))
            {
                //si falla alguna validacion muestro el mensaje y no hago nada mas
                msg = new MessageBoxCustom(mensajeErrores, Enumeraciones.EnumModoMessageBoxCustom.SeEncontraronErrores);
                msg.ShowDialog();
                return;

            }

            //listo para guardar
            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            SocioController c = new SocioController();
            c.Insert(socio);

            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.DatosGuardadosCorrectamente);
            msg.ShowDialog();
            Close();
        }

        private void _Validating(object sender, CancelEventArgs e)
        {  
            string caracteresIndeseados = "()-.,";

            ucErrorIconoNroDoc.Visible = String.IsNullOrWhiteSpace(new string(txtNroDoc.Text.Where(c => !caracteresIndeseados.Contains(c)).ToArray()));
            ucErrorIconoCel.Visible = String.IsNullOrWhiteSpace((new string(txtCelular.Text.Where(c => !caracteresIndeseados.Contains(c)).ToArray())));

            ucErrorIconoNombre.Visible = String.IsNullOrWhiteSpace(txtNombre.Text);
            ucErrorIconoApellido.Visible = String.IsNullOrWhiteSpace(txtApellido.Text);

        }

        private void txtNroDoc_Click_1(object sender, EventArgs e)
        {
            string cadenaOriginal = txtNroDoc.Text;
            string caracteresIndeseados = ".,";
            string resultado = new string(cadenaOriginal.Where(c => !caracteresIndeseados.Contains(c)).ToArray());

            if (String.IsNullOrWhiteSpace(resultado))
                txtNroDoc.SelectionStart = 0;
        }

        private void txtCelular_Click(object sender, EventArgs e)
        {
            string cadenaOriginal = txtCelular.Text;
            string caracteresIndeseados = "()-";
            string resultado = new string(cadenaOriginal.Where(c => !caracteresIndeseados.Contains(c)).ToArray());

            if (String.IsNullOrWhiteSpace(resultado))
                txtCelular.SelectionStart = 0;
        }      

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            AloneTextBox textBox = sender as AloneTextBox;
            if (textBox != null)
            {
                // Guarda la posición actual del cursor
                int selectionStart = textBox.TB.SelectionStart;
                int selectionLength = textBox.TB.SelectionLength;

                // Filtra el texto permitiendo solo los números
                string newText = string.Empty;
                foreach (char c in textBox.Text)
                {
                    if (char.IsDigit(c))
                    {
                        newText += c;
                    }
                }

                // Actualiza el texto del TextBox sin perder la posición del cursor
                textBox.Text = newText;
                textBox.TB.SelectionStart = selectionStart > textBox.Text.Length ? textBox.Text.Length : selectionStart;
                textBox.TB.SelectionLength = selectionLength;
            }
        }

        private void txtCalleNro_TextChanged(object sender, EventArgs e)
        {
            AloneTextBox textBox = sender as AloneTextBox;
            if (textBox != null)
            {
                // Guarda la posición actual del cursor
                int selectionStart = textBox.TB.SelectionStart;
                int selectionLength = textBox.TB.SelectionLength;

                // Filtra el texto permitiendo solo los números
                string newText = string.Empty;
                foreach (char c in textBox.Text)
                {
                    if (char.IsDigit(c))
                    {
                        newText += c;
                    }
                }

                // Actualiza el texto del TextBox sin perder la posición del cursor
                textBox.Text = newText;
                textBox.TB.SelectionStart = selectionStart > textBox.Text.Length ? textBox.Text.Length : selectionStart;
                textBox.TB.SelectionLength = selectionLength;
            }
        }
    }
}

