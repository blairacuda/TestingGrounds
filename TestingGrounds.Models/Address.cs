namespace TestingGrounds.Models
{
    public class Address : ModelBase
    {
        public int AddressId { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string ZipCode { get; set; }
    }
}
