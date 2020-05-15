namespace ConsoleDemoApp
{
    // Class Employer 
    class Employer
    {

        // Fields of Employer 
        int id;
        string name;

        // Constructor 
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }

        // Applying the custom attribute  
        // CustomAttribute to the getId method 
        [CustomAttribute("Accessor", count: 1)]
        public int getId()
        {
            return id;
        }

        // Applying the custom attribute  
        // CustomAttribute to the getName method 
        [CustomAttribute("Accessor", count: 2)]
        public string getName()
        {
            return name;
        }
    }

    // Class Employee 
    class Employee
    {

        // Fields of Employee 
        int id;
        string name;

        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }

        // Applying the custom  
        // attribute CustomAttribute 
        // to the getId method 
        [CustomAttribute("Accessor", count: 3)]
        public int getId()
        {
            return id;
        }

        // Applying the custom attribute  
        // CustomAttribute to the getName method 
        [CustomAttribute("Accessor", count: 4)]
        public string getName()
        {
            return name;
        }

       public (string name, string vorname) GetEmployeeProperties()
        {


            return ("Vincent Tene", "Kengne Paul");

        }

    }
}
