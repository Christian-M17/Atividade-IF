using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicio01_IF
{
    public partial class Frm09 : Form
    {
        public Frm09()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            float num = int.Parse(txtNum.Text);
            if (num > 0)
            {
                MessageBox.Show("Número Positivo");
            }
            else if (num == 0)
            {
                MessageBox.Show("Número Negativo");
            }
            else
            {
                MessageBox.Show("Número nulo");
            }
        }
    }
}
