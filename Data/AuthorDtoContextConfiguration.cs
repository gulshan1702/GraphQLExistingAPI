using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Data
{
    public class AuthorDtoContextConfiguration
    {
        private Guid[] _ids;

        public AuthorDtoContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }
    }
}
