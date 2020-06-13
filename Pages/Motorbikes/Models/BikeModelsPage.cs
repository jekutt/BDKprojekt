using System.Collections.Generic;
using Loppprojekt.Data.Motorbikes.Models;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Facade.Motorbikes.Models;
using Loppprojekt.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Loppprojekt.Pages.Motorbikes.Models
{
    public abstract class BikeModelsPage : BasePage<IBikeModelsRepository, BikeModel, BikeModelView, BikeModelData>
    {
        protected internal BikeModelsPage(IBikeModelsRepository r, IBikeMarksRepository m) : base(r)
        {
            PageTitle = "Bike's Models";
            BikeMarks = createBikeMarks(m);
        }

        private static IEnumerable<SelectListItem> createBikeMarks(IBikeMarksRepository r)
        {
            var list = new List<SelectListItem>();
            var bikeMarks = r.Get().GetAwaiter().GetResult();
            foreach (var m in bikeMarks)
            {
                list.Add(new SelectListItem(m.Data.Name, m.Data.Name));
            }
            return list;
        }

        public IEnumerable<SelectListItem> BikeMarks { get; }

        public override string ItemId => Item?.Name ?? string.Empty;

        protected internal override string getPageUrl() => "/Motorbikes/BikeModels";

        protected internal override string getPageSubTitle()
        {
            return FixedValue is null ?
                base.getPageSubTitle()
                : $"For {GetBikeMarkName(FixedValue)}";
        }

        protected internal override BikeModel toObject(BikeModelView view)
        {
            return BikeModelViewFactory.Create(view);
        }

        protected internal override BikeModelView toView(BikeModel obj)
        {
            return BikeModelViewFactory.Create(obj);
        }
        public string GetBikeMarkName(string bikeMarkId)
        {
            foreach (var m in BikeMarks)
                if (m.Value == bikeMarkId)
                    return m.Text;
            return "Unspecified";
        }
    }
}
