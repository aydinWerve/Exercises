using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
