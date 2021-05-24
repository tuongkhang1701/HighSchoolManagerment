using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Common
{
    public class PaginationResult<T> : PaginationBase
    {
        public PaginationResult()
        {
            Data = new List<T>();
        }

        public List<T> Data { get; set; }
    }
}
