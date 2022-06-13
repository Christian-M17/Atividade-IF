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
    public partial class Frm04 : Form
    {
        public Frm04()
        {
            InitializeComponent();
        }

        

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int qtdMacas = int.Parse(txtQtd.Text);
            double preco;

            if (qtdMacas <= 12)
            {
                preco = 0.30;
            }
            else
            {
                preco = 0.25;
            }

            lblPreco.Text = "O preço é de: R$" + (qtdMacas * preco);
        }

        
    }
}
