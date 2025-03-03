using CassandraQueryBuilder.Commands.Select;
using CassandraQueryBuilder.Tests.Mocks.Models;

namespace CassandraQueryBuilder.Tests.Tests.CqlSelectTest
{
    public class SelectTest
    {
        
        [Fact]
        public void Should_CreateSimpleSelect()
        {
            SelectCqlScript cql = new();
            cql.Select<Customer>();

            string script = cql.ToScript();

            string[] columns = ["ID", "NAME", "EMAIL", "CREATED_AT"];
            
            //TODO VERIFY COLUMNS
            Assert.Equal("SELECT ID, NAME, EMAIL, CREATED_AT FROM CUSTOMER", script);
        }
    }
}