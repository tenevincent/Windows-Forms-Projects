using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI
{
    public class GenericRepository<T> : IRepository<T>
    {
        public override string ToString()
        {
            return "MyRepository with type : " + typeof(T).Name;
        }
    }


 

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
