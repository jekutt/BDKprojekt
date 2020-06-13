using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Pages.Motorbikes.Marks;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeMarks
{
    public class IndexModel : BikeMarksPage
    {
        public IndexModel(IBikeMarksRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

