using HighSchoolManagerment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Interfaces
{
    public interface INamHoc
    {
        List<NamHoc> GetAll();
    }
}
