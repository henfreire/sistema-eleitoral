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
    public partial class PrefeitoUI : Form
    {
        private int index;
        public PrefeitoUI(int i)
        {
            index = i;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                return;
            if (textBox1.Text.Equals(""))
            {
                VirtualBD.urnas[index].VotosPrefeito.Add(-1);
                MessageBox.Show("Voto confirmado. Nulo","Prefeito" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else if (textBox1.Text.Equals("00"))
            {
                VirtualBD.urnas[index].VotosPrefeito.Add(00);
                MessageBox.Show("Voto confirmado. Branco", "Prefeito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                foreach (Prefeito p in VirtualBD.getPrefeitos())
                {
                    if (p.Codigo == int.Parse(textBox1.Text))
                    {
                        VirtualBD.urnas[index].VotosPrefeito.Add(p.Codigo);
                        MessageBox.Show("Voto confirmado. Prefeito " + p.Nome + "\nCódigo " + p.Codigo + "\n Vice: " + p.VicePrefeito.Nome, "Prefeito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Nenhum prefeito cadastrado com esse código", "Prefeito", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
