using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    { string nome;
        string nomeFic;
        string cidade;
        string identidade;
        string poder;
        public Form1()
        {
            InitializeComponent();
            cbnSuperHeroi.Items.Add("Batman");
            cbnSuperHeroi.Items.Add("Super-Man");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pegarDados();
             
        }

        private void pegarDados()
        {
            nome=cbnSuperHeroi.Text ;
            if (nome == "Batman")
            {
                Batman bat = new Batman();
                bat.ObterDados();
                nomeFic = bat.NomeFicticio;
                identidade = bat.Identidade;
                cidade = bat.Cidade;

                MessageBox.Show("Conhecido como: " + nomeFic + "\n Sua identidade verdadeira é:" + identidade + "\n Ele defende a cidade de:" + cidade);
            } else if (nome=="Super-Man") {
                SuperMan super = new SuperMan();
                super.ObterDados();
                nomeFic = super.NomeFicticio;
                identidade = super.Identidade;
                cidade = super.Cidade;
                MessageBox.Show("Conhecido como: " + nomeFic + "\n Sua identidade verdadeira é:" + identidade + "\n Ele defende a cidade de:" + cidade+ "\npoderes:" + super.Poderes[0]+", "+ super.Poderes[1]+", "+ super.Poderes[2]);
                

            }
            else {
                MessageBox.Show("Selecione um Super-Herói!!!");
            } }
    }
}
