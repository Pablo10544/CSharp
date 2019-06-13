using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH_LISTA
{
    class Funcionarios
    {
        string nome;
        int idade;
        string cargo;
        int salario;
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

        public int Salario
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
        public Funcionarios(string nom, int ida, string carg, int salar){
            this.Nome = nom;
            this.Idade = ida;
            this.Cargo = carg;
            this.Salario = salar; 
            
            }
    }
}
