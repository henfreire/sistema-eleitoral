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
    public partial class EleitorCRUD : Form
    {
        private const int CADASTRAR = 11;
        private const int EDITAR = 10;
        private int CRUD;

        private Model.Eleitor eleitor;
        public EleitorCRUD()
        {
            CRUD = CADASTRAR;
            InitializeComponent();
            init();
        }

        public EleitorCRUD(Model.Eleitor e)
        {
            CRUD = EDITAR;
            eleitor = e;
            InitializeComponent();
            nome.Text = e.Nome;
            titulo_de_eleitor.Text = e.Titulo_de_eleitor;
            titulo_de_eleitor.Enabled = false;
            init();


        }

        private void init()
        {
            secao.Enabled = false;
            updateDataZona();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zona_SelectedIndexChanged(object sender, EventArgs e)
        {
            secao.Enabled = true;
            updateDataSecao();
        }

        private void updateDataZona()
        {
            zona.DataSource = null;
            zona.DataSource = VirtualBD.getZonas();
            zona.Update();
            zona.Refresh();
        }

        private void updateDataSecao()
        {
            secao.DataSource = null;
            secao.DataSource = VirtualBD.getSecoes(zona.SelectedValue.ToString());
            secao.Update();
            secao.Refresh();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (CRUD == CADASTRAR)
                salvarCad();
            else if (CRUD == EDITAR)
                editarCad();
        }

        private void salvarCad()
        {
            for (int i = 0; i < VirtualBD.eleitores.Count; i++)
            {
                if (titulo_de_eleitor.Text.Equals(VirtualBD.eleitores[i].Titulo_de_eleitor))
                {
                    MessageBox.Show("Título de eleitor já cadastrado", "Eleitor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
            }
            Model.Eleitor e = new Model.Eleitor();
            e.Nome = nome.Text;
            e.Titulo_de_eleitor = titulo_de_eleitor.Text;
        
            e.Nascimento = data_nascimento.Value;
            e.Zona = VirtualBD.getZonas()[zona.SelectedIndex];
            e.Secao = VirtualBD.getSecoes(e.Zona)[secao.SelectedIndex];
            VirtualBD.eleitores.Add(e);
            this.Close();
        }

        private void editarCad()
        {
            for (int i = 0; i < VirtualBD.eleitores.Count; i++)
            {
                if (titulo_de_eleitor.Text.Equals(VirtualBD.eleitores[i].Titulo_de_eleitor))
                {
                    Model.Eleitor e = new Model.Eleitor();
                    e.Nome = nome.Text;
                    e.Titulo_de_eleitor = eleitor.Titulo_de_eleitor;
                    e.Nascimento = data_nascimento.Value;
                    e.Zona = VirtualBD.getZonas()[zona.SelectedIndex];
                    e.Secao = VirtualBD.getSecoes(e.Zona)[secao.SelectedIndex];

                    VirtualBD.eleitores[i] = e;
                    this.Close();
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
