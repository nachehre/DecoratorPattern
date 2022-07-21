using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_3
{
    public class LogService : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"user insertin logged with info:{message}");
        }
    }
}
