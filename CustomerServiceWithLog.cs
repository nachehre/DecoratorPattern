using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_3
{
    public class CustomerServiceWithLog : ICustomerService
    {
        readonly ICustomerService _customerService;
        readonly ILogger _logger;
        public CustomerServiceWithLog(ICustomerService customerService, ILogger logger)
        {
            _customerService = customerService;
            _logger = logger;
        }
        public void Insert(Customer customer)
        {
            _logger.Log($"User with id:{customer.Id} and username:{customer.Name + customer.LastName} and insert date:{DateTime.Now}");
            _customerService.Insert(customer);
        }
    }
}
