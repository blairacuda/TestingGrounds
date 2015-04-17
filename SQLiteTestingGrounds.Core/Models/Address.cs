using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTestingGrounds.Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string ZipCode { get; set; }
    }
}
