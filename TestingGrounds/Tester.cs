using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using TestingGrounds.Models;

namespace TestingGrounds
{
    public static class Tester
    {
        private const string DB_NAME = @"D:\Projects\TestingGrounds\sLibrary";
        private static SQLiteConnection _connection;

        public static void TestLibraryStuff()
        {
            //if (!File.Exists(DB_NAME))
            //    SQLiteConnection.CreateFile(DB_NAME);

            //_connection = new SQLiteConnection("Data Source=" + DB_NAME + ";Version=3;");
            //_connection.Open();

            using (var lib = new Library())
            {
                var book = new Book();
                book.Name = "The Hobbit";
                book.Description =
                    "Bilbo Baggins is a hobbit who enjoys a comfortable, unambitious life, rarely traveling any farther than his pantry or cellar. But his contentment is disturbed when the wizard Gandalf and a company of dwarves arrive on his doorstep one day to whisk him away on an adventure. They have launched a plot to raid the treasure hoard guarded by Smaug the Magnificent, a large and very dangerous dragon. Bilbo reluctantly joins their quest, unaware that on his journey to the Lonely Mountain he will encounter both a magic ring and a frightening creature known as Gollum.";
                book.Author = new Person() {FirstName = "J.R.R.", LastName = "Tolkien"};

                var book2 = new Book();
                book2.Name = "Hitchhiker's Guide";
                book2.Author = new Person() { FirstName = "Douglas", LastName = "Adams" };
                try
                {
                    Debug.WriteLine(lib.Books.Count());
                    lib.Books.Add(book);
                    lib.Books.Add(book2);
                    lib.SaveChanges();
                    MessageBox.Show("Done");
                }
                catch (DbUpdateException uex)
                {
                    Debug.WriteLine(uex.Message);
                    foreach (var entry in uex.Entries)
                    {
                        Debug.WriteLine(entry.State);
                    }
                }
                catch (DbEntityValidationException  ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }
            }

            using (var lib = new Library())
            {
                var books = from b in lib.Books
                    orderby b.Name
                    select b;

                foreach (var book in books)
                {
                    Debug.WriteLine(book.Name);
                }
            }
        }
    }
}
