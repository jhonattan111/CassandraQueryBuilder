using CassandraQueryBuilder.Attributes;

namespace CassandraQueryBuilder.Tests.Mocks.Models
{
    internal abstract class BaseModel
    {
        [CassandraColumn("ID")]
        public Guid Id { get; set; }

        [CassandraColumn("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
    }
}
