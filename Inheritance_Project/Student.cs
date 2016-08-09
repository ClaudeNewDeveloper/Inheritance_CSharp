using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class Student : Person
    {
        private String myIdNum; // Student Id Number
        private double myGPA; // grade point average
        // constructor
        public Student(String name, int age, String gender,
                  String idNum, double gpa) : base(name, age, gender)  // use the super class' constructor
        {
            
            // initialize what's new to Student
            myIdNum = idNum;
            myGPA = gpa;
        }
        public String getIdNum()
        {
            return myIdNum;
        }
        public double getGPA()
        {
            return myGPA;
        }
        public void setIdNum(String idNum)
        {
            myIdNum = idNum;
        }
        public void setGPA(double gpa)
        {
            myGPA = gpa;
        }
        
        // using 'new' keyword hides the 'toString()' method of the base class 
        new public String toString()
        {
            return base.toString() +  ", student id: " + myIdNum + ", gpa: " + myGPA;
        }

    }
}
