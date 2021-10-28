using System;
using System.Collections.Generic;

namespace Northwind.Domain
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(string customerID);
        void Add(Customer customer);
    }
}
