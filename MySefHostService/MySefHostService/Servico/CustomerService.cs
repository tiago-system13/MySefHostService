using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySefHostService.Servico
{
    public class CustomerService : ICustomer
    {
        private readonly List<Customer> customers = new List<Customer>();

        public Customer CreateCustomer(int customerId, string name, string email)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            customer.Name = name;
            customer.Email = email;

            return customer;
        }

        public Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public Customer GetCustomerByName(string customerName)
        {
            return (from c in customers where c.Name == customerName select c).First();
        }
    }
}