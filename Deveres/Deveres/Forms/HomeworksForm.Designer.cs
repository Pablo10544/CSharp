namespace Deveres
{
    partial class Homeworks
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
            this.dgvSubjectAndHomework = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Homework = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectAndHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubjectAndHomework
            // 
            this.dgvSubjectAndHomework.AllowUserToAddRows = false;
            this.dgvSubjectAndHomework.AllowUserToDeleteRows = false;
            this.dgvSubjectAndHomework.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectAndHomework.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Homework});
            this.dgvSubjectAndHomework.Location = new System.Drawing.Point(50, 49);
            this.dgvSubjectAndHomework.Name = "dgvSubjectAndHomework";
            this.dgvSubjectAndHomework.ReadOnly = true;
            this.dgvSubjectAndHomework.RowTemplate.Height = 28;
            this.dgvSubjectAndHomework.Size = new System.Drawing.Size(444, 246);
            this.dgvSubjectAndHomework.TabIndex = 0;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Materia";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Homework
            // 
            this.Homework.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Homework.HeaderText = "Dever";
            this.Homework.Name = "Homework";
            this.Homework.ReadOnly = true;
            this.Homework.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = global::Deveres.Properties.Resources.PLUS;
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Location = new System.Drawing.Point(368, 301);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(45, 45);
            this.pbxAdd.TabIndex = 1;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // Homeworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 370);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.dgvSubjectAndHomework);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Homeworks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deveres";
            this.Load += new System.EventHandler(this.Homeworks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectAndHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjectAndHomework;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Homework;
    }
}