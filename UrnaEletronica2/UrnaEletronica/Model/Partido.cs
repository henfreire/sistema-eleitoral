using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    public class Partido : Cadastravel
    {
        private string sigla;
        private int numero;
        private string nome;

        public Partido() { }

        public Partido(string sigla, int numero, string nome)
        {
            this.sigla = sigla;
            this.numero = numero;
            this.nome = nome;
        }

        public string Sigla
        {
            get
            {
                return sigla;
            }

            set
            {
                sigla = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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

        public bool jaCadastrado()
        {
            throw new NotImplementedException();
        }

        public string formatToSave()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return Sigla;
        }
    }

    
}
