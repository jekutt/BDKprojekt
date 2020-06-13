using System.Threading.Tasks;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Pages.Sales.Statements;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Sales.Pages.Statements
{
    public class CreateModel : SalesStatementsPage
    {
        public CreateModel(ISalesStatementsRepository r) : base(r)
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
