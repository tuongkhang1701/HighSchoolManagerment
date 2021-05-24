using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.IServices
{
    public interface IBangDiem
    {
        List<BangDiem> GetByUserId(int id);

        List<BangDiem> Add(int MaND);

        BangDiem GetByMaBD(int MaBD);

        void Update(BangDiem model);
    }
}
