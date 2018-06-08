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
    public partial class CandidatoUI : Form
    {

        private List<ListaCandidatos> listaCandidatos = new List<ListaCandidatos>();

        public CandidatoUI()
        {
            InitializeComponent();
            updateView();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (lista_candidatos.SelectedRows.Count == 1)
            {
                VirtualBD.candidatos.RemoveAt(lista_candidatos.CurrentRow.Index);
                updateView();  
            }
            else
            {
                MessageBox.Show("Selecione um candidato", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void updateView()
        {
            
            //UPDATE VIEW
            lista_candidatos.DataSource = null;
            converteListaCandidatosParaExibir();
            lista_candidatos.Update();
            lista_candidatos.Refresh();
            lista_candidatos.DataSource = listaCandidatos;
           // lista_candidatos.Refresh();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            Candidato.CandidatoCRUD cc = new Candidato.CandidatoCRUD();
            cc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
            cc.ShowDialog();
        }



        private void crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            nome_candidato_input.Text = "";
            updateView();
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            if (nome_candidato_input.Text.Length < 1)
            {
                MessageBox.Show("Nome do candidato inválido", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Model.Candidato c in VirtualBD.candidatos)
                {

                    if (c.Nome.Equals(nome_candidato_input.Text))
                    {
                        Candidato.CandidatoCRUD cand = new Candidato.CandidatoCRUD(c);

                        cand.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
                        cand.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Candidato não cadastrado.", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void number_candidato_input_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void converteListaCandidatosParaExibir()
        {
            listaCandidatos = new List<ListaCandidatos>();
            foreach (Model.Candidato c in VirtualBD.candidatos)
            {
                ListaCandidatos l = new ListaCandidatos();
                if (c.Codigo == 0) //Vice prefeito
                    l.Codigo = " ";
                else
                    l.Codigo = c.Codigo.ToString();

                l.Nome = c.Nome;
                listaCandidatos.Add(l);
            }
        }

        private void lista_candidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    public class ListaCandidatos
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

    }
}
