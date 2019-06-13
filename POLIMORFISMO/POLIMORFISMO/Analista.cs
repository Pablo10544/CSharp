using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Analista:Funcionarios
    {
        public Analista(string n, int idad,float sala, string carg)
        {
            this.Nome = n;
            this.Idade = idad;
            this.Salario = sala;
            this.Cargo = carg;
        }
    }
}
