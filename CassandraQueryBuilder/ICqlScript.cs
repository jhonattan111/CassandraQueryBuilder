namespace CassandraQueryBuilder
{
    public interface ICqlScript
    {
        string ToScript();
        ICqlScript Select(List<string> selectedColumns);
        ICqlScript Select<T>();
        ICqlScript From<T>();
        ICqlScript From(string table);
        ICqlScript Where(Dictionary<string, object> parameters);
        ICqlScript Where<T>();
    }
}
