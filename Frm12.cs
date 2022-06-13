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
    public partial class Frm12 : Form
    {
        public Frm12()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);
            int nota4 = int.Parse(txtNota4.Text);
            float media = (nota1 + nota2 + nota3 + nota4) / 4;

            string aluno1 = "";
            string aluno2 = "";
            string aluno3 = "";
            string aluno4 = "";

            if (nota1 < media) { aluno1 = txtAluno1.Text + " "; }
            if (nota2 < media) { aluno2 = txtAluno2.Text + " "; }
            if (nota3 < media) { aluno3 = txtAluno3.Text + " "; }
            if (nota4 < media) { aluno4 = txtAluno4.Text + " "; }

            MessageBox.Show("A média foi de " + media + " Os alunos: " + aluno1 + aluno2 + aluno3 + aluno4 + "Perderam média");
        }
    }
}

