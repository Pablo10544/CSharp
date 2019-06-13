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
    public partial class AddHomework : Form
    { string subjectName;
        string homework;
        SubjectsForm sbf =new SubjectsForm();
        public List<Subject> listOfSubjects = new List<Subject>();
        Homeworks hm;

        public AddHomework()
        {
            InitializeComponent();
           
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Homeworks hms = new Homeworks(listOfSubjects);
            hms.Show();
            this.Hide();

        }
        public AddHomework(List<Subject> lista) {
            InitializeComponent();
            listOfSubjects = lista;
            ForeachOfList();


        }

        private void btnSave_Click(object sender, EventArgs e)
        { GetData();

            if (tbxHomework.TextLength>0&&cbxSubject.Text!="")
            {
                using (StreamReader sr = new StreamReader(@"C: \Users\Windows\Documents\Visual Studio 2015\Projects\Deveres\Deveres\bin\Debug\Notepads\" + @"Subjects.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null) {
                        string[] dever = linha.Split('@');
                       string name= dever[0];
                         if ((subjectName+" ")==name)
                        {
                            if (dever[1] == homework)
                            {
                                MessageBox.Show("ja cadastrado");

                            }
                            else
                            {
                                if (dever[1]!= null)
                                {
                                   
                                      
                                    }
                                
                                
                               
                                MessageBox.Show("Dever adicionado com sucesso!");
                                hm = new Homeworks(listOfSubjects);
                                using (StreamWriter outputFile = new StreamWriter(@"C:\Users\Windows\Documents\Visual Studio 2015\Projects\Deveres\Deveres\bin\Debug\Notepads" + @"\HomeWork.txt"))
                                {
                                    foreach (Subject subjects in listOfSubjects)
                                    {
                                        if (subjects.SubjectName+" "==name)
                                        {
                                            subjects.Homework = homework;
                                            outputFile.WriteLine(subjects.SubjectName + " @ " +homework);
                                            

                                        }
                                        else
                                        {
                                            outputFile.WriteLine(subjects.SubjectName + " @ "+subjects.Homework);

                                        }
                                    }
                                }
 hm.Show();
  this.Hide();

}
 }

  }  
}
              
               
            }
            else
            {
                MessageBox.Show("Preencha as informações!");
            }
            CleanData();
        }

        private void GetData()
        {
            homework=tbxHomework.Text;
            subjectName=cbxSubject.Text;
                }

        private void CleanData()
        {
            tbxHomework.Text = "";
            cbxSubject.Text = "";
                }
        private void ForeachOfList() {
            foreach (Subject subject in listOfSubjects)
            {
                cbxSubject.Items.Add(subject.SubjectName);
                CleanData();
            }
        }

        private void AddHomework_Load(object sender, EventArgs e)
        {
          
            }
            }
    }

