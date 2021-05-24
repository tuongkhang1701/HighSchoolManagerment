using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.ServiceImplements
{
    public class MonHocImp : IMonHoc
    {
        public readonly AppDbContext _context;
        public MonHocImp(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<MonHoc> GetAll()
        {
            return _context.MonHoc;
        }
    }
}
