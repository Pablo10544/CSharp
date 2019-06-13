using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class SuperHeroi
    {
        string identidade;
        string nomeFicticio;
        string cidade;
        List <string> poderes;

        public string Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = value;
            }
        }

        public string NomeFicticio
        {
            get
            {
                return nomeFicticio;
            }

            set
            {
                nomeFicticio = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }
        
        public List<string> Poderes
        {
            get
            {
                return poderes;
            }

            set
            {
                poderes = value;
            }
        }

        public abstract void ObterDados();
    }
}
