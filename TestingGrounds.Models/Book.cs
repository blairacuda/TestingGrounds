using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Models
{
    public class Book : ModelBase
    {
        public Person Author { get; set; }
    }
}
