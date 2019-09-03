using System;
using System.Collections.Generic;
using System.Text;
using AdminCoreProject.Data;
using AdminCoreProject.Entities;

namespace AdminCoreProject.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Customer GetCustomer(Customer customer)
        {
            return customerRepository.CustomerSignControl(customer);
        }

        public List<Customer> GetCustomers()
        {
            return customerRepository.GetList();
        }
    }
}
