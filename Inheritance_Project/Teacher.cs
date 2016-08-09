using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class Teacher : Person
    {
        String subject = null;
        double salary = 0.0;
       
        //constructor
      public  Teacher(String myName, int myAge, String myGender, String mySubject, double mySalary) : base(myName, myAge, myGender)
        {
            this.subject = mySubject;
            this.salary = mySalary;
        }


        public void setSubject(String newSubject)
        {
            subject = newSubject;
        }

        public void setSalary(double newSalary)
        {
             salary = newSalary;
        }

        public String getSubject()
        {
            return subject;
        }

        public double getSalary()
        {
            return salary;
        }

        // using 'new' keyword hides the 'toString()' method of the base class Person
        new public String toString()
        {
           
            return base.toString() + ", subject: " + getSubject() + ", salary: " + getSalary();
        }

       


    }
}
