using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // FirstTestSimpleAttribeUses();


           var employee = new Employee(1,"Tene");
          var result = employee.GetEmployeeProperties();
          Console.WriteLine(result.name);
          Console.WriteLine(result.vorname);


            SecondTestAttributesProperties();


            Console.ReadKey();
        }

        private static void SecondTestAttributesProperties()
        {

            // Calling the AttributeDisplay 
            // method using the class name 
            // since it is a static method 
            CustomAttribute.AttributeDisplay(typeof(Employer));

            Console.WriteLine();

            CustomAttribute.AttributeDisplay(typeof(Employee));
        }

        private static void FirstTestSimpleAttribeUses()
        {
            Student s = new Student();
            s.setDetails(1, "Taylor", 92.5);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStuName());
            Console.WriteLine("Marks : " + s.getMarks());
        }
    }
}
