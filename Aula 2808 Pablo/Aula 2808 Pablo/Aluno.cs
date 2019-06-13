using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2808_Pablo
{
    class Aluno
    {
        string nome;
        int idade;
        float media;

        public float Media
        {
            get
            {
                return media;
            }

            set
            {
                media = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
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
        public Aluno(string nom, int idad, float medi) {
            this.Nome = nom;
            this.idade = idad;
            this.media = medi;
        }
    }
}
