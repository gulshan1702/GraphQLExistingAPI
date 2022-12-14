using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Data
{
    public class BookDtoContextConfiguration
    {
        private Guid[] _ids;

        public BookDtoContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }
    }
}
