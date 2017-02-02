using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_application
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }

        public Person()
        {

        }

        public Person(string firstsname, string lastname)
        {
            Firstname = firstsname;
            Lastname = lastname;
        }

        protected void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + Phonenumber + " ";
        }
    }
}
