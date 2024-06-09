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
    public partial class FrmWait : Form
    {
        public FrmWait()
        {
            InitializeComponent();
            lblMensaje2.Text = "Cargando datos...";
        }

        private async Task CargarDatosEnSegundoPlano()
        {
            lblMensaje2.Text = "Cargando datos...";
            // Ejecutar una operación en segundo plano
            await Task.Run(() => OperacionLargaDuracion());
        }

        private void OperacionLargaDuracion()
        {
            lblMensaje2.Text = "Cargando datos...";
        }

        private async void FrmWait_Load(object sender, EventArgs e)
        {
            lblMensaje2.Text = "Cargando datos...";
            await CargarDatosEnSegundoPlano();
        }
    }
}
