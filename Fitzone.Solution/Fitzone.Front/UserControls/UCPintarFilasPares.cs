using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitzone.Front.UserControls
{
    public partial class UCPintarFilasPares : UserControl
    {

        public DataGridView _dataGridView {  get; set; } = new DataGridView();
        public UCPintarFilasPares()
        {
            InitializeComponent();
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (e.RowIndex % 2 == 0) // Si es una fila par
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(209, 196, 234); // Cambia el color de fondo
            }
        }

        private void UCPintarFilasPares_Load(object sender, EventArgs e)
        {
            _dataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);
            //this.Visible = false;
        }
    }
}
