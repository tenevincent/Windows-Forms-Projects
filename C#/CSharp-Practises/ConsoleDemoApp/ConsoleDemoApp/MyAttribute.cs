using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp
{
    // C# program to illustrate the 
    // use of custom attributes 
    using System;

    // Creating Custom attribute MyAttribute 

    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {

        // Provides name of the member 
        private string name;

        // Provides description of the member 
        private string action;

        // Constructor 
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        // property to get name 
        public string Name
        {
            get { return name; }
        }

        // property to get description 
        public string Action
        {
            get { return action; }
        }
    }



}
