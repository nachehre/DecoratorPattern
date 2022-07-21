using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_3
{
    public class CustomerService : ICustomerService
    {
        public void Insert(Customer customer)
        {
            Console.WriteLine($"customer inserted with id:{customer.Id} and username:{customer.Name + customer.LastName}");
        }
    }
}
