using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Pages.Motorbikes.Marks;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeMarks
{
    public class EditModel : BikeMarksPage
    {
        public EditModel(IBikeMarksRepository r) : base(r)
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
