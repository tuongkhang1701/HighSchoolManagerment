using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Implements
{
    public class NamHocImp : INamHoc
    {
        private readonly AppDbContext _context;
        public NamHocImp(AppDbContext context)
        {
            _context = context;
        }

        public List<NamHoc> GetAll()
        {
            return _context.NamHoc.ToList();
        }
    }
}
