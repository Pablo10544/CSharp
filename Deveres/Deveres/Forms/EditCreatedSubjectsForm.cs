using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deveres
{
    public partial class EditCreatedSubjectsForm : Form
    { string subjectName;
        string beforename;
        public EditCreatedSubjectsForm()
        {
            InitializeComponent();
        }
        public EditCreatedSubjectsForm(string name) {
            InitializeComponent();
            beforename = name;
            tbxNewSubjectName.Text = name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            subjectName=tbxNewSubjectName.Text;
            SubjectCreate sjc = new SubjectCreate(subjectName,beforename);
            sjc.Show();
            this.Hide();
        }
    }
}
