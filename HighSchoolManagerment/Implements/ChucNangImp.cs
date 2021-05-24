using HighSchoolManagerment.Data;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.ServiceImplements
{
    public class ChucNangImp : IChucNang
    {
        public readonly AppDbContext _context;
        public ChucNangImp(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<ChucNang> GetAll()
        {
            return _context.ChucNang;
        }
    }
}
