using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provaofc_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Buscar_Produto = new Form5();
            Buscar_Produto.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 Inserir_Produto = new Form1();
            Inserir_Produto.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 Venda = new Form7();
            Venda.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 Inserir_Funcionario = new Form2();
            Inserir_Funcionario.Show();
            this.Hide();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form3 Editar_Funcionario = new Form3();
            Editar_Funcionario.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 Venda = new Form6();
            Venda.Show();
            this.Hide();

        }
    }
}
