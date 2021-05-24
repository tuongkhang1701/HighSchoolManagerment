using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Implements
{
    public class LopImp : ILop
    {
        private readonly AppDbContext _context;
        public LopImp(AppDbContext context)
        {
            _context = context;
        }

        public List<Lop> GetAll()
        {
            var list = _context.Lop.ToList();
            return list;
        }

        public async Task<PaginationResult<Lop>> GetAllPaging(GetUserPagingRequest request)
        {
            var query = from l in _context.Lop
                        select l;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Ten.Contains(request.Keyword));
            }
            var totalCount = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToListAsync();

            var pagination = new PaginationResult<Lop>()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalCount,
                Data = data
            };

            return pagination;
        }
    }
}
