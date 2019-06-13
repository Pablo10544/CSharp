using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoloDeCenoura
{
    public class Bolo:Doce
    {
        private string recheio;

        public string Recheio
        {
            get
            {
                return recheio;
            }

            set
            {
                recheio = value;
            }
        }
           public Bolo(string nome, int tamanho, string tipo, string recheio)
        {
            this.Nome = nome;
            this.Tamanho = ObterTamanho(tamanho);
            this.Tipo = tipo;
            this.Recheio = recheio;

        }
        public override int ObterTamanho(int tamanho)
        {
            int total = 0;
            total = tamanho + 7;
            return total;
        }
    }
}
