using HighSchoolManagerment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Interfaces
{
    public interface ITKB
    {
        List<TKB> GetAll(int MaLop);

        List<TKB> GetByBuoi(string Buoi);

        List<TKB> GetByMaLop(int MaLop);

        List<TKB> GetBySelection(int MaLop);

        List<TKB> GetByNH(int MaNH);

        List<TKB> GetByBuoi(int MaNH, string Buoi);

        List<TKB> GetByMaLop(int MaNH, string Buoi, int MaLop);
    }
}
