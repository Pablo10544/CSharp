namespace POLIMORFISMO
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxIdade = new System.Windows.Forms.TextBox();
            this.tbxSalario = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.rbtAnalista = new System.Windows.Forms.RadioButton();
            this.rbtDiretor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(38, 97);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade :";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(38, 123);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário :";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(37, 149);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 13);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(38, 175);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Área :";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(130, 71);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 6;
            // 
            // tbxIdade
            // 
            this.tbxIdade.Location = new System.Drawing.Point(130, 97);
            this.tbxIdade.Name = "tbxIdade";
            this.tbxIdade.Size = new System.Drawing.Size(100, 20);
            this.tbxIdade.TabIndex = 7;
            // 
            // tbxSalario
            // 
            this.tbxSalario.Location = new System.Drawing.Point(130, 123);
            this.tbxSalario.Name = "tbxSalario";
            this.tbxSalario.Size = new System.Drawing.Size(100, 20);
            this.tbxSalario.TabIndex = 8;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(130, 175);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(100, 20);
            this.tbxArea.TabIndex = 10;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(92, 221);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 11;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // rbtAnalista
            // 
            this.rbtAnalista.AutoSize = true;
            this.rbtAnalista.Location = new System.Drawing.Point(130, 149);
            this.rbtAnalista.Name = "rbtAnalista";
            this.rbtAnalista.Size = new System.Drawing.Size(62, 17);
            this.rbtAnalista.TabIndex = 12;
            this.rbtAnalista.TabStop = true;
            this.rbtAnalista.Text = "Analista";
            this.rbtAnalista.UseVisualStyleBackColor = true;
            // 
            // rbtDiretor
            // 
            this.rbtDiretor.AutoSize = true;
            this.rbtDiretor.Location = new System.Drawing.Point(198, 149);
            this.rbtDiretor.Name = "rbtDiretor";
            this.rbtDiretor.Size = new System.Drawing.Size(56, 17);
            this.rbtDiretor.TabIndex = 13;
            this.rbtDiretor.TabStop = true;
            this.rbtDiretor.Text = "Diretor";
            this.rbtDiretor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rbtDiretor);
            this.Controls.Add(this.rbtAnalista);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.tbxSalario);
            this.Controls.Add(this.tbxIdade);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxIdade;
        private System.Windows.Forms.TextBox tbxSalario;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.RadioButton rbtAnalista;
        private System.Windows.Forms.RadioButton rbtDiretor;
    }
}

