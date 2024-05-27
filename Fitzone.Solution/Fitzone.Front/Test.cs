using Fitzone.Controller;
using Fitzone.Entidades;

namespace Fitzone.Front
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SocioController con = new SocioController();
                var socios = con.GetAll();

                MessageBox.Show(socios.ToString());
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnSocioInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = new Socio
                {
                    apellido = "Simpsons",
                    calle = "Siempre Viva",
                    calleNumero = "123",
                    idBarrio = 1,
                    mail = "bart@gmail.com",
                    nombre = "Bart",
                    numeroDocumento = "11144477",
                    telefono1 = "tel1",
                    telefono2 = "tel2",
                    tipoDocumento = "DNI"
                };

                SocioController con = new SocioController();
                con.Insert(socio);
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SocioController con = new SocioController();

            try
            {
                //obtengo el socio
                var socio = con.GetByName("Pao");

                //modifico algo
                socio.apellido = "lalala";
                socio.telefono2 = "351789456";

                if (!con.Update(socio, socio.idSocio))
                    MessageBox.Show("No se encontro el Id " + socio.idSocio);

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SocioController con = new SocioController();

            try
            {
                if (con.Anular(2))
                    MessageBox.Show("El socio [2] se anulo");
                else
                    MessageBox.Show("El socio [2] no se encontro o no se pudo anular");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SocioController con = new SocioController();

            try
            {
                if (con.Delete(2))
                    MessageBox.Show("El socio [2] se borro definitivamente");
                else
                    MessageBox.Show("El socio [2] no se encontro o no se pudo eliminar");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
