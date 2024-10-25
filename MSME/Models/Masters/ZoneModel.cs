using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class ZoneModel : BaseEntity
    {
        [Key]
        public int ZoneId { get; set; }

        [Display(Name = "Zone Name")]
        [Required(ErrorMessage = "Please Enter Zone Name")]
        [StringLength(50)]
        public string? ZoneName { get; set; }

    }
}
