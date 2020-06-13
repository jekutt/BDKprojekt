using Loppprojekt.Data.Sales.Statements;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Facade.Sales.Statements;
using Loppprojekt.Pages.Common;

namespace Loppprojekt.Pages.Sales.Statements
{
    public abstract class SalesStatementsPage : BasePage<ISalesStatementsRepository, SalesStatement, SalesStatementView, SalesStatementData>
    {
        protected internal SalesStatementsPage(ISalesStatementsRepository r) : base(r)
        {
            PageTitle = "Sales Statements";
        }

        public override string ItemId => Item?.Name ?? string.Empty;
        protected internal override string getPageUrl() => "/Sales/Statements";

        protected internal override SalesStatement toObject(SalesStatementView view)
        {
            return SalesStatementViewFactory.Create(view);
        }

        protected internal override SalesStatementView toView(SalesStatement obj)
        {
            return SalesStatementViewFactory.Create(obj);
        }
    }
}
