using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoloDeCenoura
{
    public partial class Form1 : Form
    {
        string nome;
        string tipo;
        int tamanho;
        string recheio;
        string tipoBiscoito;

        public Form1()
        {
            InitializeComponent();
            lblTipoBiscoito.Visible = false;
            cbxTipoBiscoito.Visible = false;
            cbxRecheio.Visible = false;
            lblRecheio.Visible = false;
            cbxRecheio.Items.Add("Chocolate");
            cbxRecheio.Items.Add("Doce de Leite");
            cbxRecheio.Items.Add("Paçoca");
            cbxTipoBiscoito.Items.Add("Trakinas");
            cbxTipoBiscoito.Items.Add("Passatempo");
            cbxTipoBiscoito.Items.Add("Fandangos");


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ObterDados();
            if (tipo == "Bolo")
            {
                Bolo b = new Bolo(nome, tamanho, tipo, recheio);
                MessageBox.Show("Nome:" + b.Nome + "\nTamanho:" + b.Tamanho + "cm" + "\nTipo:" + b.Tipo + "\nRecheio:" + b.Recheio);
            }
            else if (tipo == "Torta Alemã")
            {
               TortaAlema ta = new TortaAlema(nome, tamanho, tipo, tipoBiscoito);
                MessageBox.Show("Nome:" + ta.Nome + "\nTamanho:" + ta.Tamanho + "cm" + "\nTipo:" + ta.Tipo + "\nTipo do Biscoito:" + ta.TipoDoBiscoito);
            }

        }
        public void ObterDados() {
            nome = tbxNome.Text;
            
            tamanho =Int32.Parse(tbxTamanho.Text);

            if (rbtBolo.Checked)
            {
                tipo = "Bolo";
                recheio = cbxRecheio.Text;
             }
            else if(rbtTA.Checked) {
                tipo = "Torta Alemã";
                tipoBiscoito = cbxTipoBiscoito.Text;
               }
        }


        private void rbtBolo_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoBiscoito.Visible = false;
            cbxTipoBiscoito.Visible = false;
            lblRecheio.Visible = true;
            cbxRecheio.Visible = true;

        }

        private void rbtTA_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoBiscoito.Visible = true;
            cbxTipoBiscoito.Visible = true;
            lblRecheio.Visible = false;
            cbxRecheio.Visible = false;
        }

        private void rbtBolo_MouseEnter(object sender, EventArgs e)
        {
            if (!rbtTA.Checked)
            {
                lblRecheio.Visible = true;
                cbxRecheio.Visible = true;
                lblTipoBiscoito.Visible = false;
                cbxTipoBiscoito.Visible = false;
            }
        }

        private void rbtTA_MouseEnter(object sender, EventArgs e)
        {
            if (!rbtBolo.Checked)
            {
                lblTipoBiscoito.Visible = true;
                cbxTipoBiscoito.Visible = true;
                lblRecheio.Visible = false;
                cbxRecheio.Visible = false;
            }
        }

        private void rbtTA_MouseLeave(object sender, EventArgs e)
        {
            if (!rbtTA.Checked&&!rbtBolo.Checked)
            {
                lblTipoBiscoito.Visible = false;
                cbxTipoBiscoito.Visible = false;
                lblRecheio.Visible = false;
                cbxRecheio.Visible = false;
            }

        }

        private void rbtBolo_MouseLeave(object sender, EventArgs e)
        {
            if (!rbtBolo.Checked&&!rbtTA.Checked)
            {
                lblRecheio.Visible = false;
                cbxRecheio.Visible = false;
                lblTipoBiscoito.Visible = false;
                cbxTipoBiscoito.Visible = false;
            }
           
        }
    }
    
}
