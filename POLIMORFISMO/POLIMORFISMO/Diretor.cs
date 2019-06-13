using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Diretor:Funcionarios
    {
        public Diretor(string n, int idad, float sala, string carg) {
            this.Nome = n;
            this.Idade = idad;
            this.Salario =sala;
            this.Cargo = carg;
        }
        public override float ObterSalario(float sal)
        {
            float salarioF = sal + 2000;
            return salarioF;
        }
    }
}
