using System;
// C# program to display the custom attributes 
using System.Reflection;



namespace ConsoleDemoApp
{

    // Defining a Custom attribute class 
    class CustomAttribute : Attribute
    {

        // Private fields 
        private string title;
        private int _Count;

        // Parameterised Constructor 
        public CustomAttribute(string t, int  count)
        {
            title = t;
            _Count = count;
        }

        // Method to show the Fields  
        // of the CustomAttribute 
        // using reflection 
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);

            // Array to store all methods of a class 
            // to which the attribute may be applied 

            MethodInfo[] methods = classType.GetMethods();

            // for loop to read through all methods 

            for (int i = 0; i < methods.GetLength(0); i++)
            {
                // Creating object array to receive  
                // method attributes returned 
                // by the GetCustomAttributes method 
                object[] attributesArray = methods[i].GetCustomAttributes(true);
                // foreach loop to read through  
                // all attributes of the method 
                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttribute)
                    {
                        // Display the fields of the CustomAttribute 
                        CustomAttribute attributeObject = (CustomAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name, attributeObject.title, attributeObject._Count);
                    }
                }
            }
        }
    }
}
