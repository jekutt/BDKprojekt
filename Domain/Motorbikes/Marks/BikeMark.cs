using Loppprojekt.Data.Motorbikes.Marks;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Motorbikes.Marks
{
    public sealed class BikeMark : Entity<BikeMarkData>
    {
        public BikeMark() : this(null) { }

        public BikeMark(BikeMarkData data) : base(data) { }
    }
}
