using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Pages.Motorbikes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeModels
{
    public class DetailsModel : BikeModelsPage
    {
        public DetailsModel(IBikeModelsRepository r, IBikeMarksRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter,fixedValue);

            return Page();

        }

    }

}
