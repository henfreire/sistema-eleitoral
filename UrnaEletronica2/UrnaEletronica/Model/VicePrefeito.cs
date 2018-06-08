using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class VicePrefeito : Model.Candidato, Cadastravel
    {
        public VicePrefeito(int codigo, string nome, string email, DateTime nascimento, Partido partido):base(codigo, nome, email, nascimento, partido)
        {
            
        }

        public VicePrefeito() { }

        public string formatToSave()
        {
            throw new NotImplementedException();
        }

        public bool jaCadastrado()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
