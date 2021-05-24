using HighSchoolManagerment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Common
{
    public class DataResultBangDiem
    {
        public DataResultBangDiem(NguoiDung HocSinh, Dictionary<int, List<BangDiem>> DataDetail)
        {
            this.HocSinh = HocSinh;
            this.DataDetail = DataDetail;
        }

        public NguoiDung HocSinh { get; set; }


        public Dictionary<int, List<BangDiem>> DataDetail { get; set; }
    }

}
