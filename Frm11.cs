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
    public partial class Frm11 : Form
    {
        public Frm11()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txtPreco.Text);
            double precofinal= 0;

            if (txtPago.Text == "1")
            {
                precofinal = (preco - ((preco / 100) * 10));
                txtResultado.Text = ("R$ " + precofinal);
            }
            else if (txtPago.Text == "2")
            {
                precofinal= (preco - ((preco / 100) * 15));
                txtResultado.Text = ("R$ " + precofinal);
            }
            else if (txtPago.Text == "3")
            {
                precofinal = preco;
            }
            else if (txtPago.Text == "4")
            {
                precofinal = preco + ((preco / 100) *10);
            }
            txtResultado.Text = ("R$ " + precofinal);

            
        }
    }
}
