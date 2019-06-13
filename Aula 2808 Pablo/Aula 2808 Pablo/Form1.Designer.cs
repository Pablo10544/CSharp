namespace Aula_2808_Pablo
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
            this.lblMedia = new System.Windows.Forms.Label();
            this.ObterDados = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxIdade = new System.Windows.Forms.TextBox();
            this.tbxMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(45, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(45, 97);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade :";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(45, 123);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(42, 13);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Media :";
            // 
            // ObterDados
            // 
            this.ObterDados.Location = new System.Drawing.Point(57, 173);
            this.ObterDados.Name = "ObterDados";
            this.ObterDados.Size = new System.Drawing.Size(75, 23);
            this.ObterDados.TabIndex = 3;
            this.ObterDados.Text = "Cadastrar";
            this.ObterDados.UseVisualStyleBackColor = true;
            this.ObterDados.Click += new System.EventHandler(this.Resultados_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(120, 71);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxIdade
            // 
            this.tbxIdade.Location = new System.Drawing.Point(120, 97);
            this.tbxIdade.Name = "tbxIdade";
            this.tbxIdade.Size = new System.Drawing.Size(100, 20);
            this.tbxIdade.TabIndex = 5;
            // 
            // tbxMedia
            // 
            this.tbxMedia.Location = new System.Drawing.Point(120, 123);
            this.tbxMedia.Name = "tbxMedia";
            this.tbxMedia.Size = new System.Drawing.Size(100, 20);
            this.tbxMedia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LINQ E LAMBDA";
            // 
            // Resultados
            // 
            this.Resultados.Location = new System.Drawing.Point(175, 173);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(75, 23);
            this.Resultados.TabIndex = 8;
            this.Resultados.Text = "Resultados";
            this.Resultados.UseVisualStyleBackColor = true;
            this.Resultados.Click += new System.EventHandler(this.Resultados_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 219);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMedia);
            this.Controls.Add(this.tbxIdade);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.ObterDados);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "LISTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button ObterDados;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxIdade;
        private System.Windows.Forms.TextBox tbxMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Resultados;
    }
}

