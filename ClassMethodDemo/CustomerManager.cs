using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" is added.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name +customer.Surname+" : "+customer.Id);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " is deleted.");
        }
    }
}
