namespace Herança
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxIdade = new System.Windows.Forms.TextBox();
            this.tbxNota1 = new System.Windows.Forms.TextBox();
            this.tbxNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.tbxSalario = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(47, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(47, 64);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(47, 90);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(47, 116);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1.TabIndex = 3;
            this.lblNota1.Text = "Nota 1:";
            this.lblNota1.Visible = false;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(102, 199);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "EXIBIR";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(131, 33);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 5;
            // 
            // tbxIdade
            // 
            this.tbxIdade.Location = new System.Drawing.Point(131, 64);
            this.tbxIdade.Name = "tbxIdade";
            this.tbxIdade.Size = new System.Drawing.Size(100, 20);
            this.tbxIdade.TabIndex = 6;
            // 
            // tbxNota1
            // 
            this.tbxNota1.Location = new System.Drawing.Point(131, 116);
            this.tbxNota1.Name = "tbxNota1";
            this.tbxNota1.Size = new System.Drawing.Size(100, 20);
            this.tbxNota1.TabIndex = 8;
            this.tbxNota1.Visible = false;
            // 
            // tbxNota2
            // 
            this.tbxNota2.Location = new System.Drawing.Point(131, 142);
            this.tbxNota2.Name = "tbxNota2";
            this.tbxNota2.Size = new System.Drawing.Size(100, 20);
            this.tbxNota2.TabIndex = 9;
            this.tbxNota2.Visible = false;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(47, 142);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 11;
            this.lblNota2.Text = "Nota 2:";
            this.lblNota2.Visible = false;
            // 
            // tbxSalario
            // 
            this.tbxSalario.Location = new System.Drawing.Point(131, 116);
            this.tbxSalario.Name = "tbxSalario";
            this.tbxSalario.Size = new System.Drawing.Size(100, 20);
            this.tbxSalario.TabIndex = 12;
            this.tbxSalario.Visible = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(131, 90);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(47, 116);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.tbxSalario);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.tbxNota2);
            this.Controls.Add(this.tbxNota1);
            this.Controls.Add(this.tbxIdade);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxIdade;
        private System.Windows.Forms.TextBox tbxNota1;
        private System.Windows.Forms.TextBox tbxNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox tbxSalario;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblSalario;
    }
}

