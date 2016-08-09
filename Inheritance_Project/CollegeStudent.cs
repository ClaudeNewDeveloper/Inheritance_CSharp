using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class CollegeStudent : Student
    {
        String major = null;
        int year = 0;


        public CollegeStudent(String myName, int myAge, String myGender, String myIdNum, double myGpa, int myYear, String myMajor)
            : base(myName, myAge, myGender, myIdNum, myGpa)
        {
            major = myMajor;
            year = myYear;
        }

        public void setMajor(String newMajor)
        {
            major = newMajor;
        }

        public void setYear(int newYear)
        {
            year = newYear;
        }

        public String getMajor()
        {
           return major;
        }

        public int getYear()
        {
           return year;
        }

        // using 'new' keyword hides the 'toString()' method of the base class Student
        new  public String toString()
        {
            return base.toString()+ ", year: " + getYear() + ", major: " + getMajor()   ;
        }
    }
}
