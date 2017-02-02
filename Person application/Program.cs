using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Firstname = "Pekka";

            //Create one student object
            Student student = new Student();
            student.Firstname = "Teppo";
            student.Lastname = "Terävä";
            student.Address = "piippukatu 3";
            student.Age = 24;
            student.Phonenumber = "010-12345678";
            student.StudentID = "01234";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "123");
            teacher.Age = 35;
            teacher.Address = "piippukatu 2";
            teacher.Phonenumber = "010-12345678";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            
        }
    }
}
