using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Funcionarios
    {
        string nome;
        int idade;
        float salario;
        string cargo;
        Area area;
        public Area Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }
        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }
        public float Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
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

        public virtual float ObterSalario(float sal) {

            float salarioF = sal + 1000;
            return salarioF;
        }

    }
}
