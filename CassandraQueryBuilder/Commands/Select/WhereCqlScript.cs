namespace CassandraQueryBuilder.Commands.Select
{
    public partial class SelectCqlScript : ICqlScript
    {
        public ICqlScript Where(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public ICqlScript Where<T>()
        {
            throw new NotImplementedException();
        }
    }
}
