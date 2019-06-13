using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoemGrupo_Armas
{
    class Arma
    {
        string nome;
        string tipo;
        float calibre;
        int qtdMunicao;

        public int QtdMunicao
        {
            get
            {
                return qtdMunicao;
            }

            set
            {
                qtdMunicao = value;
            }
        }

        public float Calibre
        {
            get
            {
                return calibre;
            }

            set
            {
                calibre = value;
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
        public Arma() { } //para não ter problema com a  herança
    }
}
