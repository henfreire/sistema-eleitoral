using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica.Candidato
{
    public partial class CandidatoCRUD : Form
    {
        private const int CADASTRAR = 11;
        private const int EDITAR = 10;
        private int CRUD;
        private Model.Candidato candidato;

        private List<string> tipo_candidatos = new List<string>();
        private VicePrefeito vicePrefeitoSelecionado;
        private int tipoCandidatoSelecionado = 0;

      

        public CandidatoCRUD()
        {
            CRUD = CADASTRAR;

            InitializeComponent();
            //tipo candidatos
            tipo_candidatos.Add("Prefeito");
            tipo_candidatos.Add("Vice-prefeito");
            tipo_candidatos.Add("Vereador");   
            tipo_candidato.DataSource = tipo_candidatos;

            init();
        }

        public CandidatoCRUD(Model.Candidato c)
        {
            InitializeComponent();

            CRUD = EDITAR;
            candidato = c;

            data_nascimento.Value = candidato.Nascimento; ;
            partido_combo_box.Text = candidato.Partido.Nome;
            email.Text = candidato.Email;
            nome.Text = candidato.Nome;
            codigo_candidato.Enabled = false;
            tipo_candidato.Enabled = false;

            if (c is Prefeito)
                tipoCandidatoSelecionado = 0;
            else if (c is VicePrefeito)
                tipoCandidatoSelecionado = 1;
            else if (c is Vereador)
                tipoCandidatoSelecionado = 2;

            init();
        }

        public void init()
        {
            vice_prefeito.DataSource = VirtualBD.getVicePrefeitos();
            partido_combo_box.DataSource = VirtualBD.partidos;
        }


        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipoCandidatoSelecionado == 0) // Prefeito
                {
                    salvarPrefeito();
                }
                else if (tipoCandidatoSelecionado == 1) // Vice prefeito
                {
                    salvarVicePrefeito();
                }
                else if (tipoCandidatoSelecionado == 2) // Vereador
                {
                    salvarVereador();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        private void salvarPrefeito()
        {
            //EDITAR
            if (CRUD == EDITAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if (candidato.Nome.Equals(VirtualBD.candidatos[i].Nome) && candidato.Codigo == VirtualBD.candidatos[i].Codigo)
                    {
                        Prefeito p = new Prefeito();
                        p.Nome = nome.Text;
                        p.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                        p.Email = email.Text;
                        p.Nascimento = data_nascimento.Value;
                        p.Codigo = candidato.Codigo;
                        p.VicePrefeito = VirtualBD.getVicePrefeitos()[vice_prefeito.SelectedIndex];


                        VirtualBD.candidatos[i] = p;
                        this.Close();
                    }
                }
            }//CADASTRAR
            else if (CRUD == CADASTRAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if ( int.Parse(codigo_candidato.Text) == VirtualBD.candidatos[i].Codigo)
                    {
                        MessageBox.Show("Código já cadastrado", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                       
                    }
                }
                Prefeito p = new Prefeito();
                p.Nome = nome.Text;
                p.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                p.Email = email.Text;
                p.Nascimento = data_nascimento.Value;
                p.Codigo = int.Parse(codigo_candidato.Text);
                p.VicePrefeito = VirtualBD.getVicePrefeitos()[vice_prefeito.SelectedIndex];
                VirtualBD.candidatos.Add(p);
                this.Close();
            }
        }

        private void salvarVereador()
        {
            //EDITAR
            if (CRUD == EDITAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if (candidato.Nome.Equals(VirtualBD.candidatos[i].Nome) && candidato.Codigo == VirtualBD.candidatos[i].Codigo)
                    {
                        Vereador v = new Vereador();
                        v.Nome = nome.Text;
                        v.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                        v.Email = email.Text;
                        v.Nascimento = data_nascimento.Value;
                        v.Codigo = candidato.Codigo;
             


                        VirtualBD.candidatos[i] = v;
                        this.Close();
                    }
                }
            }//CADASTRAR
            else if (CRUD == CADASTRAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if (int.Parse(codigo_candidato.Text) == VirtualBD.candidatos[i].Codigo)
                    {
                        MessageBox.Show("Código já cadastrado", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;

                    }
                }
                Vereador v = new Vereador();
                v.Nome = nome.Text;
                v.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                v.Email = email.Text;
                v.Nascimento = data_nascimento.Value;
                v.Codigo = int.Parse(codigo_candidato.Text);
            
                VirtualBD.candidatos.Add(v);
                this.Close();
            }
        }

        private void salvarVicePrefeito()
        {
            //EDITAR
            if (CRUD == EDITAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if (candidato.Nome.Equals(VirtualBD.candidatos[i].Nome) )
                    {
                        VicePrefeito vp = new VicePrefeito();
                        vp.Nome = nome.Text;
                        vp.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                        vp.Email = email.Text;
                        vp.Nascimento = data_nascimento.Value;
                        vp.Codigo = candidato.Codigo;                      


                        VirtualBD.candidatos[i] = vp;
                        this.Close();
                    }
                }
            }//CADASTRAR
            else if (CRUD == CADASTRAR)
            {
                for (int i = 0; i < VirtualBD.candidatos.Count; i++)
                {
                    if (nome.Text.Equals(VirtualBD.candidatos[i].Nome))
                    {
                        MessageBox.Show("Vice prefeito já cadastrado", "Candidato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                VicePrefeito vp = new VicePrefeito();
                vp.Nome = nome.Text;
                vp.Partido = VirtualBD.partidos[partido_combo_box.SelectedIndex];
                vp.Email = email.Text;
                vp.Nascimento = data_nascimento.Value;
                //vp.Codigo = int.Parse(codigo_candidato.Text);        
                VirtualBD.candidatos.Add(vp);
                this.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipo_candidato_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo_candidato.Text = "";

            tipoCandidatoSelecionado = tipo_candidato.SelectedIndex;

            if (tipoCandidatoSelecionado == 0) // Prefeito
            {
                vice_prefeito.Show();
                vice_prefeito_label.Show();
                vice_prefeito.DataSource = VirtualBD.getVicePrefeitos();
                
                codigo_candidato.Enabled = true;
                codigo_candidato.MaxLength = 2;
            }
            else if (tipoCandidatoSelecionado == 1) // Vice prefeito
            {
                vice_prefeito.Hide();
                vice_prefeito_label.Hide();
                codigo_candidato.Enabled = false;
            }
            else if (tipoCandidatoSelecionado == 2) // Vereador
            {
                vice_prefeito.Hide();
                vice_prefeito_label.Hide();
                codigo_candidato.Enabled = true;
                codigo_candidato.MaxLength = 4;
            }
        }

        private void prefeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            vicePrefeitoSelecionado = VirtualBD.getVicePrefeitos()[vice_prefeito.SelectedIndex];
        }

        private void codigo_candidato_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigo_candidato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

    }

 

}
