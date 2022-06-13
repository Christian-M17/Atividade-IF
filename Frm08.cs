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
    public partial class Frm08 : Form
    {
        public Frm08()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string sexo = txtSexo.Text;

            switch (sexo)
            {
                case "F":
                    MessageBox.Show("Sexo Feminino");
                    break;
                default:
                    MessageBox.Show("Sexo invalido pois é um programa para mulheres");
                    break;
            }
        }
    }
}
