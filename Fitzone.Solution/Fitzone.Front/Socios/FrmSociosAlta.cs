using Emgu.CV;
using Emgu.CV.Structure;
using Fitzone.Controller;
using Fitzone.Entidades;
using Fitzone.Front.Enumeraciones;
using Fitzone.Front.FormsExtras;
using ReaLTaiizor.Controls;
using System.ComponentModel;
using System.Data;

namespace Fitzone.Front.Socios
{
    public partial class FrmSociosAlta : Form
    {
        private VideoCapture _capture;
        private Mat _frame;
        public int _id_socio = 0;
        Socio? _socio;
        public EnumModoForm _EnumModoForm = EnumModoForm.Alta;

        #region redimensionar

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int BORDER_SIZE = 15; // Tamaño de los bordes para redimensionar
                                            //   // Funciones necesarias para permitir el movimiento del formulario
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);

                if (m.Msg == 0x84) // WM_NCHITTEST
                {
                    Point cursor = this.PointToClient(Cursor.Position);

                    if (cursor.X < BORDER_SIZE && cursor.Y < BORDER_SIZE)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (cursor.X < BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y < BORDER_SIZE)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (cursor.X > this.ClientSize.Width - BORDER_SIZE && cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else if (cursor.X < BORDER_SIZE)
                        m.Result = (IntPtr)HTLEFT;
                    else if (cursor.X > this.ClientSize.Width - BORDER_SIZE)
                        m.Result = (IntPtr)HTRIGHT;
                    else if (cursor.Y < BORDER_SIZE)
                        m.Result = (IntPtr)HTTOP;
                    else if (cursor.Y > this.ClientSize.Height - BORDER_SIZE)
                        m.Result = (IntPtr)HTBOTTOM;
                }
            }
            catch (Exception)
            {
            }

        }
        public void OnMouseDownForm(MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            try
            {
                base.OnMouseDown(e);
                // Permitir que el formulario se mueva cuando el usuario lo arrastre
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

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

        private async void FrmSociosAlta_Load(object sender, EventArgs e)
        {
            //            _EnumModoForm = EnumModoForm.Modificacion;
            //          _id_socio = 1;

            CargarBarrios();
            CargarDatosSocio();


            //habilitar en el sprint 2
            //_frame = new Mat();
            //await OperacionAsincrona();

        }

        private void LimpiarTodo()
        {
            _socio = new Socio();
            cmbBarrio.SelectedValue = _socio.idBarrio;

            txtMail.Text = _socio.mail;
            txtCalle.Text = _socio.calle;
            txtCalleNro.Text = _socio.calleNumero;

            txtNombre.Text = _socio.nombre;
            txtApellido.Text = _socio.apellido;
            txtNroDoc.Text = _socio.numeroDocumento;

            if (_socio.tipoDocumento == "DNI")
                rdbDNI.Checked = true;
            else
                rdbOtro.Checked = true;

            txtCelular.Text = _socio.telefono1;
            txtTelefono.Text = _socio.telefono2;

            _Validating(null,null);

            //imagen            
            //pictureBoxImagen.Image = ArrayBytesToImage(_socio.imagen);
        }

        private void CargarDatosSocio()
        {

            SocioController sc = new SocioController();
            _socio = sc.GetById(_id_socio);
            if (_socio == null)
                return;

            cmbBarrio.SelectedValue = _socio.idBarrio;

            txtMail.Text = _socio.mail;
            txtCalle.Text = _socio.calle;
            txtCalleNro.Text = _socio.calleNumero;

            txtNombre.Text = _socio.nombre;
            txtApellido.Text = _socio.apellido;
            txtNroDoc.Text = _socio.numeroDocumento;

            if (_socio.tipoDocumento == "DNI")
                rdbDNI.Checked = true;
            else
                rdbOtro.Checked = true;

            txtCelular.Text = _socio.telefono1;
            txtTelefono.Text = _socio.telefono2;

            //imagen            
            //pictureBoxImagen.Image = null;

            _Validating(null, null);
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

            if (_EnumModoForm == EnumModoForm.Alta)
            {
                _socio = new Socio();
                _socio.idSocio = 0;
            }

            if (_socio == null) return; //solo para quitar el warning

            _socio.idBarrio = ((Barrio)bindingSource1.Current).idBarrio;

            _socio.mail = txtMail.Text;
            _socio.anulado = false;

            _socio.calle = txtCalle.Text;
            _socio.calleNumero = txtCalleNro.Text;

            _socio.nombre = txtNombre.Text;
            _socio.apellido = txtApellido.Text;
            _socio.numeroDocumento = txtNroDoc.Text;
            if (rdbDNI.Checked)
                _socio.tipoDocumento = "DNI";
            else
                _socio.tipoDocumento = "OTRO";
            _socio.telefono1 = txtCelular.Text;
            _socio.telefono2 = txtTelefono.Text;

            //imagen            
            _socio.imagen = ImageToArrayBytes();

            // validaciones
            string mensajeErrores = "";
            if (!ValidarEmpleado(ref mensajeErrores, _socio))
            {
                //si falla alguna validacion muestro el mensaje y no hago nada mas
                //msg = new MessageBoxCustom(mensajeErrores, Enumeraciones.EnumModoMessageBoxCustom.SeEncontraronErrores);
                msg = new MessageBoxCustom("Verifique los campos obligatorios",EnumModoMessageBoxCustom.Aceptar);
                msg.ShowDialog();
                return;
            }

            //listo para guardar
            msg = new MessageBoxCustom(Enumeraciones.EnumModoMessageBoxCustom.ConfirmaGuardar);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                return;

            SocioController c = new SocioController();

            if (_EnumModoForm == EnumModoForm.Alta)
                c.Insert(_socio);

            if (_EnumModoForm == EnumModoForm.Modificacion)
                c.Update(_socio, _socio.idSocio);

            msg = new MessageBoxCustom("Se dió de alta el socio " + "("+_socio.idSocio.ToString()+") " + _socio.NombreCompleto + "\n¿Desea agregar uno nuevo?",EnumModoMessageBoxCustom.YesNo,50);
            msg.ShowDialog();
            if (msg.response == DialogResult.No)
                Close();

            LimpiarTodo();
            
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

        private void btnCamara_Click(object sender, EventArgs e)
        {
            ActivarCamara();
        }

        private void ActivarCamara()
        {
            if (_capture != null)
            {
                _capture.Dispose();
            }

            int indexCam = rdbCam1.Checked ? 0 : 1;

            _capture = new VideoCapture(indexCam);
            _capture.ImageGrabbed += ProcessFrame;
            _capture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);

                if (!_frame.IsEmpty)
                {
                    pictureBoxVideo.Image = BitmapExtension.ToBitmap(_frame);

                }
                //var imageByte = _frame.ToImage<Bgr, Byte>().ToJpegData();
                //var imageCapture = ByteArrayToImage(imageByte);
                //pictureBoxVideo.Image = imageCapture;
            }

        }

        private async Task OperacionAsincrona()
        {
            await Task.Run(() => ActivarCamara());
            lblCargandoCamara.Visible = false;

        }

        private void FrmSociosAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (lblCargandoCamara.Visible)
            {
                new MessageBoxCustom("Debe esperar a que inicie la cámara", Enumeraciones.EnumModoMessageBoxCustom.Aceptar).ShowDialog();
                return;
            }

            if (pictureBoxVideo.Image != null)
            {

                string filePath = Guid.NewGuid().ToString();
                Bitmap bitmap = _frame.ToImage<Bgr, Byte>().ToBitmap();                
                pictureBoxImagen.Image = bitmap;
            }
        }

        private byte[]? ImageToArrayBytes()
        {
            try
            {
                // Obtener la imagen del PictureBox
                Image image = pictureBoxImagen.Image;

                if (image != null)
                {
                    // Convertir la imagen a un objeto Bitmap
                    Bitmap bitmap = new Bitmap(image);

                    // Convertir el Bitmap a un arreglo de bytes
                    byte[] imageBytes;
                    using (MemoryStream stream = new MemoryStream())
                    {
                        // Guardar el Bitmap en el stream como un archivo PNG
                        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        // Obtener los bytes del stream
                        imageBytes = stream.ToArray();
                    }
                    return imageBytes;
                }
                else
                {
                    //MessageBox.Show("No hay imagen en el PictureBox.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen a bytes: " + ex.Message);
            }
            return null;
        }
       
        private Image? ArrayBytesToImage(byte[]? bytes)
        {
            if (bytes == null)
                return null;

            try
            {
                // Suponiendo que imageBytes es el byte[] que contiene los datos de la imagen
                byte[] imageBytes = bytes; // Puedes definir esta función según de dónde provengan los bytes

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    // Crear un MemoryStream a partir de los bytes
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Crear un objeto Image desde el MemoryStream
                        Image image = Image.FromStream(ms);
                        // Mostrar la imagen en el PictureBox
                        return image;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir y mostrar la imagen desde los bytes: " + ex.Message);
                return null;
            }
        }

        private async void rdbCam2_CheckedChanged(object sender, EventArgs e)
        {
            //await OperacionAsincrona();
        }

        private async void rdbCam1_CheckedChanged(object sender, EventArgs e)
        {
            //await OperacionAsincrona();
        }

        private void ucAgregar1__ClickUCAgregar(object sender, EventArgs e)
        {
            new MessageBoxCustom(EnumModoMessageBoxCustom.Proximamente).ShowDialog();
            return;
        }
    }
}

