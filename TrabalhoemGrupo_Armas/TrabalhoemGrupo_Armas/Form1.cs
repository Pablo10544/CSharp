using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoemGrupo_Armas
{
    public partial class Form1 : Form
    {
        string nome = "";
        string tipo = "";
        float calibre = 0;
        int qtd = 0;
        bool silenciador = false;
        bool clicou = false;
        List<Pistola> pistolas = new List<Pistola>();

        public Form1()
        {
            InitializeComponent();
            cbxTipoArma.Items.Add("Pistola");
            cbxCalibreArma.Items.Add("50");
            cbxQtdArma.Items.Add("20");
            CarregarDados();
            cbxArmasCadastradas.DisplayMember = "Nome";
            CarregarComboBox();
        }





        void SalvarTxt()
        {
            Stream stream = File.Open("Pistolas.txt", FileMode.OpenOrCreate);
            StreamWriter escritor = new StreamWriter(stream);

            foreach (Pistola p in pistolas)
            {
                escritor.WriteLine(p.Nome + "|" + p.Tipo + "|" + p.Calibre + "|" + p.QtdMunicao);
            }

            escritor.Close();
            stream.Close();
            MessageBox.Show("Salvo com sucesso!");
            LimparDados();
        }

        //void CarregarComboBox()
        //{
        //    foreach (Pistola p in pistolas)
        //    {
        //        cbx.Items.Add(p);
        //    }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbxTipoArma.Text == "Pistola")
            {
                ObterDados();
                Pistola p = new Pistola(nome, tipo, calibre, qtd, silenciador);

                pistolas.Add(p);
                LimparDados();

            }
            //if (clicou)
            //{
            //var pis = pistolas.Single(p => p.Nome == pistolaAnterior);

            //var pistola = pistolas.Any(p => p.Nome == nome);

            //if (pistola == true)
            //{
            //    MessageBox.Show("Pistola já cadastrada!");
            //}


            //    pis.Nome = nome;
            //    pis.Tipo = tipo;
            //    pis.Calibre = calibre;
            //    pis.Qtd = qtd;
            //    pis.Silenciador = silenciador;
            //    MessageBox.Show("Pistola editada com sucesso!");
            //    clicou = false;
            //    }

            //else
            //{
            //    var pis = pistolas.Any(p => p.Nome == nome);

            //    if (pis == false)
            //    {
            //        Pistola pistola = new Pistola(nome,tipo,calibre,qtd,silenciador);
            //        pistolas.Add(pistola);
            //        MessageBox.Show("Pistola cadastrada com sucesso!");
            //    }                   
            //}
        }
        void CarregarComboBox()
        {
            foreach (Pistola p in pistolas)
            {
                cbxArmasCadastradas.Items.Add(p);
            }
        }

        void CarregarDados()
        {
            if (File.Exists("Pistolas.txt"))
            {
                Stream stream = File.Open("Pistolas.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(stream);

                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] dados = linha.Split('|');
                    string n = dados[0];
                    string t = dados[1];
                    float c = float.Parse(dados[2]);
                    int q = Int32.Parse(dados[3]);
                    //int s = Int32.Parse(dados[4]);
                    bool ts = false;
                    //if(s == 1)
                    //{
                    //    ts = true;
                    //}
                    Pistola p = new Pistola(n,t,c,q,ts);
                    pistolas.Add(p);
                    linha = leitor.ReadLine();
                }

                leitor.Close();
                stream.Close();
            }
        }    



        private void ObterDados()
        {
            nome = tbxNomeArma.Text;
            tipo = cbxTipoArma.Text;
            calibre = float.Parse(cbxCalibreArma.Text);
            qtd = Int32.Parse(cbxQtdArma.Text);
        }

        private void LimparDados()
        {
            nome = "";
            tipo = "";
            calibre = 0;
            qtd = 0;
            silenciador = false;
        }

        private void LimparCombobox()
        {
            tbxNomeArma.Text = "";
            cbxTipoArma.Text = "";
            cbxCalibreArma.Text = "";
            cbxQtdArma.Text = "";
        }

        private void btnSalvarTxt_Click(object sender, EventArgs e)
        {
            SalvarTxt();
            LimparCombobox();
        }

    }
}

