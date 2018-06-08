using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    static class VirtualBD
    {
        public static List<Partido> partidos = new List<Partido>();
        public static List<Model.Candidato> candidatos = new List<Model.Candidato>();
        public static List<Model.Eleitor> eleitores = new List<Model.Eleitor>();
        public static List<Model.Urna> urnas = new List<Model.Urna>();

        public static List<Prefeito> getPrefeitos() {
            List<Prefeito> l = new List<Prefeito>();
            foreach (Model.Candidato c in candidatos)
            {
                if (c is Prefeito)
                    l.Add((Prefeito)c);
            }
            return l;
        }

        public static List<VicePrefeito> getVicePrefeitos()
        {
            List<VicePrefeito> l = new List<VicePrefeito>();
            foreach (Model.Candidato c in candidatos)
            {
                if (c is VicePrefeito)
                    l.Add((VicePrefeito)c);
            }
            return l;
        }

        public static List<Vereador> getVereadores()
        {
            List<Vereador> l = new List<Vereador>();
            foreach (Model.Candidato c in candidatos)
            {
                if (c is Vereador)
                    l.Add((Vereador)c);
            }
            return l;
        }

        public static bool isPartidoBeingUsed(Partido p)
        {
            foreach (Model.Candidato c in candidatos)
            {
                if (c.Partido.Sigla == p.Sigla)
                    return true;
            }
            return false;
        }

        public static List<string> getSecoes(string zona)
        {

            List<string> secoes = new List<string>();
            foreach (Model.Urna u in urnas)
            {

                if (zona.Equals(u.Zona))
                {
                    secoes.Add(u.Secao);
                }

            }
            return secoes;
        }

        public static List<string> getZonas()
        {
            List<string> zonas = new List<string>();
            foreach (Model.Urna u in urnas)
            {              
             
                if (!zonas.Contains(u.Zona))
                {
                    zonas.Add(u.Zona);
                }
              
            }
            return zonas;
        }
    }
}
