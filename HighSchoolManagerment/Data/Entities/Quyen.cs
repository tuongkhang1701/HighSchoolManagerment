using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data
{
    [Table("Quyen")]
    public class Quyen
    {
        [Key]
        [StringLength(50)]
        public string MaQ { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
    }
}