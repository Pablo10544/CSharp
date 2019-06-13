using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Professor:Pessoa
    {
       private float salario;

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
        
        public Professor(string nome,int idade,float salarioc)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;

        }
    }
}
