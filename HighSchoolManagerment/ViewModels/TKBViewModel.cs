using HighSchoolManagerment.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighSchoolManagerment.ViewModels
{
    public class TKBViewModel
    {
        public int MaTKB { get; set; }

        [StringLength(50)]
        public string Thu { get; set; }

        [StringLength(20)]
        public int Tiet { get; set; }

        [StringLength(20)]
        public string MaLop { get; set; }

        [StringLength(50)]
        public string MaMH { get; set; }

        public int MaNH { get; set; }

        [StringLength(20)]
        public string Buoi { get; set; }

        public List<TKB> TKB { get; set; }

        public string Notify { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual NamHoc NamHoc { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}