using CassandraQueryBuilder.Tests.Mocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraQueryBuilder.Tests.Mocks.TheoryContent.AttributesMock
{
    internal class TableNameMock
    {
        /* 
         * OBJECT
         * EXPECTED TABLE NAME
         */

        public static IEnumerable<object[]> TableNameData()
        {
            yield return new object[]
            {
                typeof(Customer),
                "CUSTOMER"
            };

            yield return new object[]
            {
                typeof(Country),
                "Country"
            };
        }
    }
}
