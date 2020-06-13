using Loppprojekt.Data.Sales.Statements;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Sales.Statements
{
    public sealed class SalesStatement : Entity<SalesStatementData>
    {
        public SalesStatement() : this(null) { }

        public SalesStatement(SalesStatementData data) : base(data) { }
    }
}
