using CassandraQueryBuilder.Attributes;
using CassandraQueryBuilder.Tests.Mocks.Models;
using CassandraQueryBuilder.Utils;
namespace CassandraQueryBuilder.Tests.Tests.AttibutesTest
{
    public class CassandraColumnAttributeTest
    {
        [Fact]
        public void Should_DefineCassandraColumnAttribute()
        {
            Customer customer = new()
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                Email = "johndoe@gmail.com"
            };

            AttributeUtils.GetColumnName<Customer>("Name");

            int attributesLength = customer.GetType().GetCustomAttributes(typeof(CassandraTableAttribute), false).Length;
            Assert.True(attributesLength > 0);
        }
    }
}
