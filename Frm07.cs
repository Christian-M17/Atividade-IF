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
    public partial class Frm07 : Form
    {
        public Frm07()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            string sexo = txtSexo.Text;
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float pesoideal;

            switch (sexo)
            {
                case "F":
                    pesoideal = (float)((peso * altura) - 44.7);
                    lblPesoideal.Text = ("Peso ideal: " + pesoideal);
                    break;
                case "M":
                    pesoideal = (float)((peso * altura) - 58);
                    lblPesoideal.Text = ("Peso ideal: " + pesoideal);
                    break;
                default:
                    MessageBox.Show("Sexo Invalido, verifique se está escrito com letra maiuscula");
                    break;
            }
            }
        }
    }
