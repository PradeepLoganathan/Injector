using Injector.Abstractions;
using Microsoft.Extensions.Logging;
using System;

namespace Injector.Implementation
{
    public class Customer:ICustomer
    {
        public void CreateCustomer()
        {
            Console.WriteLine("Creating a customer with concrete class injected using constructor injection");
        }
    }
}
