namespace CassandraQueryBuilder.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CassandraTableAttribute(string tableName) : Attribute
    {
        public string TableName { get; } = tableName;
    }
}
