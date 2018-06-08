using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class Prefeito : Model.Candidato, Cadastravel
    {
        private VicePrefeito vicePrefeito;

        public Prefeito(VicePrefeito vicePrefeito,int codigo, string nome, string email, DateTime nascimento, Partido partido) : base(codigo, nome, email, nascimento, partido)
        {
            this.VicePrefeito = vicePrefeito;
        }
        public Prefeito() { }

        internal VicePrefeito VicePrefeito
        {
            get
            {
                return vicePrefeito;
            }

            set
            {
                vicePrefeito = value;
            }
        }

        public string formatToSave()
        {
            throw new NotImplementedException();
        }

        public bool jaCadastrado()
        {
            throw new NotImplementedException();
        }
    }
}
