using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Loppprojekt.Facade.Common;

namespace Loppprojekt.Facade.Motorbikes.Models
{
    public sealed class BikeModelView : DefinedView
    {
        [Required]
        [DisplayName("Mark")]
        public string BikeMarkId { get; set; }

        [Required]
        [DisplayName("Type")]
        public string BikeBodyType { get; set; }

        [Required]
        [DisplayName("Power (kw)")]
        public string BikePower { get; set; }

        [Required]
        [DisplayName("Acceleration 0-100 (s)")]
        public string BikeAcceleration { get; set; }

        [Required]
        [DisplayName("Max Speed (km/h)")]
        public string MaxSpeed { get; set; }
    }
}
