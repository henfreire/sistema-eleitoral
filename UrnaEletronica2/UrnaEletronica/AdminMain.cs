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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void Partido_Click(object sender, EventArgs e)
        {
            PartidoUI pc = new PartidoUI();
            pc.ShowDialog();
        }

        private void Candidato_Click(object sender, EventArgs e)
        {
            CandidatoUI view = new CandidatoUI();
            view.ShowDialog();
        }

        private void Eleitor_Click(object sender, EventArgs e)
        {
            Eleitor.EleitorUI view = new Eleitor.EleitorUI();
            view.ShowDialog();
        }

        private void Urna_Click(object sender, EventArgs e)
        {
            Urna.UrnaUI view = new Urna.UrnaUI();
            view.ShowDialog();
        }
    }
}
