using System;
using System.Collections.Generic;
using System.Linq;
using Loppprojekt.Data.Sales.Statements;

namespace Loppprojekt.Infra.Sales.StatementsDb
{
    public static class StatementsDbInitializer
    {
        internal static SalesStatementData honda = new SalesStatementData
        {
            Name = "Honda",
            CarModel = "CR-V",
            Country = "Japan",
            Description = "Bodytype: touring; Engine: 2.0 R4(110 kW); Fuel: petrol; Mileage: 200,500 km · service book; Drive: four - wheel drive; Transmission: manual",
            Price = "3300 EUR",
            Contacts = "tel:+37554831212",
            YearOfManufacture = Convert.ToDateTime("19/08/2008")
        };
        internal static List<SalesStatementData> salesStatements => new List<SalesStatementData>
        {
            honda
        };

        public static void Initialize(StatementsDbContext db)
        {
            initializeSalesStatements(db);
        }

        private static void initializeSalesStatements(StatementsDbContext db)
        {
            if (db.SalesStatements.Count() != 0) return;
            db.SalesStatements.AddRange(salesStatements);
            db.SaveChanges();
        }
    }
}
