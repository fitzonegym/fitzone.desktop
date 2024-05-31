using Fitzone.Front.Enumeraciones;
using System;
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

    public partial class MessageBoxCustom : Form
    {
        public DialogResult response;
        EnumModoMessageBoxCustom _modo;
        string _mensaje;
        public MessageBoxCustom(string mensaje, EnumModoMessageBoxCustom modo)
        {
            InitializeComponent();
            _modo = modo;
            _mensaje = mensaje;
        }

        public MessageBoxCustom(EnumModoMessageBoxCustom modo)
        {            
            InitializeComponent();
            _modo = modo;            
        }

        private void MessageBoxCustom_Load(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo ||
                _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                btn1.TextButton = "Si";
                btn2.TextButton = "No";
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                btn1.TextButton = "Aceptar";
                btn2.TextButton = "Cancelar";
            }

            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente)
            {
                btn1.Visible = false;
                btn2.TextButton = "Aceptar";
            }

            if (_modo == EnumModoMessageBoxCustom.SeEncontraronErrores)
            {
                btn1.Visible = false;
                btn2.TextButton = "Aceptar";
                _mensaje = "Se encontraron los siguientes errores: \n" + _mensaje;
                this.Size = new Size(this.Width,this.Height+100);
            }

            lblMensaje2.Text = _mensaje;
            if (_modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
                lblMensaje2.Text = "¿Confirma guardar los datos?";
            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente)
                lblMensaje2.Text = "Los datos se guardaron correctamente";
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo
                || _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                response = DialogResult.Yes;
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                response = DialogResult.OK;
            }
            Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_modo == EnumModoMessageBoxCustom.YesNo
                || _modo == EnumModoMessageBoxCustom.ConfirmaGuardar)
            {
                response = DialogResult.No;
            }
            if (_modo == EnumModoMessageBoxCustom.AceptarCancelar)
            {
                response = DialogResult.Cancel;
            }
            if (_modo == EnumModoMessageBoxCustom.DatosGuardadosCorrectamente)
            {
                response = DialogResult.OK;
            }
            Close();
        }
    }
}
