using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Area
    {   private string nome;
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
        public Area(string Nome) {
            this.nome = Nome;
        }
    }
}
