using System.ComponentModel.DataAnnotations;

namespace Loppprojekt.Facade.Common
{
    public abstract class CountryView : UniqueEntityView
    {
        [Required]
        public string Country { get; set; }
    }
}