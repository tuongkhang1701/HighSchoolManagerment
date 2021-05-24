using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Common
{
    public class GetUserPagingRequest : PaginationBase
    {
        public string UserGroupId { get; set; }
        public string Keyword { get; set; }
    }
}
