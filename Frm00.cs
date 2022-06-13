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
    public partial class Frm00 : Form
    {
        public Frm00()
        {
            InitializeComponent();
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            Frm01 frm01 = new Frm01();
            this.Hide();
            frm01.ShowDialog();
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            Frm02 frm02 = new Frm02();
            this.Hide();
            frm02.ShowDialog();
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            Frm03 frm03 = new Frm03();
            this.Hide();
            frm03.ShowDialog();
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            Frm04 frm04 = new Frm04();
            this.Hide();
            frm04.ShowDialog();
        }

        private void btnQ5_Click(object sender, EventArgs e)
        {
            Frm05 frm05 = new Frm05();
            this.Hide();
            frm05.ShowDialog();
        }

        private void btnQ6_Click(object sender, EventArgs e)
        {
            Frm07 frm07 = new Frm07();
            this.Hide();
            frm07.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm08 frm08 = new Frm08();
            this.Hide();
            frm08.ShowDialog();
        }

        private void btnQ9_Click(object sender, EventArgs e)
        {
            Frm09 frm09 = new Frm09();
            this.Hide();
            frm09.ShowDialog();
        }

        private void btnQ6_Click_1(object sender, EventArgs e)
        {
            Frm06 frm06 = new Frm06();
            this.Hide();
            frm06.ShowDialog();
        }

        private void btnQ10_Click(object sender, EventArgs e)
        {
            Frm10 frm10 = new Frm10();
            this.Hide();
            frm10.ShowDialog();
        }

        private void btnQ11_Click(object sender, EventArgs e)
        {
            Frm11 frm11 = new Frm11();
            this.Hide();
            frm11.ShowDialog();
        }

        private void btnQ12_Click(object sender, EventArgs e)
        {
             Frm12 frm12 = new Frm12();
            this.Hide();
            frm12.ShowDialog();
        }
    }
}
