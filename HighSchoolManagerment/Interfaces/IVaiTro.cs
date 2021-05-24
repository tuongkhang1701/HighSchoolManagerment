using HighSchoolManagerment.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.IServices
{
    public interface IVaiTro
    {
        IQueryable<Quyen> GetAll();
    }
}
