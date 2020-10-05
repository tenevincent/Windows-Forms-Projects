using FormsModelViewPresenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormsModelViewPresenter.Services
{
    public interface ICustomerService
    { 
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(int id);

        void SaveCustomer(int id, Customer customer);

    }
}
