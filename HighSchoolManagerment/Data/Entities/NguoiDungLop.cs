using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("NguoiDungLop")]
    public class NguoiDungLop
    {
        public int MaND { get; set; }

        public int MaLop { get; set; }

        [ForeignKey("MaND")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaLop")]
        public virtual Lop Lop { get; set; }
    }
}
