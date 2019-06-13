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
    public partial class SubjectsForm : Form
    {
        Subject sbj = new Subject();
        public SubjectCreate sbc;
        public List<Subject> listOfSubjectsExisted = new List<Subject>();

        public SubjectsForm()
        { 
            InitializeComponent();
        }
        public SubjectsForm(List<Subject> list) {
            InitializeComponent();
            listOfSubjectsExisted = list;
           

        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CheckCheckBox();
            sbc = new SubjectCreate(listOfSubjectsExisted);
            sbc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCheckBox();
            using (StreamWriter outputFile = new StreamWriter(@"C: \Users\Windows\Documents\Visual Studio 2015\Projects\Deveres\Deveres\bin\Debug\Notepads" + @"\HomeWork.txt"))
            {
               
                foreach (Subject subjects in listOfSubjectsExisted)
                {
                    outputFile.WriteLine(subjects.SubjectName + " @ " + subjects.Homework);
                }
            }
            Homeworks hm = new Homeworks(listOfSubjectsExisted);
            hm.Show();
            this.Hide();
        }
        void CheckCheckBox() {
            if (ckbEnglish.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "Inglês"))
                {
                    listOfSubjectsExisted.Add(new Subject("Inglês"));
                }
            }
            if (ckbGeografy.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "Geografia"))
                {
                    listOfSubjectsExisted.Add(new Subject("Geografia"));
                }

            }
            if (ckbHistory.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "História"))
                {

                    listOfSubjectsExisted.Add(new Subject("História"));
                }
            }
            if (ckbPortuguese.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "Português"))
                {

                    listOfSubjectsExisted.Add(new Subject("Português"));
                }
            }
            if (ckbSpanish.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "Espanhol"))
                {
                    listOfSubjectsExisted.Add(new Subject("Espanhol"));
                }
            }
            if (ckbMath.Checked)
            {
                if (!listOfSubjectsExisted.Exists(x => x.SubjectName == "Matemática"))
                { 
                listOfSubjectsExisted.Add(new Subject("Matemática"));
            }
               

            }
        }
    }
}
