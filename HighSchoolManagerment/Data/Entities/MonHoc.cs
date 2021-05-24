using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchoolManagerment.Data.Entities
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(50)]
        public string MaMH { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

    }
}