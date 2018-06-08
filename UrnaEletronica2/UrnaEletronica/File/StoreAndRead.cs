using System;
using System.Collections.Generic;
using System.IO;

namespace UrnaEletronica
{
    static class StoreAndRead
    {
        public const string ELEITORES_FILE_PATH = @"eleitores.txt";
        public const string PARTIDOS_FILE_PATH = @"partidos.txt";
        public const string VEREADORES_FILE_PATH = @"vereadores.txt";
        public const string PREFEITOS_FILE_PATH = @"prefeitos.txt";
        public const string VICEPREFEITOS_FILE_PATH = @"viceprefeitos.txt";


        public const int ERRO_GRAVACAO = -1;
        public const int CADASTRO_EFETUADO_COM_SUCESSO = 1;
        public const int CADASTRO_EXISTENTE = 2;

        public static int novoCadastro(Cadastravel cad, string path)
        {
            try
            {
                if (cad.jaCadastrado())
                    return CADASTRO_EXISTENTE;
                Stream f = File.Open(path, FileMode.Append);
                StreamWriter file = new StreamWriter(f);
                file.WriteLine(cad.formatToSave());
                file.Close();
                return CADASTRO_EFETUADO_COM_SUCESSO;
            }
            catch (Exception)
            {
                return ERRO_GRAVACAO;
            }
        }


        public static bool isPrefeitoCadastrado(Prefeito p)
        {
            // string[] materia = line.Split(':');
            StreamReader file = new StreamReader(PREFEITOS_FILE_PATH);
            string str;

            while ((str = file.ReadLine()) != null)
            {
                string[] pieces = str.Split(':');
              
            }
            file.Close();
            return false;
        }

        public static List<Prefeito> prefeitosCadastrados()
        {
            List<Prefeito> prefeitos = new List<Prefeito>();

            StreamReader file = new StreamReader(PREFEITOS_FILE_PATH);
            string str;

            while ((str = file.ReadLine()) != null)
            {
               
            }
            file.Close();

            return prefeitos;
        }

      

    }
}
