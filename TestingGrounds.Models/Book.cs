using TestingGrounds.Core.Interfaces;

namespace TestingGrounds.Models
{
    public class Book : ModelBase
    {
        public int BookId { get; set; }
        public Person Author { get; set; }

        public Book()
        {
            Author = new Person();
        }
    }
}
