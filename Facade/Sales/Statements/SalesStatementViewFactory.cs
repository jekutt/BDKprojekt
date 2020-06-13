using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Sales.Statements;

namespace Loppprojekt.Facade.Sales.Statements
{
    public static class SalesStatementViewFactory
    {
        public static SalesStatement Create(SalesStatementView v)
        {
            var o = new SalesStatement();
            Copy.Members(v, o.Data);

            return o;
        }
        public static SalesStatementView Create(SalesStatement o)
        {
            var v = new SalesStatementView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
