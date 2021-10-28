using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Domain
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string customerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
