using AdminCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Data
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Customer CustomerSignControl(Customer customer);
    }
}
