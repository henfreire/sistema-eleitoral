using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Eleitor : Cadastravel
    {
        private string nome;
        private DateTime nascimento;
        private string titulo_de_eleitor;
        private string zona;
        private string secao;
        private bool jaVotou = false;

        public Eleitor() { }

        public Eleitor(string nome, DateTime nascimento, string titulo_de_eleitor, string zona, string secao)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.titulo_de_eleitor = titulo_de_eleitor;
            this.zona = zona;
            this.secao = secao;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }

        public string Titulo_de_eleitor
        {
            get
            {
                return titulo_de_eleitor;
            }

            set
            {
                titulo_de_eleitor = value;
            }
        }

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

        public bool JaVotou
        {
            get
            {
                return jaVotou;
            }

            set
            {
                jaVotou = value;
            }
        }

        public bool jaCadastrado()
        {
            throw new NotImplementedException();
        }

        public string formatToSave()
        {
            throw new NotImplementedException();
        }
    }
}
