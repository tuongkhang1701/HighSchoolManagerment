using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("NhomNguoiDung")]
    public class NhomNguoiDung
    {
        [Key]
        [StringLength(20)]
        public string MaNND { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

    }
}
