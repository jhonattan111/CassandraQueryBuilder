using CassandraQueryBuilder.Attributes;
using System.Reflection;

namespace CassandraQueryBuilder.Utils
{
    public class AttributeUtils
    {
        public static string GetTableName<T>()
        {
            CassandraTableAttribute? attribute = (CassandraTableAttribute?)typeof(T).GetCustomAttributes(typeof(CassandraTableAttribute), true).FirstOrDefault();
            return attribute?.TableName ?? typeof(T).Name;
        }
        public static string GetColumnName<T>(string propertyName)
        {
            PropertyInfo? property = typeof(T).GetProperty(propertyName) ?? throw new Exception("NotExists");

            CassandraColumnAttribute? attribute = (CassandraColumnAttribute?)property.GetCustomAttributes(typeof(CassandraColumnAttribute), true).FirstOrDefault();
            return attribute?.ColumnName ?? propertyName;
        }

        public static string[] GetColumnsName<T>()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            string[] columns = new string[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                columns[i] = GetColumnName<T>(properties[i].Name);
            }
            return columns;
        }
    }
}
