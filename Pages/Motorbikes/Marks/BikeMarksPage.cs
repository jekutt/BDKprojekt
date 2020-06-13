using Loppprojekt.Data.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Facade.Motorbikes.Marks;
using Loppprojekt.Pages.Common;

namespace Loppprojekt.Pages.Motorbikes.Marks
{
    public abstract class BikeMarksPage : BasePage<IBikeMarksRepository, BikeMark, BikeMarkView, BikeMarkData>
    {
        protected internal BikeMarksPage(IBikeMarksRepository r) : base(r)
        {
            PageTitle = "Bike's Marks";
        }

        public override string ItemId => Item?.Name ?? string.Empty;
        protected internal override string getPageUrl() => "/Motorbikes/BikeMarks";

        protected internal override BikeMark toObject(BikeMarkView view)
        {
            return BikeMarkViewFactory.Create(view);
        }

        protected internal override BikeMarkView toView(BikeMark obj)
        {
            return BikeMarkViewFactory.Create(obj);
        }
    }
}
