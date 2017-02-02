using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_application
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {

        }

        public Student(string firstname, string lastname, string studentID)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }

    }
}
