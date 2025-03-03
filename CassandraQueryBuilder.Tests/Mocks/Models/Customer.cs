using CassandraQueryBuilder.Attributes;

namespace CassandraQueryBuilder.Tests.Mocks.Models
{
    [CassandraTable("CUSTOMER")]
    internal class Customer : BaseModel
    {

        [CassandraColumn("NAME")]
        public required string Name { get; set; }

        [CassandraColumn("EMAIL")]
        public required string Email { get; set; }
    }
}
