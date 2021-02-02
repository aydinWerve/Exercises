using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.Abstract;

namespace InterfaceAndAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
