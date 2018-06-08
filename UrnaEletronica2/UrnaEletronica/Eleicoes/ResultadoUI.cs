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
    public partial class ResultadoUI : Form
    {
        private List<ListaPrefeitos> listaPrefeitos;
        private List<ListaVereadores> listaVereadores;

        int totalVotosPrefeito = 0;

        public ResultadoUI()
        {
            listaPrefeitos = new List<ListaPrefeitos>();
            listaVereadores = new List<ListaVereadores>();
            InitializeComponent();

            populateListaPrefeitos();
            populateListaVereadores();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labels()
        {
            
        }

        private void populateListaPrefeitos()
        {
            int brancos = 0;
            int nulos = 0;
          
            foreach (Prefeito p in VirtualBD.getPrefeitos())
            {
                ListaPrefeitos l = new ListaPrefeitos();
               
                l.Nome = p.Nome;
                l.VicePrefeito = p.VicePrefeito.Nome;
                l.Numero = p.Codigo.ToString();

                brancos = 0;
                nulos = 0;

                foreach (Model.Urna u in VirtualBD.urnas)
                {
                    foreach(int v in u.VotosPrefeito)
                    {
                        if (v == p.Codigo)
                        {
                            l.Votos++;
                        }
                        else if (v == -1)
                            nulos++;
                        else if (v == 00)
                        {
                            brancos++;
                        }
                        totalVotosPrefeito++;
                    }
                }
                listaPrefeitos.Add(l);
            }

            listaPrefeitos = listaPrefeitos.OrderByDescending(o => o.Votos).ToList();

            if (isSegundoTurno())
                prefeito.Text = "Prefeito (vai para o 2º turno)";

            brancos_pref.Text = "Branco: " + brancos;
            nulos_pref.Text = "Nulo: " + nulos;
            prefeito_resultados.DataSource = listaPrefeitos;
        }

        private bool isSegundoTurno()
        {
            if (listaPrefeitos[0].Votos * 2 <= totalVotosPrefeito)
            {
                return true;
            }
            return false;
        }

        private void populateListaVereadores()
        {
            int brancos = 0;
            int nulos = 0;
           
            foreach (Vereador p in VirtualBD.getVereadores())
            {
                ListaVereadores l = new ListaVereadores();
                l.Nome = p.Nome;          
                l.Numero = p.Codigo.ToString();
                brancos = 0;
                nulos = 0;

                foreach (Model.Urna u in VirtualBD.urnas)
                {
                  /*  foreach (int v in u.VotosVereador)
                    {
                        if (v == p.Codigo)
                        {
                            l.Votos++;
                        }
                        else if (v == -1)
                        {
                            nulos++;                          
                        }
                        else if (v == 00)
                        {
                            brancos++;

                        }
                        
                    }*/
                }
                listaVereadores.Add(l);
            }
            brancos_ver.Text = "Branco: " + brancos;
            nulos_ver.Text = "Nulo: " + nulos;


            listaVereadores = listaVereadores.OrderByDescending(o => o.Votos).ToList();

            vereador_resultados.DataSource = listaVereadores;
        }

    }

    class ListaPrefeitos
    {
        public int Votos { get; set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string VicePrefeito { get; set; }
      
    }

    class ListaVereadores
    {
        public int Votos { get; set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        
       
    }
}
