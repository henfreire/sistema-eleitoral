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
    public partial class PartidoCrud : Form
    {
        private const int CADASTRAR = 11;
        private const int EDITAR = 10;
        private int CRUD;
        Partido partido;
        public PartidoCrud()
        {
            CRUD = CADASTRAR;
            partido = new Partido();
            InitializeComponent();
        }
        public PartidoCrud(Partido p)
        {
            CRUD = EDITAR;

            partido = p;
            InitializeComponent();
            nome_partido.Text = p.Nome;
            numero_partido.Text = p.Numero.ToString();
            sigla_partido.Text = p.Sigla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (CRUD == CADASTRAR)
                cadastrar();
            else if (CRUD == EDITAR)
                editar();
        }

        private void cadastrar() {
            foreach (Partido p in VirtualBD.partidos)
            {
                if (sigla_partido.Text.Equals(p.Nome))
                {
                    return;
                }
                if (int.Parse(numero_partido.Text) == p.Numero)
                {
                    return;
                }
            }

            try
            {
                partido.Nome = nome_partido.Text;
                partido.Sigla = sigla_partido.Text;
                partido.Numero = int.Parse(numero_partido.Text);
                VirtualBD.partidos.Add(partido);
                this.Close();

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void editar()
        {
            try
            {
                for (int i = 0; i< VirtualBD.partidos.Count; i++)
                {
                    if (partido.Sigla.Equals(VirtualBD.partidos[i].Sigla))
                    {
                        partido.Nome = nome_partido.Text;
                        partido.Sigla = sigla_partido.Text;
                        partido.Numero = int.Parse(numero_partido.Text);
                        VirtualBD.partidos[i] = partido;
                        this.Close();
                    }
                }     
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void numero_partido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
