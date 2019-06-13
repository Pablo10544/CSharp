using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoemGrupo_Armas
{
    class Pistola:Arma
    {
        bool silenciador;
       public  Pistola(string nom, string tip, float calibr, int qtdMunica, bool silenc)
        {
            this.Nome = nom;
            this.Tipo = tip;
            this.Calibre = calibr;
            this.QtdMunicao = qtdMunica;
            this.Silenciador = silenc;
        }

        public bool Silenciador
        {
            get
            {
                return silenciador;
            }

            set
            {
                silenciador = value;
            }
        }
    }
}




