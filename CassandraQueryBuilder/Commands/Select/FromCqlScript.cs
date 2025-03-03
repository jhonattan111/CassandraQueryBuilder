namespace CassandraQueryBuilder.Commands.Select
{
    public partial class SelectCqlScript : ICqlScript
    {
        public ICqlScript From<T>()
        {
            throw new NotImplementedException();
        }

        public ICqlScript From(string table)
        {
            throw new NotImplementedException();
        }
    }
}
