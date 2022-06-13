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
    public partial class Frm05 : Form
    {
        public Frm05()
        {
            InitializeComponent();
        }

       

       
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(txtPreco.Text);
            float pago = float.Parse(txtPago.Text);
            float troco;
            if (pago > preco)
            { troco = pago - preco;
                txtTroco.Text = ("R$ " + troco);
            }
            else if (pago < preco)
            {
                troco = preco - pago;
                MessageBox.Show("DEVENDO R$ " + troco);
            }
            else
            {
                troco = 0;
                txtTroco.Text = ("Valor exato");
            }
        }
    }
}
