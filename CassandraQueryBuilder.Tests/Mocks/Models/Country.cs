namespace CassandraQueryBuilder.Tests.Mocks.Models
{
    internal class Country : BaseModel
    {
        public required string Name { get; set; }
        public required string Abbreviation { get; set; }
    }
}
