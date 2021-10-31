using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Ports.In
{ 
    public interface IRepository<T>
    {
    }


    public interface ITest
    {
        string DisplayRow();
    }


 

    public class TestImpl : ITest
    {
        public string DisplayRow()
        {
            return "Test service";
        }
    }
}
