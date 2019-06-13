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
    public partial class LoginForm : Form
    {
        List<Subject> listOfSubjects = new List<Subject>();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        { DirectoryInfo d = new DirectoryInfo(@"E:\Deveres\Deveres\bin\Debug\Notepads");
            if (!d.Exists) {
                d.Create();
            }
            
            
            DirectoryInfo Listfolder=new DirectoryInfo(@"E:\Deveres\Deveres\bin\Debug\Notepads\Accounts");
            FileInfo[] arq = Listfolder.GetFiles("*.txt*");
            foreach (FileInfo fi in arq)
            {
                string user=fi.Name.Replace(".txt","");
                cbxName.Items.Add(user);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password;
            string password2;
            string[] searchForPassword = File.ReadAllLines(@"E:\Deveres\Deveres\bin\Debug\Notepads\Accounts\" + cbxName.Text + ".txt");
            password = searchForPassword[0];
            password2 = tbxPassword.Text;
            if (password2 == password)
            {
                using (StreamReader sr = new StreamReader(@"E:\Deveres\Deveres\bin\Debug\Notepads\" + "FirstTime.txt"))
                {  
                        SubjectsForm sbf = new SubjectsForm();
                        sbf.Show();
                        this.Hide();  
                   
                }

              

            } else
            {
                MessageBox.Show("senha incorreta");
            }
        }
    }
}
