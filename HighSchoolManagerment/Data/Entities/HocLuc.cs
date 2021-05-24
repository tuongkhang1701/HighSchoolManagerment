using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("HocLuc")]
    public class HocLuc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHL { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }
    }
}
