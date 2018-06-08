using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Urna
    {
        private string zona;
        private string secao;
        private DateTime abertura;
        private DateTime fechamento;
        private List<int> votosPrefeito  = new List<int>();
        private List<int> votosVereador = new List<int>();

        public string Zona
        {
            get
            {
                return zona;
            }

            set
            {
                zona = value;
            }
        }

        public string Secao
        {
            get
            {
                return secao;
            }

            set
            {
                secao = value;
            }
        }

        public DateTime Abertura
        {
            get
            {
                return abertura;
            }

            set
            {
                abertura = value;
            }
        }

        public DateTime Fechamento
        {
            get
            {
                return fechamento;
            }

            set
            {
                fechamento = value;
            }
        }

        public List<int> VotosPrefeito
        {
            get
            {
                return votosPrefeito;
            }

            set
            {
                votosPrefeito = value;
            }
        }

        public List<int> VotosVereador
        {
            get
            {
                return votosVereador;
            }

            set
            {
                votosVereador = value;
            }
        }
    }
}
