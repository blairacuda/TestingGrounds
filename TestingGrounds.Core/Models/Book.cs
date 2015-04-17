using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Core.Models
{
    public class Book : ModelBase
    {
        public IPerson Author { get; set; }
    }
}
