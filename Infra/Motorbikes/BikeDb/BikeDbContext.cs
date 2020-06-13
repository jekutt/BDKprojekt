using Loppprojekt.Data.Motorbikes.Marks;
using Loppprojekt.Data.Motorbikes.Models;
using Microsoft.EntityFrameworkCore;

namespace Loppprojekt.Infra.Motorbikes.BikeDb
{
    public class BikeDbContext : DbContext
    {
        public BikeDbContext(DbContextOptions<BikeDbContext> options)
            : base(options)
        {
        }

        public DbSet<BikeMarkData> BikeMarks { get; set; }
        public DbSet<BikeModelData> BikeModels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<BikeMarkData>().ToTable(nameof(BikeMarks)).HasKey(x => x.Name); ;
            builder.Entity<BikeModelData>().ToTable(nameof(BikeModels)).HasKey(x => x.Name); ;
        }
    }
}
