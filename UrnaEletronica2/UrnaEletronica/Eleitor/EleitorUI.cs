using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica.Eleitor
{
    public partial class EleitorUI : Form
    {
        private List<ListaEleitores> listaEleitores = new List<ListaEleitores>();
        public EleitorUI()
        {
            InitializeComponent();
            updateView();
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            if (titulo_pesquisa_input.Text.Length < 1)
            {
                MessageBox.Show("Título de eleitor inválido", "Eleitor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Model.Eleitor el in VirtualBD.eleitores)
                {
                    if (el.Nome.Equals(titulo_pesquisa_input.Text))
                    {
                        Eleitor.EleitorCRUD eleitor = new Eleitor.EleitorCRUD(el);

                        eleitor.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
                        eleitor.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Eleitor não cadastrado.", "Eleitor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (titulo_eleitor_excluir.Text.Length < 1)
            {
                MessageBox.Show("Título de eleitor inválido", "Eleitor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Model.Eleitor el in VirtualBD.eleitores)
                {

                    if (el.Nome.Equals(titulo_eleitor_excluir.Text))
                    {
                        VirtualBD.eleitores.Remove(el);
                        return;
                    }
                }
                MessageBox.Show("Eleitor não cadastrado.", "Eleitor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            EleitorCRUD pc = new EleitorCRUD();
            pc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
            pc.ShowDialog();
        }

        private void crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UPDATE VIEW
            updateView();
            titulo_pesquisa_input.Text = "";
            titulo_eleitor_excluir.Text = "";
        }

        public void updateView()
        {
            lista_eleitores.DataSource = null;
            convertEleitoresEmListaParaExibir();
            lista_eleitores.Update();
            lista_eleitores.Refresh();
            lista_eleitores.DataSource = listaEleitores;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertEleitoresEmListaParaExibir()
        {
            listaEleitores = new List<ListaEleitores>();
            foreach (Model.Eleitor e in VirtualBD.eleitores)
            {
                ListaEleitores l = new ListaEleitores();
                l.Nome = e.Nome;
                l.Titulo = e.Titulo_de_eleitor;
                listaEleitores.Add(l);
            }
        }

    }

    class ListaEleitores
    {
        public string Nome { get; set; }
        public string Titulo { get; set; }
    }
}
