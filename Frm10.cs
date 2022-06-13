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
    public partial class Frm10 : Form
    {
        public Frm10()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double IMC;
            IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                lblImc.Text = ("Abaixo do peso");

            }
            else if ((IMC >= 18.5) && (IMC < 25))
            {
                lblImc.Text = ("Peso normal");
            }
            else if ((IMC >= 25) && (IMC < 30))
            {
                lblImc.Text = ("Acima do Peso");
            }
            else { lblImc.Text = ("Obeso"); }
        }
    }
}
