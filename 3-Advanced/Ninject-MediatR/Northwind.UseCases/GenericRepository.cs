using Northwind.Ports.In;

namespace Northwind.UseCases
{
    public class GenericRepository<T> : IRepository<T>
    {
        public override string ToString()
        {
            return "MyRepository with type : " + typeof(T).Name;
        }
    }

}
