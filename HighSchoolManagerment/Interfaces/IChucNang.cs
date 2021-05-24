using HighSchoolManagerment.Data;
using HighSchoolManagerment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.IServices
{
    public interface IChucNang
    {
        IQueryable<ChucNang> GetAll();
    }
}
