using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxTipo.Items.Add("Professor");
            cbxTipo.Items.Add("Aluno");

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedItem=="Aluno")
            {
                ExibirAluno();
            }
            else
            {
                exibirProfessor();
            }
        }

        private void exibirProfessor()
        {
            lblNota2.Visible = false;
            lblNota1.Visible = false;
            tbxNota1.Visible = false;
            tbxNota2.Visible = false;
            lblSalario.Visible = true;
            tbxSalario.Visible = true;
        }

        private void ExibirAluno()
        {
            lblNota2.Visible = true;
            lblNota1.Visible = true;
            tbxNota1.Visible = true;
            tbxNota2.Visible = true;
            lblSalario.Visible = false;
            tbxSalario.Visible = false;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedItem=="Aluno")
            {
                Aluno aluno = new Aluno();
                aluno.Nome = tbxNome.Text;
                aluno.Idade = int.Parse(tbxIdade.Text);
                aluno.Nota1 = float.Parse(tbxNota1.Text);
                aluno.Nota2 = float.Parse(tbxNota2.Text);
                MessageBox.Show(aluno.Nome+"\n"+(aluno.Nota1+aluno.Nota2)/2);
               
            }
            else if(cbxTipo.SelectedItem=="Professor")
            {
                string nome = tbxNome.Text;
                int idade = int.Parse(tbxIdade.Text);
                float salario = float.Parse(tbxSalario.Text); 
                Professor professor = new Professor(nome, idade,salario);
                MessageBox.Show(professor.Nome+"\n"+professor.Idade+"\n"+professor.Salario);
               
            }
            
        }
    }
}
