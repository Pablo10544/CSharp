using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deveres
{
    public partial class SubjectCreate : Form
    {
        string subject;
        List<Subject> listOfSubjects = new List<Subject>();
        SubjectsForm sbf;
       
        

        public SubjectCreate()
        {
            InitializeComponent();
            
        }
        public SubjectCreate(string subjectrenamed,string nameBeforeChange) {
            InitializeComponent();
          listOfSubjects.Remove(listOfSubjects.Find(x=>x.SubjectName==nameBeforeChange));
            listOfSubjects.Add(new Subject(subjectrenamed));
            dgvSubjects.Rows.Add(subjectrenamed);
        }
        public SubjectCreate(List<Subject> list) {
            InitializeComponent();
            listOfSubjects = list;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetData();
            if (tbxNameOfSubject.TextLength>0)
            {
                if (listOfSubjects.Exists(x=>x.SubjectName==subject))
                {
                    MessageBox.Show("materia ja existente");
                }
                listOfSubjects.Add(new Subject(subject));
                dgvSubjects.Rows.Add(subject);
                CleanData();
            }
            else
            {
                MessageBox.Show("Preencha o campo");
            }
            using (StreamWriter outputFile = new StreamWriter(@"C: \Users\Windows\Documents\Visual Studio 2015\Projects\Deveres\Deveres\bin\Debug\Notepads" + @"\Subjects.txt"))
            {
                foreach (Subject subjects in listOfSubjects)
                {
                    outputFile.WriteLine(subjects.SubjectName + " @ " + subjects.Homework);
                }
            }

        }
        public void GetData() {
            subject = tbxNameOfSubject.Text;
        }
        public void CleanData() {
            tbxNameOfSubject.Text = "";
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            SubjectsForm sjf = new SubjectsForm(listOfSubjects);
            sjf.Show();
            this.Close();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedCells.Count > 0)
            {
                Subject dsd = listOfSubjects.Find(x => x.SubjectName == dgvSubjects.CurrentRow.Cells[0].Value);
                //   tbxNameOfSubject.Text = dsd.SubjectName; 
                EditCreatedSubjectsForm scef = new EditCreatedSubjectsForm(dsd.SubjectName);
                scef.Show();
                this.Hide();
            }
           
          
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedCells.Count>0)
            {
                if (listOfSubjects.Exists(x => x.SubjectName == dgvSubjects.CurrentRow.Cells[0].Value.ToString()))
                {
                    listOfSubjects.Remove(listOfSubjects.Find(x => x.SubjectName == dgvSubjects.CurrentRow.Cells[0].Value.ToString()));
                    dgvSubjects.Rows.RemoveAt(dgvSubjects.CurrentRow.Cells[0].RowIndex);

                }
            }
           
        }

        private void SubjectCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
