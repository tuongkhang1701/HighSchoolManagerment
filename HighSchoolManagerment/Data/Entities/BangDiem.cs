using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("BangDiem")]
    public class BangDiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBD { get; set; }

        public int? MaND { get; set; }

        [StringLength(50)]
        [Required]
        public string MaMH { get; set; }

        public double? DiemMiengHK1 { get; set; }

        public double? Diem15PhutHK1 { get; set; }

        public double? Diem1TietHK1 { get; set; }

        public double? DiemThiHK1 { get; set; }

        public double? DTBHK1 { get; set; }

        public double? DiemMiengHK2 { get; set; }

        public double? Diem15PhutHK2 { get; set; }

        public double? Diem1TietHK2 { get; set; }

        public double? DiemThiHK2 { get; set; }

        public double? DTBHK2 { get; set; }

        public double? CaNam { get; set; }

        public int? MaHK { get; set; }

        public int? MaHL { get; set; }

        public int? MaNH { get; set; }


        [ForeignKey("MaHK")]
        public virtual HanhKiem HanhKiem { get; set; }

        [ForeignKey("MaHL")]
        public virtual HocLuc HocLuc { get; set; }

        [ForeignKey("MaND")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaMH")]
        public virtual MonHoc MonHoc { get; set; }
    }
}