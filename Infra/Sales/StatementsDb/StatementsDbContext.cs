using Loppprojekt.Data.Sales.Statements;
using Microsoft.EntityFrameworkCore;

namespace Loppprojekt.Infra.Sales.StatementsDb
{
    public class StatementsDbContext : DbContext
    {
        public StatementsDbContext(DbContextOptions<StatementsDbContext> options)
            : base(options)
        {
        }

        public DbSet<SalesStatementData> SalesStatements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<SalesStatementData>().ToTable(nameof(SalesStatements)).HasKey(x => x.Name);
        }
    }
}
