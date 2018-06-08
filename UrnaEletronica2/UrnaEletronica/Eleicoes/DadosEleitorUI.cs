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
    public partial class DadosEleitorUI : Form
    {

        private bool voto_prefeito = false;
        private bool voto_vereador = false;
        Model.Eleitor eleitor;
        public DadosEleitorUI()
        {
            InitializeComponent();
        }

        public DadosEleitorUI(Model.Eleitor e)
        {
            eleitor = e;
            InitializeComponent();

            nome_label.Text = eleitor.Nome;
            zona_label.Text = eleitor.Zona;
            secao_label.Text = eleitor.Secao;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VirtualBD.urnas.Count; i++)
            {
                if (VirtualBD.urnas[i].Zona.Equals(zona_label.Text) && VirtualBD.urnas[i].Secao.Equals(secao_label.Text))
                {
                    Eleicoes.PrefeitoUI view = new Eleicoes.PrefeitoUI(i);
                    view.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prefeito_FormClosed);
                    view.ShowDialog();
                }
            }
        }



        private void prefeito_FormClosed(object sender, FormClosedEventArgs e)
        {
            voto_prefeito = true;
            button3.Enabled = false;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VirtualBD.urnas.Count; i++)
            {
                if (VirtualBD.urnas[i].Zona.Equals(zona_label.Text) && VirtualBD.urnas[i].Secao.Equals(secao_label.Text))
                {
                    Eleicoes.VereadorUI view = new Eleicoes.VereadorUI(i);
                    view.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vereador_FormClosed);
                    view.ShowDialog();
                }
            } 
        }

        private void vereador_FormClosed(object sender, FormClosedEventArgs e)
        {
            voto_vereador = true;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!voto_vereador)
            {
                for (int i = 0; i < VirtualBD.urnas.Count; i++)
                {
                    if (VirtualBD.urnas[i].Zona.Equals(zona_label.Text) && VirtualBD.urnas[i].Secao.Equals(secao_label.Text))
                    {
                        VirtualBD.urnas[i].VotosVereador.Add(-1);
                    }
                }
            }

            if (!voto_prefeito)
            {
                for (int i = 0; i < VirtualBD.urnas.Count; i++)
                {
                    if (VirtualBD.urnas[i].Zona.Equals(zona_label.Text) && VirtualBD.urnas[i].Secao.Equals(secao_label.Text))
                    {
                        VirtualBD.urnas[i].VotosPrefeito.Add(-1);
                    }
                }
            }

     

            this.Close();
        }
    }
}
