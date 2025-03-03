
using CassandraQueryBuilder.Utils;
using System.Collections;
using System.Text;

namespace CassandraQueryBuilder.Commands.Select
{
    public partial class SelectCqlScript : ICqlScript
    {
        private List<string> _select { get; set; } = [];
        private string _from { get; set; }
        private List<(string, string, string)> _where { get; set; } = [];
        
        public ICqlScript Select(List<string> selectedColumns)
        {
            _select.AddRange(selectedColumns);
            return this;
        }

        public ICqlScript Select<T>()
        {
            _select.AddRange(AttributeUtils.GetColumnsName<T>());
            From<T>();
            return this;
        }

        public string ToScript()
        {
            StringBuilder sb = new();
            
            sb.AppendFormat($" SELECT {String.Join(", ", _select)} ");
            sb.Append($" FROM {_from} ");
            
            sb.Append(";");

            return sb.ToString().Trim().TrimStart(' ');
        }
    }
}
