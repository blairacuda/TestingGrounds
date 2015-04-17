using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace TestingGrounds.Core.ViewModels
{
    public class GenericPropertyViewModel<T> : ViewModelBase
    {
        private T m_selectedItem;

        public T SelectedItem
        {
            get { return m_selectedItem; }
            set { Set(ref m_selectedItem, value); }
        }

        public GenericPropertyViewModel(T item)
        {
                SelectedItem = item;
        }
    }
}
