using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Pages.Motorbikes.Marks;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeMarks
{
    public class CreateModel : BikeMarksPage
    {
        public CreateModel(IBikeMarksRepository r) : base(r)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
