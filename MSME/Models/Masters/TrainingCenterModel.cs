using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class TrainingCenterModel : BaseEntity
    {
        [Key]
        public int TrainingCenterId { get; set; }

        [Display(Name = "TrainingCenter Name")]
        [Required(ErrorMessage = "Please Enter TrainingCenter Name")]
        public string TrainingCenterName { get; set; }

        public List<TrainingCenterModel> TrainingCenterList { get; set; }=new List<TrainingCenterModel>();
    }
}
