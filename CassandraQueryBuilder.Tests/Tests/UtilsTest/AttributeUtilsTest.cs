using CassandraQueryBuilder.Tests.Mocks.Models;
using CassandraQueryBuilder.Utils;

namespace CassandraQueryBuilder.Tests.Tests.UtilsTest
{
    public class AttributeUtilsTest
    {
        #region GetTableName
        [Fact]
        public void Should_GetTableName_Custom()
        {
            string tableName = "CUSTOMER";
            string result = AttributeUtils.GetTableName<Customer>();
            Assert.Equal(tableName, result);
        }

        [Fact]
        public void Should_GetTableName_Default()
        {

            string tableName = "Country";
            string result = AttributeUtils.GetTableName<Country>();
            Assert.Equal(tableName, result);
        }
        #endregion

        #region GetColumnName
        [Fact]
        public void Should_GetColumnName_Custom()
        {
            string columnName = "NAME";
            string result = AttributeUtils.GetColumnName<Customer>("Name");
            Assert.Equal(columnName, result);
        }

        [Fact]
        public void Should_GetColumnName_Default()
        {
            string columnName = "Name";
            string result = AttributeUtils.GetColumnName<Country>("Name");
            Assert.Equal(columnName, result);
        }

        [Fact]
        public async Task Should_GetColumnName_NotExists()
        {
            Action check = () => AttributeUtils.GetColumnName<Country>("President");

            Exception notExists = Assert.Throws<Exception>(check);
            Assert.Equal(notExists.Message, "NotExists");
        }
        #endregion

        #region GetColumnsName
        private static bool SameContent(string[] a, string[] b)
        {
            if (a.Length != b.Length)
                return false;

            return a.GroupBy(s => s).OrderBy(g => g.Key).Select(g => new { g.Key, Count = g.Count() })
                       .SequenceEqual(b.GroupBy(s => s).OrderBy(g => g.Key).Select(g => new { g.Key, Count = g.Count() }));
        }

        [Fact]
        public void Should_GetColumnsName_Custom()
        {
            string[] columns = ["ID", "NAME", "EMAIL", "CREATED_AT"];
            string[] result = AttributeUtils.GetColumnsName<Customer>();

            Assert.True(SameContent(columns, result));
        }

        [Fact]
        public void Should_GetColumnsName_Default()
        {
            string[] columns = ["ID", "Name", "Abbreviation", "CREATED_AT"];
            string[] result = AttributeUtils.GetColumnsName<Country>();

            Assert.True(SameContent(columns, result));
        }
        #endregion
    }
}
