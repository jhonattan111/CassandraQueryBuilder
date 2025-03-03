namespace CassandraQueryBuilder.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CassandraColumnAttribute(string columnName) : Attribute
    {
        public string ColumnName { get; } = columnName;
    }
}
