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
    public partial class Frm02 : Form
    {
        public Frm02()
        {
            InitializeComponent();
        }

        

        
        

       

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(txtAno.Text);
            int idade;
            idade = (2022 - ano);

            if (idade >= 16)
            {
                txtResultado.Text = "Pode votar";
            }
            if (idade < 16)
            {
                txtResultado.Text = "Não pode votar";
            }
        }


    }
}
