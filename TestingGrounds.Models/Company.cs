﻿using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Models
{
    public class Company : ModelBase
    {
        public enum Type { Publisher, Distributor}
        public Type CompanyType { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public Person ContactPerson { get; set; }
    }
}
