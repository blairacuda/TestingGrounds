using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight;

namespace TestingGrounds.Models
{
    public class ModelBase :ObservableObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
