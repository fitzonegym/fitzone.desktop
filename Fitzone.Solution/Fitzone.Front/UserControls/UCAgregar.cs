namespace Fitzone.Front.UserControls
{
    public partial class UCAgregar : UserControl
    {
        public event EventHandler _ClickUCAgregar;

        public UCAgregar()
        {
            InitializeComponent();
            pictureBox1.Click += Picture_Click;
        }      

        private void Picture_Click(object sender, EventArgs e)
        {
            // Lanza el evento cuando se hace clic en el control
            OnClickEnControl(EventArgs.Empty);
        }

        protected virtual void OnClickEnControl(EventArgs e)
        {
            _ClickUCAgregar?.Invoke(this, e);
        }
    }
}
