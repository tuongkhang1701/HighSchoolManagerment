

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("ChucNang")]

    public class ChucNang
    {
        [Key]
        [StringLength(50)]
        public string MaCN { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string IconCss { get; set; }

        [StringLength(50)]
        public string MaCNCha { get; set; }

        [StringLength(50)]
        public string Url { get; set; }
    }
}