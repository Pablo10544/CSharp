using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2808_Pablo
{
    public partial class Form1 : Form
    {
        string nome;
        int idade=0;
        float media=0;
        Aluno a;
        List<Aluno> alunos = new List<Aluno>();
        int numTotalDeAlunoa;
        double mediaIdades;
        int maiorIdade=0;
        int numalunosmedia5=0;
        float piormediaturma;
        int idadeAlunoMaisNovo;
        string nomeAlunoMaisNovo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultados_Click(object sender, EventArgs e)
        {
            OterDados();
            a = new Aluno(nome, idade, media);
            alunos.Add(a);
            LimparDados();
        }

        private void LimparDados()
        {
            tbxIdade.Text = "";
            tbxMedia.Text = "";
            tbxNome.Text = "";
        }

        private void OterDados()
        {
            nome = tbxNome.Text;
            idade = Int32.Parse(tbxIdade.Text);
            media = float.Parse(tbxMedia.Text);
            
        }

        private void Resultados_Click_1(object sender, EventArgs e)
        {
            numTotalDeAlunoa = alunos.Count();
            mediaIdades = alunos.Average(p => p.Idade);
            maiorIdade = alunos.Max(m=>m.Idade);
            numalunosmedia5 = alunos.Count(i=>i.Media>=5);
            piormediaturma = alunos.Min(i=>i.Media);
            foreach (Aluno n in alunos)
            {
                if (idadeAlunoMaisNovo==0) {
                    idadeAlunoMaisNovo = n.Idade;
                    nomeAlunoMaisNovo=n.Nome;
                }
                if (n.Idade<idadeAlunoMaisNovo) {
                    idadeAlunoMaisNovo = n.Idade;
                    nomeAlunoMaisNovo = n.Nome;
                }
            }MessageBox.Show("Numero total de alunos ="+numTotalDeAlunoa+ ", media de idade = "+mediaIdades+", mais veho = "+maiorIdade+ ", numero alunos nota 5 ou superior ="+numalunosmedia5+ ", pior media ="+piormediaturma+", aluno mais novo = " + nomeAlunoMaisNovo );

        }
    }
}
