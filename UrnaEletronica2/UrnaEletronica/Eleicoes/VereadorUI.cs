using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica.Eleicoes
{
    public partial class VereadorUI : Form
    {
        private int index;
        public VereadorUI(int i)
        {
            index = i;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                return;
            if (textBox1.Text.Equals(""))
            {
                VirtualBD.urnas[index].VotosVereador.Add(-1);
                MessageBox.Show("Voto confirmado. Nulo", "Vereador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else if (textBox1.Text.Equals("00"))
            {
                VirtualBD.urnas[index].VotosVereador.Add(00);
                MessageBox.Show("Voto confirmado. Branco", "Vereador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                foreach (Vereador v in VirtualBD.getVereadores())
                {
                    if (v.Codigo == int.Parse(textBox1.Text))
                    {
                        VirtualBD.urnas[index].VotosVereador.Add(v.Codigo);
                        MessageBox.Show("Voto confirmado. Vereador "+v.Nome+"\nCódigo "+v.Codigo, "Vereador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Nenhum vereador cadastrado com esse código", "Vereador", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
