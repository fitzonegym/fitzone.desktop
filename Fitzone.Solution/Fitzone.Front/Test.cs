using Fitzone.Controller;
using Fitzone.Entidades;

namespace Fitzone.Front
{
    public partial class Test : Form
    {
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = -20;
        private const int WM_NCPAINT = 0x85;
        private const int WM_NCCALCSIZE = 0x83;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool GetLayeredWindowAttributes(IntPtr hwnd, out uint crKey, out byte bAlpha, out uint dwFlags);
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT || m.Msg == WM_NCCALCSIZE)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if (hdc != IntPtr.Zero)
                {
                    using (Graphics g = Graphics.FromHdc(hdc))
                    {
                        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                        g.DrawRectangle(Pens.Red, rect); // Cambiar el color del borde
                    }
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }

        public Test()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Blue; // Cambiar el color de fondo del formulario
            this.ForeColor = Color.White; // Cambiar el color del texto de la barra de título

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
