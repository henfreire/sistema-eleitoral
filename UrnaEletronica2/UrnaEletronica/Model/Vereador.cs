using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class Vereador: Model.Candidato, Cadastravel
    {

        public Vereador(int codigo, string nome, string email, DateTime nascimento, Partido partido) : base(codigo, nome, email, nascimento, partido)
        {
        }

        public Vereador()
        {
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
