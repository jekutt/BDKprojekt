using System.Threading.Tasks;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Pages.Sales.Statements;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Sales.Pages.Statements
{
    public class DeleteModel : SalesStatementsPage
    {
        public DeleteModel(ISalesStatementsRepository r) : base(r)
        {
        }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }

}

