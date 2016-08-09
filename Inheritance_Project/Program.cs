using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Coach Bob", 27, "M");
            System.Console.WriteLine(bob.toString());
            

            Student lynne = new Student("Lynne Brooke", 16, "F", "HS95129", 3.5);
            System.Console.WriteLine(lynne.toString());

            Teacher mrJava = new Teacher("Duke Java", 34, "M", "Computer Science", 50000.0);
            System.Console.WriteLine(mrJava.toString());

            CollegeStudent ima = new CollegeStudent("Ima Frosh", 18, "F", "UCB123", 4.0, 1,"English" );
            System.Console.WriteLine(ima.toString());



            System.Console.ReadKey();
        }
    }
}
