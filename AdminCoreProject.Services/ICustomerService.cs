using AdminCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Services
{
    public interface ICustomerService
    {
        Customer GetCustomer(Customer customer);
        List<Customer> GetCustomers();
    }
}
