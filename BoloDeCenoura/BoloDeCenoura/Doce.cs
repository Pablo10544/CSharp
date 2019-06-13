using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoloDeCenoura
{
    public class Doce
    {
        private string nome;
        private int tamanho;
        private string tipo;

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

        public int Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

      
        public virtual int ObterTamanho(int tamanho)
        {
            int total = 0;
            total = tamanho + 5;
            return total;
        }
    }
}
