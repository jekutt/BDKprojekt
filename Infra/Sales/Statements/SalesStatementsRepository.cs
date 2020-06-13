using Loppprojekt.Data.Sales.Statements;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Infra.Common;
using Loppprojekt.Infra.Sales.StatementsDb;

namespace Loppprojekt.Infra.Sales.Statements
{
    public class SalesStatementsRepository : UniqueEntityRepository<SalesStatement, SalesStatementData>, ISalesStatementsRepository
    {
        public SalesStatementsRepository(StatementsDbContext c) : base(c, c.SalesStatements) { }

        protected internal override SalesStatement toDomainObjects(SalesStatementData d) => new SalesStatement(d);
    }
}
