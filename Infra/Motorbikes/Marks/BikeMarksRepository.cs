using Loppprojekt.Data.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Infra.Common;
using Loppprojekt.Infra.Motorbikes.BikeDb;

namespace Loppprojekt.Infra.Motorbikes.Marks
{
    public class BikeMarksRepository : UniqueEntityRepository<BikeMark, BikeMarkData>, IBikeMarksRepository
    {
        public BikeMarksRepository(BikeDbContext c) : base(c, c.BikeMarks) { }

        protected internal override BikeMark toDomainObjects(BikeMarkData d) => new BikeMark(d);

    }
}
