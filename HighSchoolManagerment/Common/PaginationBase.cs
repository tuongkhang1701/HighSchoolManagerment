using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Common
{
    public class PaginationBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecord { get; set; }

        public int PageCount {
            get
            {
                var pageCount = (double)TotalRecord / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        
        }
    }
}
