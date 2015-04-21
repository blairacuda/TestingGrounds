using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLiteTestingGrounds;
using TestingGrounds.Controls.Factories;
using TestingGrounds.Models;

namespace TestingGrounds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GenericPropertyFactory m_genFactory;

        public MainWindow()
        {
            InitializeComponent();
            m_genFactory = new GenericPropertyFactory();
        }

        private void btnPerson_Click(object sender, RoutedEventArgs e)
        {
            var win = m_genFactory.GetEditWindow<Person>();
            win.ShowDialog();
        }

        private void btnLibrary_Click(object sender, RoutedEventArgs e)
        {
            var lib = new Library();
            var book = new Book();
            book.Name = "The Hobbit";
            book.Description = "Bilbo Baggins is a hobbit who enjoys a comfortable, unambitious life, rarely traveling any farther than his pantry or cellar. But his contentment is disturbed when the wizard Gandalf and a company of dwarves arrive on his doorstep one day to whisk him away on an adventure. They have launched a plot to raid the treasure hoard guarded by Smaug the Magnificent, a large and very dangerous dragon. Bilbo reluctantly joins their quest, unaware that on his journey to the Lonely Mountain he will encounter both a magic ring and a frightening creature known as Gollum.";
            book.Author = new Person() {FirstName = "J.R.R.", LastName = "Tolkien"};
            lib.Books.Add(book);
            lib.SaveChangesAsync();
        }
    }
}
