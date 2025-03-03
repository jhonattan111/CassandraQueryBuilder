using CassandraQueryBuilder.Utils;

namespace CassandraQueryBuilder.Commands.Select
{
    public partial class SelectCqlScript : ICqlScript
    {
        public ICqlScript From<T>()
        {
            _from = AttributeUtils.GetTableName<T>();
            return this;
        }

        public ICqlScript From(string table)
        {
            _from = table;
            return this;
        }
    }
}
