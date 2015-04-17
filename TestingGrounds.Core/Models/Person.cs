using System.Collections.Generic;
using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Core.Models
{
    public class Person : ModelBase,IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
