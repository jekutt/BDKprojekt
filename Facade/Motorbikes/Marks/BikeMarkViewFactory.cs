using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Motorbikes.Marks;

namespace Loppprojekt.Facade.Motorbikes.Marks
{
    public static class BikeMarkViewFactory
    {
        public static BikeMark Create(BikeMarkView v)
        {
            var o = new BikeMark();
            Copy.Members(v, o.Data);

            return o;
        }
        public static BikeMarkView Create(BikeMark o)
        {
            var v = new BikeMarkView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
