using AdminCoreProject.DataContext;
using AdminCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminCoreProject.Data
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        private AdminCoreDBContext context;

        public CustomerRepository(AdminCoreDBContext context): base(context)
        {
            this.context = context;
        }

        public Customer CustomerSignControl(Customer customer)
        {
            return context.Customers.Where(a => a.Name == customer.Name
            && a.password == customer.password).FirstOrDefault();
        }
    }
}
