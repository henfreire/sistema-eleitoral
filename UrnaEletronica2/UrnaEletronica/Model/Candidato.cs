using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Model
{
    public class Candidato 
    {
        private int codigo;
        private string nome;
        private string email;
        private DateTime nascimento;
        private Partido partido;

        public Candidato() { }
        
        public Candidato(int codigo, string nome, string email, DateTime nascimento, Partido partido)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.email = email;
            this.nascimento = nascimento;
            this.partido = partido;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public Partido Partido
        {
            get
            {
                return partido;
            }

            set
            {
                partido = value;
            }
        }

    }
}
