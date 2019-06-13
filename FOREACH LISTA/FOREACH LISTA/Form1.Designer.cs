namespace FOREACH_LISTA
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tbxNomes = new System.Windows.Forms.TextBox();
            this.btnVerDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tbxCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbxSalario = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.tbxIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(29, 214);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 36);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tbxNomes
            // 
            this.tbxNomes.Location = new System.Drawing.Point(105, 85);
            this.tbxNomes.Name = "tbxNomes";
            this.tbxNomes.Size = new System.Drawing.Size(115, 20);
            this.tbxNomes.TabIndex = 1;
            // 
            // btnVerDados
            // 
            this.btnVerDados.Location = new System.Drawing.Point(174, 214);
            this.btnVerDados.Name = "btnVerDados";
            this.btnVerDados.Size = new System.Drawing.Size(91, 36);
            this.btnVerDados.TabIndex = 2;
            this.btnVerDados.Text = "Ver Dados";
            this.btnVerDados.UseVisualStyleBackColor = true;
            this.btnVerDados.Click += new System.EventHandler(this.btnVerDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome :";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(45, 142);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 13);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Cargo :";
            // 
            // tbxCargo
            // 
            this.tbxCargo.Location = new System.Drawing.Point(105, 142);
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.Size = new System.Drawing.Size(115, 20);
            this.tbxCargo.TabIndex = 4;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(45, 168);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 13);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salario :";
            // 
            // tbxSalario
            // 
            this.tbxSalario.Location = new System.Drawing.Point(105, 168);
            this.tbxSalario.Name = "tbxSalario";
            this.tbxSalario.Size = new System.Drawing.Size(115, 20);
            this.tbxSalario.TabIndex = 6;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(45, 110);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 9;
            this.lblIdade.Text = "Idade :";
            // 
            // tbxIdade
            // 
            this.tbxIdade.Location = new System.Drawing.Point(105, 110);
            this.tbxIdade.Name = "tbxIdade";
            this.tbxIdade.Size = new System.Drawing.Size(115, 20);
            this.tbxIdade.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empresa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.tbxIdade);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.tbxSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.tbxCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerDados);
            this.Controls.Add(this.tbxNomes);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox tbxNomes;
        private System.Windows.Forms.Button btnVerDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox tbxCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbxSalario;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox tbxIdade;
        private System.Windows.Forms.Label label2;
    }
}

