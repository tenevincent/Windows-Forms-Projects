using FormsModelViewPresenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormsModelViewPresenter.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._repository = customerRepository;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this._repository.GetAllCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return this._repository.GetCustomer(id);
        }

        public void SaveCustomer(int id, Customer customer)
        {
            this._repository.SaveCustomer(id, customer);
        }
    }
}
