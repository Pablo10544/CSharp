using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIMORFISMO
{
    public partial class Form1 : Form
    {
        string nome;
        int idade;
        float salario;
        string cargo;
        string area;
        float salariototal;

        public float Salariototal
        {
            get
            {
                return salariototal;
            }

            set
            {
                salariototal = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        void ObterDados()
        {
            nome = tbxNome.Text;
            idade = int.Parse(tbxIdade.Text);
            salario = float.Parse(tbxSalario.Text);
            area = tbxArea.Text;
            if (rbtAnalista.Checked)
            {
                cargo = "Analista";
            }
            else { cargo = "Diretor"; }


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ObterDados();
            if (cargo == "Diretor")
            {
                Diretor dir = new Diretor(nome, idade, salario, cargo);
                Area a = new Area(area);
                dir.Area = a;
                Salariototal = dir.ObterSalario(salario);
                MessageBox.Show("nome :" + dir.Nome + "\nsalario:" + Salariototal);
            }
            else { Analista ana = new Analista(nome, idade, salario, cargo);
                Area a = new Area(area);
                ana.Area = a;
                Salariototal = ana.ObterSalario(salario);
                MessageBox.Show("nome :"+ana.Nome+"\nsalario:" +Salariototal);
            }
            
        }
    }
}
