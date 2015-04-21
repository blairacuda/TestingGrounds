using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingGrounds.Models;

namespace SQLiteTestingGrounds
{
    public class Library : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
