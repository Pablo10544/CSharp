namespace Deveres
{
    partial class AddHomework
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblHomework = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxHomework = new System.Windows.Forms.TextBox();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(152, 81);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(62, 20);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Matéria";
            // 
            // lblHomework
            // 
            this.lblHomework.AutoSize = true;
            this.lblHomework.Location = new System.Drawing.Point(152, 157);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(51, 20);
            this.lblHomework.TabIndex = 1;
            this.lblHomework.Text = "Dever";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 58);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxHomework
            // 
            this.tbxHomework.Location = new System.Drawing.Point(244, 157);
            this.tbxHomework.Name = "tbxHomework";
            this.tbxHomework.Size = new System.Drawing.Size(121, 26);
            this.tbxHomework.TabIndex = 3;
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(244, 81);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(121, 28);
            this.cbxSubject.TabIndex = 4;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::Deveres.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(48, 255);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(45, 45);
            this.pbxBack.TabIndex = 5;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // AddHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 340);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.tbxHomework);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHomework);
            this.Controls.Add(this.lblSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddHomework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Dever de Casa";
            this.Load += new System.EventHandler(this.AddHomework_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblHomework;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxHomework;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}