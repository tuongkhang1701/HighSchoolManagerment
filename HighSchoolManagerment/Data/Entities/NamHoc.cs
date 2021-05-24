using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("NamHoc")]
    public class NamHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNH { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        public virtual ICollection<Lop> Lops { get; set; }

        public virtual ICollection<TKB> TKBs { get; set; }
    }
}
