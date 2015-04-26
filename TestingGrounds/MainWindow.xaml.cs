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
            Tester.TestLibraryStuff();
        }
    }
}
