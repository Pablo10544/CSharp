using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveres
{
   public class Subject
    { 
        string subjectName;
        string homework;

        public string Homework
        {
            get
            {
                return homework;
            }

            set
            {
                homework = value;
            }
        }

        public string SubjectName
        {
            get
            {
                return subjectName;
            }

            set
            {
                subjectName = value;
            }
        }

        public  Subject(string subjectName){
            this.SubjectName = subjectName;
        }public Subject() { }
    }
}
