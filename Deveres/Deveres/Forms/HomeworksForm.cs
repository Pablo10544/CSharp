using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Deveres
{
    public partial class Homeworks : Form
    {
        SubjectsForm sjc = new SubjectsForm();
        public List<Subject> listOfSubjects = new List<Subject>();

        public Homeworks()
        {
            InitializeComponent();
            

        }
        public Homeworks(List<Subject> list) {
            InitializeComponent();
             listOfSubjects=list;
           
              
            
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            AddHomework addHomework = new AddHomework(listOfSubjects);
            addHomework.Show();
            this.Hide();
        }

        private void Homeworks_Load(object sender, EventArgs e)
        {
          /*  foreach (Subject subject in listOfSubjects)
            {
                if (subject.Homework != "" && subject.Homework != null)
                {
                    dgvSubjectAndHomework.Rows.Add(subject.SubjectName, subject.Homework);

                }
            }*/
            
           using (StreamReader sr = new StreamReader(@"C: \Users\Windows\Documents\Visual Studio 2015\Projects\Deveres\Deveres\bin\Debug\Notepads\" + @"HomeWork.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                   
                    string[] dever = line.Split('@');
                    dgvSubjectAndHomework.Rows.Add(dever[0], dever[1]);
                    Subject subject=new Subject();

                }
                
            }
            

           
        }
    }
}
