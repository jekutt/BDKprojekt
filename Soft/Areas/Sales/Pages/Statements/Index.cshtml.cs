using System.Threading.Tasks;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Pages.Sales.Statements;

namespace Loppprojekt.Soft.Areas.Sales.Pages.Statements
{
    public class IndexModel : SalesStatementsPage
    {
        public IndexModel(ISalesStatementsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

