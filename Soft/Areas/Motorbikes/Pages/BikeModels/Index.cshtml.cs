using System.Threading.Tasks;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Pages.Motorbikes.Models;

namespace Loppprojekt.Soft.Areas.Motorbikes.Pages.BikeModels
{
    public class IndexModel : BikeModelsPage
    {
        public IndexModel(IBikeModelsRepository r, IBikeMarksRepository m) : base(r, m) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

