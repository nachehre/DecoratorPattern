using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger loger = new LogService();
            ICustomerService customerServvice = new CustomerService();
            customerServvice = new CustomerServiceWithLog( customerServvice, loger);
            Customer customer = new Customer() { Id = 1, Name = "Zahra", LastName = "Chehreghani" };
            customerServvice.Insert(customer);
            Console.ReadLine();
        }
    }

   
}
