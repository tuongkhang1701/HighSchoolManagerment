using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaND { get; set; }

        [Required]
        [StringLength(250)]
        public string HoTen { get; set; }

        public int MaGT { get; set; }

        public int MaTG { get; set; }

        public int? MaLop { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(200)]
        public string HinhAnh { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string MaNND { get; set; }

        [ForeignKey("MaLop")]
        public virtual Lop Lop { get; set; }

        [ForeignKey("MaNND")]
        public virtual NhomNguoiDung NhomNguoiDung { get; set; }

        [ForeignKey("MaGT")]
        public virtual GioiTinh GioiTinh { get; set; }

        [ForeignKey("MaTG")]
        public virtual TonGiao TonGiao { get; set; }

        [NotMapped]
        public string role { get; set; }
    }
}