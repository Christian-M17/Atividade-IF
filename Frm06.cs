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
    public partial class Frm06 : Form
    {
        public Frm06()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int lados= int.Parse(txtQtd.Text);

            switch (lados)
            {
                case 3:
                    lblForma.Text = "A forma é um triângulo";
                    break;
                case 4:
                    lblForma.Text = "A forma é um quadrado";
                    break;
                default:
                    MessageBox.Show("Digite um número válido");
                    lblForma.Text = "A forma é um erro!";
                    break;
            }
        }
    }
}
