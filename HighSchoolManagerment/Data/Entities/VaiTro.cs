using HighSchoolManagerment.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data
{
    [Table("VaiTro")]
    public class VaiTro
    {
        [StringLength(50)]
        public string MaVT { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNND { get; set; }

        [ForeignKey("RoleId")]
        public virtual Quyen Quyen { get; set; }

        [ForeignKey("UserGroupId")]
        public virtual NhomNguoiDung NhomNguoiDung { get; set; }
    }
}