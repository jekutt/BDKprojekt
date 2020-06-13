using Loppprojekt.Data.Motorbikes.Models;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Motorbikes.Models
{
    public sealed class BikeModel : Entity<BikeModelData>
        {
            public BikeModel() : this(null) { }
            public BikeModel(BikeModelData d) : base(d) { }
        }
}
