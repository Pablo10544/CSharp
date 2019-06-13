namespace Deveres
{
    partial class SubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.ckbMath = new System.Windows.Forms.CheckBox();
            this.ckbPortuguese = new System.Windows.Forms.CheckBox();
            this.ckbHistory = new System.Windows.Forms.CheckBox();
            this.ckbGeografy = new System.Windows.Forms.CheckBox();
            this.ckbEnglish = new System.Windows.Forms.CheckBox();
            this.ckbSpanish = new System.Windows.Forms.CheckBox();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbMath
            // 
            this.ckbMath.AutoSize = true;
            this.ckbMath.Checked = true;
            this.ckbMath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMath.Location = new System.Drawing.Point(74, 163);
            this.ckbMath.Name = "ckbMath";
            this.ckbMath.Size = new System.Drawing.Size(118, 24);
            this.ckbMath.TabIndex = 6;
            this.ckbMath.Text = "Matemática";
            this.ckbMath.UseVisualStyleBackColor = true;
            // 
            // ckbPortuguese
            // 
            this.ckbPortuguese.AutoSize = true;
            this.ckbPortuguese.Checked = true;
            this.ckbPortuguese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPortuguese.Location = new System.Drawing.Point(74, 225);
            this.ckbPortuguese.Name = "ckbPortuguese";
            this.ckbPortuguese.Size = new System.Drawing.Size(108, 24);
            this.ckbPortuguese.TabIndex = 7;
            this.ckbPortuguese.Text = "Português";
            this.ckbPortuguese.UseVisualStyleBackColor = true;
            // 
            // ckbHistory
            // 
            this.ckbHistory.AutoSize = true;
            this.ckbHistory.Checked = true;
            this.ckbHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHistory.Location = new System.Drawing.Point(74, 287);
            this.ckbHistory.Name = "ckbHistory";
            this.ckbHistory.Size = new System.Drawing.Size(89, 24);
            this.ckbHistory.TabIndex = 8;
            this.ckbHistory.Text = "História";
            this.ckbHistory.UseVisualStyleBackColor = true;
            // 
            // ckbGeografy
            // 
            this.ckbGeografy.AutoSize = true;
            this.ckbGeografy.Checked = true;
            this.ckbGeografy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGeografy.Location = new System.Drawing.Point(248, 163);
            this.ckbGeografy.Name = "ckbGeografy";
            this.ckbGeografy.Size = new System.Drawing.Size(106, 24);
            this.ckbGeografy.TabIndex = 9;
            this.ckbGeografy.Text = "Geografia";
            this.ckbGeografy.UseVisualStyleBackColor = true;
            // 
            // ckbEnglish
            // 
            this.ckbEnglish.AutoSize = true;
            this.ckbEnglish.Checked = true;
            this.ckbEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEnglish.Location = new System.Drawing.Point(248, 225);
            this.ckbEnglish.Name = "ckbEnglish";
            this.ckbEnglish.Size = new System.Drawing.Size(78, 24);
            this.ckbEnglish.TabIndex = 10;
            this.ckbEnglish.Text = "Inglês";
            this.ckbEnglish.UseVisualStyleBackColor = true;
            // 
            // ckbSpanish
            // 
            this.ckbSpanish.AutoSize = true;
            this.ckbSpanish.Checked = true;
            this.ckbSpanish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSpanish.Location = new System.Drawing.Point(248, 287);
            this.ckbSpanish.Name = "ckbSpanish";
            this.ckbSpanish.Size = new System.Drawing.Size(102, 24);
            this.ckbSpanish.TabIndex = 11;
            this.ckbSpanish.Text = "Espanhol";
            this.ckbSpanish.UseVisualStyleBackColor = true;
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjects.Location = new System.Drawing.Point(134, 57);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(253, 29);
            this.lblSubjects.TabIndex = 12;
            this.lblSubjects.Text = "Escolha suas matérias";
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAdd.BackgroundImage")));
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Location = new System.Drawing.Point(449, 163);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(45, 45);
            this.pbxAdd.TabIndex = 13;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.ckbSpanish);
            this.Controls.Add(this.ckbEnglish);
            this.Controls.Add(this.ckbGeografy);
            this.Controls.Add(this.ckbHistory);
            this.Controls.Add(this.ckbPortuguese);
            this.Controls.Add(this.ckbMath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matérias";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbMath;
        private System.Windows.Forms.CheckBox ckbPortuguese;
        private System.Windows.Forms.CheckBox ckbHistory;
        private System.Windows.Forms.CheckBox ckbGeografy;
        private System.Windows.Forms.CheckBox ckbEnglish;
        private System.Windows.Forms.CheckBox ckbSpanish;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.Button button1;
    }
}

