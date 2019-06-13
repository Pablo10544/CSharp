using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoloDeCenoura
{
    public class TortaAlema:Doce
    {
        private string tipoDoBiscoito;
       public TortaAlema(string nome,int tamanho,string tipo,string tpbisc) {
            this.Nome = nome;
            this.Tamanho = ObterTamanho(tamanho);
            this.Tipo = tipo;
            this.TipoDoBiscoito = tpbisc;

        }
        public string TipoDoBiscoito
        {
            get
            {
                return tipoDoBiscoito;
            }

            set
            {
                tipoDoBiscoito = value;
            }
        }
    }
}
