namespace BoloDeCenoura
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxTamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblRecheio = new System.Windows.Forms.Label();
            this.lblTipoBiscoito = new System.Windows.Forms.Label();
            this.rbtBolo = new System.Windows.Forms.RadioButton();
            this.rbtTA = new System.Windows.Forms.RadioButton();
            this.cbxTipoBiscoito = new System.Windows.Forms.ComboBox();
            this.cbxRecheio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(125, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(272, 75);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 1;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(183, 101);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(166, 72);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 1;
            this.tbxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTamanho
            // 
            this.tbxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTamanho.Location = new System.Drawing.Point(330, 72);
            this.tbxTamanho.Name = "tbxTamanho";
            this.tbxTamanho.Size = new System.Drawing.Size(100, 20);
            this.tbxTamanho.TabIndex = 2;
            this.tbxTamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doceria do seu Juca";
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.White;
            this.btnExibir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExibir.Location = new System.Drawing.Point(223, 181);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 30);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblRecheio
            // 
            this.lblRecheio.AutoSize = true;
            this.lblRecheio.Location = new System.Drawing.Point(183, 124);
            this.lblRecheio.Name = "lblRecheio";
            this.lblRecheio.Size = new System.Drawing.Size(47, 13);
            this.lblRecheio.TabIndex = 10;
            this.lblRecheio.Text = "Recheio";
            // 
            // lblTipoBiscoito
            // 
            this.lblTipoBiscoito.AutoSize = true;
            this.lblTipoBiscoito.Location = new System.Drawing.Point(183, 124);
            this.lblTipoBiscoito.Name = "lblTipoBiscoito";
            this.lblTipoBiscoito.Size = new System.Drawing.Size(65, 13);
            this.lblTipoBiscoito.TabIndex = 11;
            this.lblTipoBiscoito.Text = "TipoBiscoito";
            // 
            // rbtBolo
            // 
            this.rbtBolo.AutoSize = true;
            this.rbtBolo.Location = new System.Drawing.Point(222, 101);
            this.rbtBolo.Name = "rbtBolo";
            this.rbtBolo.Size = new System.Drawing.Size(46, 17);
            this.rbtBolo.TabIndex = 3;
            this.rbtBolo.TabStop = true;
            this.rbtBolo.Text = "Bolo";
            this.rbtBolo.UseVisualStyleBackColor = true;
            this.rbtBolo.CheckedChanged += new System.EventHandler(this.rbtBolo_CheckedChanged);
            this.rbtBolo.MouseEnter += new System.EventHandler(this.rbtBolo_MouseEnter);
            this.rbtBolo.MouseLeave += new System.EventHandler(this.rbtBolo_MouseLeave);
            // 
            // rbtTA
            // 
            this.rbtTA.AutoSize = true;
            this.rbtTA.Location = new System.Drawing.Point(274, 101);
            this.rbtTA.Name = "rbtTA";
            this.rbtTA.Size = new System.Drawing.Size(82, 17);
            this.rbtTA.TabIndex = 4;
            this.rbtTA.TabStop = true;
            this.rbtTA.Text = "Torta Alema";
            this.rbtTA.UseVisualStyleBackColor = true;
            this.rbtTA.CheckedChanged += new System.EventHandler(this.rbtTA_CheckedChanged);
            this.rbtTA.MouseEnter += new System.EventHandler(this.rbtTA_MouseEnter);
            this.rbtTA.MouseLeave += new System.EventHandler(this.rbtTA_MouseLeave);
            // 
            // cbxTipoBiscoito
            // 
            this.cbxTipoBiscoito.FormattingEnabled = true;
            this.cbxTipoBiscoito.Location = new System.Drawing.Point(254, 125);
            this.cbxTipoBiscoito.Name = "cbxTipoBiscoito";
            this.cbxTipoBiscoito.Size = new System.Drawing.Size(102, 21);
            this.cbxTipoBiscoito.TabIndex = 12;
            // 
            // cbxRecheio
            // 
            this.cbxRecheio.FormattingEnabled = true;
            this.cbxRecheio.Location = new System.Drawing.Point(254, 124);
            this.cbxRecheio.Name = "cbxRecheio";
            this.cbxRecheio.Size = new System.Drawing.Size(102, 21);
            this.cbxRecheio.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(521, 272);
            this.Controls.Add(this.cbxRecheio);
            this.Controls.Add(this.cbxTipoBiscoito);
            this.Controls.Add(this.rbtTA);
            this.Controls.Add(this.rbtBolo);
            this.Controls.Add(this.lblTipoBiscoito);
            this.Controls.Add(this.lblRecheio);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTamanho);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxTamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblRecheio;
        private System.Windows.Forms.Label lblTipoBiscoito;
        private System.Windows.Forms.RadioButton rbtBolo;
        private System.Windows.Forms.RadioButton rbtTA;
        private System.Windows.Forms.ComboBox cbxTipoBiscoito;
        private System.Windows.Forms.ComboBox cbxRecheio;
    }
}

