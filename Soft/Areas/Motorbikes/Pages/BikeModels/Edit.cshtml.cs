using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Pages.Motorbikes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeModels
{
    public class EditModel : BikeModelsPage
    {
        public EditModel(IBikeModelsRepository r, IBikeMarksRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }

}
