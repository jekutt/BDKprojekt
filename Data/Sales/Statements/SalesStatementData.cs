using Loppprojekt.Data.Common;

namespace Loppprojekt.Data.Sales.Statements
{
    public sealed class SalesStatementData : DefinedEntityData
    {
        public string CarModel { get; set; }
        public string Price { get; set; }
        public string Contacts { get; set; }
    }
}
