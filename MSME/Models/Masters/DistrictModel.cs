using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class DistrictModel :BaseEntity
    {
        [Key]
        public int DistrictId { get; set; }

        [Display(Name = "State Name")]
        [Required(ErrorMessage = "Please Enter State")]
        public int StateId { get; set; }

        [Display(Name = "State Zone")]
        [Required(ErrorMessage = "Please Enter Zone")]
        public int ZoneId { get; set; }

        [Display(Name = "District Code")]
        //[Required(ErrorMessage = "Please enter district Code")]
        [StringLength(50)]
        public string? DistrictCode { get; set; }

        [Display(Name = "District Name")]
        [Required(ErrorMessage = "Please Enter District")]
        [StringLength(50)]
        public string? DistrictName { get; set; }
    


        public List<DistrictModel> StateList { get; set; }=new List<DistrictModel> { };

        public string? StateName { get; set; }
    }
}
