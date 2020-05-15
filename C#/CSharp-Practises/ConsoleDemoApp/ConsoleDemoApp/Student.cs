using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp
{
    class Student
    {

        // Private fields of class Student 
        private int rollNo;
        private string stuName;
        private double marks;

        // The attribute MyAttribute is applied 
        // to methods of class Student 
        // Providing details of their utility 
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }

}
