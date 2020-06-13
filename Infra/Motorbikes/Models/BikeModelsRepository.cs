using Loppprojekt.Data.Motorbikes.Models;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Infra.Common;
using Loppprojekt.Infra.Motorbikes.BikeDb;

namespace Loppprojekt.Infra.Motorbikes.Models
{
    public class BikeModelsRepository : UniqueEntityRepository<BikeModel, BikeModelData>, IBikeModelsRepository
    {
        public BikeModelsRepository(BikeDbContext c) : base(c, c.BikeModels) { }

        protected internal override BikeModel toDomainObjects(BikeModelData d) => new BikeModel(d);

    }
}
