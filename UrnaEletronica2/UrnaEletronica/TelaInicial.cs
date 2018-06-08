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

namespace UrnaEletronica
{
    public partial class TelaInicial : MaterialForm
    {
        public TelaInicial()
        {
            InitializeComponent();

            notifyIcon1.BalloonTipTitle = "Início da urna eletrônica";
            notifyIcon1.BalloonTipText = "Bem vindo ao nosso sistema !";
            notifyIcon1.ShowBalloonTip(0);
        }

   

        private void adm_Click(object sender, EventArgs e)
        {
           
        }

        private void eleicoes_Click(object sender, EventArgs e)
        {
           
        }

        private void adm_Click_1(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleicoes.TituloEleitor view = new Eleicoes.TituloEleitor();
            view.ShowDialog();
        }
    }
}
