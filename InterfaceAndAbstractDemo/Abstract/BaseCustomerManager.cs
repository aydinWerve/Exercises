using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    //Abstract
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
