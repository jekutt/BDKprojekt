using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Loppprojekt.Facade.Common;

namespace Loppprojekt.Facade.Sales.Statements
{
    public sealed class SalesStatementView : DefinedView
    {
        [Required] 
        [DisplayName("Car's Model")]
        public string CarModel { get; set; }

        [Required]
        [DisplayName("Price")]
        public string Price { get; set; }

        [Required]
        [DisplayName("Contacts")]
        public string Contacts { get; set; }
    }
}
