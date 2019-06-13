namespace TrabalhoemGrupo_Armas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvarTxt = new System.Windows.Forms.Button();
            this.lblNomeArma = new System.Windows.Forms.Label();
            this.lblTipoArma = new System.Windows.Forms.Label();
            this.lblCalibreArma = new System.Windows.Forms.Label();
            this.lblQtdArma = new System.Windows.Forms.Label();
            this.tbxNomeArma = new System.Windows.Forms.TextBox();
            this.cbxTipoArma = new System.Windows.Forms.ComboBox();
            this.cbxCalibreArma = new System.Windows.Forms.ComboBox();
            this.cbxQtdArma = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxArmasCadastradas = new System.Windows.Forms.ComboBox();
            this.lblArmasCadastradas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(280, 285);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 37);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSalvarTxt
            // 
            this.btnSalvarTxt.Location = new System.Drawing.Point(36, 285);
            this.btnSalvarTxt.Name = "btnSalvarTxt";
            this.btnSalvarTxt.Size = new System.Drawing.Size(159, 37);
            this.btnSalvarTxt.TabIndex = 1;
            this.btnSalvarTxt.Text = "SALVAR TXT";
            this.btnSalvarTxt.UseVisualStyleBackColor = true;
            this.btnSalvarTxt.Click += new System.EventHandler(this.btnSalvarTxt_Click);
            // 
            // lblNomeArma
            // 
            this.lblNomeArma.AutoSize = true;
            this.lblNomeArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArma.Location = new System.Drawing.Point(32, 66);
            this.lblNomeArma.Name = "lblNomeArma";
            this.lblNomeArma.Size = new System.Drawing.Size(55, 20);
            this.lblNomeArma.TabIndex = 2;
            this.lblNomeArma.Text = "Nome";
            // 
            // lblTipoArma
            // 
            this.lblTipoArma.AutoSize = true;
            this.lblTipoArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArma.Location = new System.Drawing.Point(32, 104);
            this.lblTipoArma.Name = "lblTipoArma";
            this.lblTipoArma.Size = new System.Drawing.Size(43, 20);
            this.lblTipoArma.TabIndex = 3;
            this.lblTipoArma.Text = "Tipo";
            // 
            // lblCalibreArma
            // 
            this.lblCalibreArma.AutoSize = true;
            this.lblCalibreArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibreArma.Location = new System.Drawing.Point(32, 145);
            this.lblCalibreArma.Name = "lblCalibreArma";
            this.lblCalibreArma.Size = new System.Drawing.Size(65, 20);
            this.lblCalibreArma.TabIndex = 4;
            this.lblCalibreArma.Text = "Calibre";
            // 
            // lblQtdArma
            // 
            this.lblQtdArma.AutoSize = true;
            this.lblQtdArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdArma.Location = new System.Drawing.Point(32, 186);
            this.lblQtdArma.Name = "lblQtdArma";
            this.lblQtdArma.Size = new System.Drawing.Size(199, 20);
            this.lblQtdArma.TabIndex = 5;
            this.lblQtdArma.Text = "Quantidade de Munição";
            // 
            // tbxNomeArma
            // 
            this.tbxNomeArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomeArma.Location = new System.Drawing.Point(253, 68);
            this.tbxNomeArma.Name = "tbxNomeArma";
            this.tbxNomeArma.Size = new System.Drawing.Size(189, 22);
            this.tbxNomeArma.TabIndex = 6;
            // 
            // cbxTipoArma
            // 
            this.cbxTipoArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoArma.FormattingEnabled = true;
            this.cbxTipoArma.Location = new System.Drawing.Point(253, 106);
            this.cbxTipoArma.Name = "cbxTipoArma";
            this.cbxTipoArma.Size = new System.Drawing.Size(132, 24);
            this.cbxTipoArma.TabIndex = 10;
            // 
            // cbxCalibreArma
            // 
            this.cbxCalibreArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalibreArma.FormattingEnabled = true;
            this.cbxCalibreArma.Location = new System.Drawing.Point(253, 145);
            this.cbxCalibreArma.Name = "cbxCalibreArma";
            this.cbxCalibreArma.Size = new System.Drawing.Size(77, 24);
            this.cbxCalibreArma.TabIndex = 11;
            // 
            // cbxQtdArma
            // 
            this.cbxQtdArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQtdArma.FormattingEnabled = true;
            this.cbxQtdArma.Location = new System.Drawing.Point(253, 188);
            this.cbxQtdArma.Name = "cbxQtdArma";
            this.cbxQtdArma.Size = new System.Drawing.Size(77, 24);
            this.cbxQtdArma.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(185, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(72, 20);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "ARMAS";
            // 
            // cbxArmasCadastradas
            // 
            this.cbxArmasCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArmasCadastradas.FormattingEnabled = true;
            this.cbxArmasCadastradas.Location = new System.Drawing.Point(253, 227);
            this.cbxArmasCadastradas.Name = "cbxArmasCadastradas";
            this.cbxArmasCadastradas.Size = new System.Drawing.Size(132, 24);
            this.cbxArmasCadastradas.TabIndex = 14;
            // 
            // lblArmasCadastradas
            // 
            this.lblArmasCadastradas.AutoSize = true;
            this.lblArmasCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmasCadastradas.Location = new System.Drawing.Point(32, 231);
            this.lblArmasCadastradas.Name = "lblArmasCadastradas";
            this.lblArmasCadastradas.Size = new System.Drawing.Size(116, 20);
            this.lblArmasCadastradas.TabIndex = 15;
            this.lblArmasCadastradas.Text = "Cadastrados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 334);
            this.Controls.Add(this.lblArmasCadastradas);
            this.Controls.Add(this.cbxArmasCadastradas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxQtdArma);
            this.Controls.Add(this.cbxCalibreArma);
            this.Controls.Add(this.cbxTipoArma);
            this.Controls.Add(this.tbxNomeArma);
            this.Controls.Add(this.lblQtdArma);
            this.Controls.Add(this.lblCalibreArma);
            this.Controls.Add(this.lblTipoArma);
            this.Controls.Add(this.lblNomeArma);
            this.Controls.Add(this.btnSalvarTxt);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Armas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSalvarTxt;
        private System.Windows.Forms.Label lblNomeArma;
        private System.Windows.Forms.Label lblTipoArma;
        private System.Windows.Forms.Label lblCalibreArma;
        private System.Windows.Forms.Label lblQtdArma;
        private System.Windows.Forms.TextBox tbxNomeArma;
        private System.Windows.Forms.ComboBox cbxTipoArma;
        private System.Windows.Forms.ComboBox cbxCalibreArma;
        private System.Windows.Forms.ComboBox cbxQtdArma;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxArmasCadastradas;
        private System.Windows.Forms.Label lblArmasCadastradas;
    }
}

