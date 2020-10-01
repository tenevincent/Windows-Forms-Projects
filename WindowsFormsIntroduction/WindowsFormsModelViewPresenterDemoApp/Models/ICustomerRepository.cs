using System;
using System.Collections.Generic;
using System.Text;

namespace FormsModelViewPresenter.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(int id);

        void SaveCustomer(int id, Customer customer);
    }
}
