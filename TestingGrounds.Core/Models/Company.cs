namespace TestingGrounds.Core.Models
{
    public class Company : ModelBase
    {
        public enum Type { Publisher, Distributor}
        public Type CompanyType { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}
