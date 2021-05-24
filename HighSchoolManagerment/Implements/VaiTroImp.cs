using HighSchoolManagerment.Data;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.IServices;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagerment.ServiceImplements
{
    public class VaiTroImp : IVaiTro
    {
        public readonly AppDbContext _context;
        public VaiTroImp(AppDbContext context) 
        {
            _context = context;
        }

        public IQueryable<Quyen> GetAll()
        {
            return _context.Quyen;
        }
    }
}