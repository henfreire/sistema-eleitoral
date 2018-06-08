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
    public partial class UrnaCRUD : MaterialForm
    {
        private const int CADASTRAR = 11;
        private const int EDITAR = 10;
        private int CRUD;

        private Model.Urna urna;
        public UrnaCRUD()
        {
            CRUD = CADASTRAR;
            InitializeComponent();
          
        }

        public UrnaCRUD(Model.Urna u)
        {
            CRUD = EDITAR;
            urna = u;
            InitializeComponent();

            zona.Enabled = false;
            secao.Enabled = false;
            abertura.Value = u.Abertura;
            fechamento.Value = u.Fechamento;
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
            if (secao.Text.Length < 1 || zona.Text.Length < 1)
            {
                MessageBox.Show("Dados inválidos", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            for (int i = 0; i < VirtualBD.urnas.Count; i++)
            {
                if (secao.Text.Equals(VirtualBD.urnas[i].Secao) && zona.Text.Equals(VirtualBD.urnas[i].Zona))
                {
                    MessageBox.Show("Urna já cadastrado", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
            }
            Model.Urna u = new Model.Urna();         
            u.Abertura = abertura.Value;
            u.Fechamento = fechamento.Value;
            u.Zona = zona.Text;
            u.Secao = secao.Text;
            VirtualBD.urnas.Add(u);
            this.Close();
        }

        private void editarCad()
        {
            for (int i = 0; i < VirtualBD.urnas.Count; i++)
            {
                if (urna.Secao.Equals(VirtualBD.urnas[i].Secao) && urna.Zona.Equals(VirtualBD.urnas[i].Zona))
                {
                    Model.Urna u = new Model.Urna();
                    u.Abertura = abertura.Value;
                    u.Fechamento = fechamento.Value;
                    u.Zona = urna.Zona;
                    u.Secao = urna.Secao;
                    VirtualBD.urnas[i] =u;
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
