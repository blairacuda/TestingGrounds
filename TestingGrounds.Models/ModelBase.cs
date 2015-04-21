using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight;

namespace TestingGrounds.Models
{
    public class ModelBase :ObservableObject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Name is a required field")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
