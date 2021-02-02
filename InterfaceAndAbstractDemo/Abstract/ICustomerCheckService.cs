using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer);
    }
}
