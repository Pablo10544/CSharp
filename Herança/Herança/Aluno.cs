using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Aluno:Pessoa
    {
        float nota1;
        float nota2;

        public float Nota1
        {
            get
            {
                return nota1;
            }

            set
            {
                nota1 = value;
            }
        }

        public float Nota2
        {
            get
            {
                return nota2;
            }

            set
            {
                nota2 = value;
            }
        }
    }
}
