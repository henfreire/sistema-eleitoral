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
    public partial class TituloEleitor : Form
    {
        public TituloEleitor()
        {
            InitializeComponent();
        }

        private void finalizar_eleicoes_Click(object sender, EventArgs e)
        {
            Eleicoes.ResultadoUI view = new Eleicoes.ResultadoUI();
            view.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fim_eleicao);
            view.ShowDialog();

        }
        private void fim_eleicao(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (titulo_input.Text.Length < 1)
            {
                MessageBox.Show("Título de eleitor inválido", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            foreach (Model.Eleitor el in VirtualBD.eleitores)
            {
                if (el.Titulo_de_eleitor.Equals(titulo_input.Text))
                {
                    if (el.JaVotou)
                    {
                        MessageBox.Show("Esse eleitor já votou", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        el.JaVotou = true;
                        Eleicoes.DadosEleitorUI view = new Eleicoes.DadosEleitorUI(el);
                        view.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
                        view.ShowDialog();
                        return;
                    }
                }
            }
            MessageBox.Show("Título de eleitor não cadastrado", "Eleição", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }



        private void crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            titulo_input.Text = "";
        }

        private void titulo_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
