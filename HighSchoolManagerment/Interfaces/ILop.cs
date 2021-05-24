using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Interfaces
{
    public interface ILop
    {
        List<Lop> GetAll();

        Task<PaginationResult<Lop>> GetAllPaging(GetUserPagingRequest request);
    }
}