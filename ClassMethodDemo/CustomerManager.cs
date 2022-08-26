using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer> ();
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name+" has been added.");
        }
        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name + customer.Surname + " : " + customer.Id);
            }
            
        }
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine(customer.Name + " has been deleted.");
        }
    }
}
