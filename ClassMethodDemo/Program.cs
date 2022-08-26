using System;
using System.Collections.Generic;


namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Smith";
            customer1.Surname = "Johnson";
            customer1.Id = 123465;

            Customer customer2 = new Customer();
            customer2.Name = "Williams";
            customer2.Surname = "Brown";
            customer2.Id = 123489;

            Customer customer3 = new Customer();
            customer3.Name = "Garcia";
            customer3.Surname = "Miller";
            customer3.Id = 123447;

            List<Customer> list = new List<Customer>();
            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);

            foreach (var customer in list)
            {
                Console.WriteLine(customer.Name +" " customer.Surname + " : " + customer.Id);
            }
            CustomerManager customerManager = new CustomerManager();
            customerManager.Delete(customer1);
        }
    }
}