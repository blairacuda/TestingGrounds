using System.Collections.Generic;
using System.Data.Entity;
using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        //public ICollection<Book> Books { get; set; }

        public Person()
        {
            ShippingAddress = new Address();
            BillingAddress= new Address();
        }

        
    }
}
