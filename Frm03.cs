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
    public partial class Frm03 : Form
    {
        public Frm03()
        {
            InitializeComponent();
        }

        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == "admin") && (txtSenha.Text == "1234"))
            {
                MessageBox.Show("ACESSO PERMITIDO");
            }
            else {
                MessageBox.Show("ACESSO NEGADO");
            }
        }


    }
}
