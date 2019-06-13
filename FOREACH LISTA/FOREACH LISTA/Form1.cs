using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREACH_LISTA
{
    public partial class Form1 : Form
    { Funcionarios f;
        string nome;
        int idade=0;
        string cargo;
        int salario=0;
        float mediaIdade;
        int qtdAnalista = 0;
        int maiorSalario;
        float mediaSalario;
        int menorsalario=0;
        string NomeDoPobretao;
        int somaIdade;
        List<Funcionarios> funcionarios = new List<Funcionarios>();

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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ObterDados();
            f = new Funcionarios(Nome,Idade,Cargo,Salario);
            funcionarios.Add(f);
        }
        void ObterDados() {
            Nome = tbxNomes.Text;
            Idade = Int32.Parse(tbxIdade.Text);
            Cargo = tbxSalario.Text;
            Salario = Int32.Parse(tbxSalario.Text);
            tbxNomes.Text = "";
            tbxIdade.Text = "";
            tbxCargo.Text = "";
            tbxSalario.Text = "";
        }

        private void btnVerDados_Click(object sender, EventArgs e)
        {
            foreach (Funcionarios varDoFun in funcionarios)
            {
                if (f.Cargo=="Analista")
                {
                    qtdAnalista++;
                }
                if (f.Salario>maiorSalario)
                {
                    maiorSalario = f.Salario;
                }
                if (menorsalario == 0)
                {
                    menorsalario = f.Salario;
                    NomeDoPobretao = f.Nome;
                }
                else if (menorsalario > f.Salario) {
                    menorsalario = f.Salario;
                    NomeDoPobretao = f.Nome;
                }
                somaIdade += idade;
            }
            mediaIdade /= funcionarios.Count;
            MessageBox.Show("A quantidade de analistas é:{0},o maior salário é {1}, a media de idade dos funcionarios é{2}. E a pessoa com menor salario é{3}", qtdAnalista.ToString());
        }
    }
    

}
