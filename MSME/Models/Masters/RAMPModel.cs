using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class RAMPModel : BaseEntity
    {
        [Key]

        [Display(Name = "RAMP Name")]
        public int RAMPId { get; set; }

        [Display(Name = "RAMP Name")]
        [Required(ErrorMessage = "Please Enter RAMP Name")]
        [StringLength(100)]
        public string? RAMPName { get; set; }
        public List<RAMPModel> RAMPList { get; set; }=new List<RAMPModel>();

        [Display(Name = "RAMP Code")]
        [StringLength(50)]
        public string? RAMPCode { get; set; }

    }
}
