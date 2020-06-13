using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Motorbikes.Models;

namespace Loppprojekt.Facade.Motorbikes.Models
{
    public static class BikeModelViewFactory
    {
        public static BikeModel Create(BikeModelView v)
        {
            var o = new BikeModel();
            Copy.Members(v, o.Data);

            return o;
        }
        public static BikeModelView Create(BikeModel o)
        {
            var v = new BikeModelView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
