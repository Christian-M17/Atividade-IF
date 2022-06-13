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
    public partial class Frm01 : Form
    {
        public Frm01()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            if (num1 > num2)
            {
                txtResultado.Text = "Número 1 maior que número 2";

            }
            if (num1 < num2)
            {
                txtResultado.Text = "Número 2 maior que número 1";
            }
            if (num1 == num2)
            {
                txtResultado.Text = "Os números são iguais";
            }
        }

        private void quesrtao05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm05 frm05 = new Frm05();
            this.Hide();
            frm05.ShowDialog();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm06 frm06 = new Frm06();
            this.Hide();
            frm06.ShowDialog();
        }
    }
}
