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

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("-------------------------");

            customerManager.List();
            Console.WriteLine("---------------------------");
            customerManager.Delete(customer1);
            Console.WriteLine("\nNew List\n");
            customerManager.List();

        }
    }
}