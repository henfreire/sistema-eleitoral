using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MaterialSkin;
using MaterialSkin.Controls;

namespace UrnaEletronica.Urna
{
    public partial class UrnaUI : MaterialForm
    {
        private List<ListaUrnas> listaUrnas;
        public UrnaUI()
        {
            InitializeComponent();
            updateView();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (secao_input.Text.Length < 1 || zona_input.Text.Length < 1)
            {
                MessageBox.Show("Dados da urna inválidos", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Model.Urna u in VirtualBD.urnas)
                {

                    if (u.Secao.Equals(secao_input.Text) && u.Zona.Equals(zona_input.Text))
                    {
                        VirtualBD.urnas.Remove(u);
                        updateView();
                        return;
                    }
                }
                MessageBox.Show("Urna não cadastrada.", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            if (secao_input.Text.Length < 1 || zona_input.Text.Length < 1)
            {
                MessageBox.Show("Dados da urna inválidos", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (Model.Urna u in VirtualBD.urnas)
                {

                    if (u.Secao.Equals(secao_input.Text) && u.Zona.Equals(zona_input.Text))
                    {
                        Urna.UrnaCRUD urna = new Urna.UrnaCRUD(u);

                        urna.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
                        urna.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Urna não cadastrada.", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            UrnaCRUD view = new UrnaCRUD();
            view.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.crud_FormClosed);
            view.ShowDialog();
        }

        private void crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UPDATE VIEW
            updateView();
            zona_input.Text = "";
            secao_input.Text = "";
        }

        public void updateView()
        {
            lista_urnas.DataSource = null;
            convertUrnasEmListaParaExibir();
            lista_urnas.Update();
            lista_urnas.Refresh();
            lista_urnas.DataSource = listaUrnas;
        }

        private void convertUrnasEmListaParaExibir()
        {
            listaUrnas = new List<ListaUrnas>();
            foreach (Model.Urna u in VirtualBD.urnas)
            {
                ListaUrnas l = new ListaUrnas();
                l.Secao = u.Secao;
                l.Zona = u.Zona;

                listaUrnas.Add(l);
            }
        }



    }
    class ListaUrnas
    {
   
        public string Zona { get; set; }
        public string Secao { get; set; }
    }
}
