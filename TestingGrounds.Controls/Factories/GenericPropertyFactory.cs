using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestingGrounds.Controls.Views;
using TestingGrounds.Core.ViewModels;

namespace TestingGrounds.Controls.Factories
{
    public class GenericPropertyFactory
    {
        public Window GetEditWindow<T>() where T : new()
        {
            try
            {
                var vm = new GenericPropertyViewModel<T>(new T());
                var uc = new GenericPropertyEditor {DataContext = vm};
                var win = new Window {Content = uc};

                return win;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
            return null;
        }

    }
}
