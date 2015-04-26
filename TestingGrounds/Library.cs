using System.Data.Entity;
using TestingGrounds.Models;

namespace TestingGrounds
{
    public class Library : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public Library()
        {
           Configuration.UseDatabaseNullSemantics = true;
        }
    }
}
