using Injector.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Injector
{
    class ConsoleApplication
    {
        private readonly ICustomer _customer;
        public ConsoleApplication(ICustomer customer)
        {
            _customer = customer;
        }

        public void Run()
        {
            _customer.CreateCustomer(); 
        }
    }
}
