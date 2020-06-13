using Loppprojekt.Data.Common;

namespace Loppprojekt.Data.Motorbikes.Models
{
    public sealed class BikeModelData : DefinedEntityData
    {
        public string BikeMarkId { get; set; }
        public string BikeBodyType { get; set; }
        public string BikePower { get; set; }
        public string BikeAcceleration { get; set; }
        public string MaxSpeed { get; set; }
    }
}
