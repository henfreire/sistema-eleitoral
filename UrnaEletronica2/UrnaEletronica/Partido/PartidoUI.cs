using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class PartidoUI : Form
    {
        public PartidoUI()
        {
       
            InitializeComponent();

            VirtualBD.partidos.Add(new UrnaEletronica.Partido("TT", 10, "Teste"));
            lista_partidos.DataSource = VirtualBD.partidos;

        }

        private void lista_partidos_SelectionChanged(object sender, EventArgs e)
        {
    
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            if (number_partido_input.Text.Length < 2)
            {
                MessageBox.Show("Número inválido", "Partido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Partido p in VirtualBD.partidos)
                {
 
                    if (int.Parse(number_partido_input.Text) == p.Numero)
                    {
                        PartidoCrud pc = new PartidoCrud(p);

                        pc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
                        pc.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Partido não encontrado.", "Partido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } 
        }

       

        private void adicionar_Click(object sender, EventArgs e)
        {
            PartidoCrud pc = new PartidoCrud();
            pc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
            pc.ShowDialog();
        }
     


        private void crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UPDATE VIEW
            lista_partidos.DataSource = null;
            lista_partidos.Update();
            lista_partidos.Refresh();
            lista_partidos.DataSource = VirtualBD.partidos;
        }

        private void excluir_Click(object sender, EventArgs e)
        {

            if (lista_partidos.SelectedRows.Count == 1)
            {
                if (VirtualBD.isPartidoBeingUsed(VirtualBD.partidos[lista_partidos.CurrentRow.Index]))
                {
                    MessageBox.Show("Esse partido possui candidatos cadastrados", "Partido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                VirtualBD.partidos.RemoveAt(lista_partidos.CurrentRow.Index);

                //UPDATE VIEW
                lista_partidos.DataSource = null;
                lista_partidos.Update();
                lista_partidos.Refresh();
                lista_partidos.DataSource = VirtualBD.partidos;
            }
            else {
                MessageBox.Show("Selecione um partido", "Partido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void update(object sender, EventArgs e)
        {
            lista_partidos.Update();
        }

        private void number_partido_input_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
