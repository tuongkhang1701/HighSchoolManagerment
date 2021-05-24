using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("TonGiao")]
    public class TonGiao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTG { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }
    }
}
