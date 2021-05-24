using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("TKB")]
    public class TKB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTKB { get; set; }

        [StringLength(50)]
        public string Thu { get; set; }

        [StringLength(20)]
        public int Tiet { get; set; }

        public int MaLop { get; set; }

        [StringLength(50)]
        public string MaMH { get; set; }

        public int MaNH { get; set; }

        [StringLength(20)]
        public string Buoi { get; set; }

        [ForeignKey("MaLop")]
        public virtual Lop Lop { get; set; }

        [ForeignKey("MaNH")]
        public virtual NamHoc NamHoc { get; set; }

        [ForeignKey("MaMH")]
        public virtual MonHoc MonHoc { get; set; }


    }
}
