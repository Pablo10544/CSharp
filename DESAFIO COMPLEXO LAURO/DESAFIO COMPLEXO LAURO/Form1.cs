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

namespace DESAFIO_COMPLEXO_LAURO
{
    public partial class Form1 : Form
    {
        string nome = "";
        public Form1()
        {
            InitializeComponent();
            carregarTxt();
        }

        private void carregarTxt()
        {
            if (File.Exists("nome.txt"))
            {
                Stream stream = File.Open("nome.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(stream);
                string linha = leitor.ReadLine();
                while (linha!=null)
                {
                    tbxNome.Text = linha;
                    linha = leitor.ReadLine();
                } 
                leitor.Close();
                stream.Close();
            }
            else { MessageBox.Show("Arquivo não encontrado!"); }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = tbxNome.Text.ToLower();

            SalvarTxt(nome);


            MessageBox.Show("Salvo com Sucesso!");
            tbxNome.Text = "";
        }

        private void SalvarTxt(string Nome)
        {
            Stream stream = File.Open("nome.txt", FileMode.OpenOrCreate);
            string[] lines = { "First line", "Second line", "Third line" };
            using (StreamWriter outputFile = new StreamWriter(stream))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            
           /* StreamWriter escritor = new StreamWriter(stream);
            escritor.WriteLine(nome);
            escritor.Close();*/
            stream.Close();
        }
    }
}
