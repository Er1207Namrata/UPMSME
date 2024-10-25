using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.RAMP
{
    public class UTCRegistrationModel : BaseEntity
    {
        [Key]
        public int UTCRegistrationId { get; set; }

        [Display(Name = "RAMP")]
        //[StringLength(100)]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<TUSRegistrationModel> RAMPList { get; set; } = new List<TUSRegistrationModel>();

        [Display(Name = "Training Center")]
        [Required(ErrorMessage = "Please Select Training Center")]
        public int TrainingCenterId { get; set; }
        public string? TrainingCenterName { get; set; }
        public List<TrainingCenterModel> TrainingCenterList { get; set; } = new List<TrainingCenterModel>();

        [Display(Name = "Facilitator Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Facilitator Name")]
        public string? FacilitatorName { get; set; }

        [Display(Name = "PhoneNo")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [Required(ErrorMessage = "Please Enter Phone No")]
        [StringLength(10)]
        public string? PhoneNo { get; set; }

        [Display(Name = "EmailId")]
        [Required(ErrorMessage = "Please Enter Email Id")]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address")]
        [StringLength(500)]
        public string? Address { get; set; }

        [Display(Name = "CenterId")]
        [Required(ErrorMessage = "Please Enter CenterId")]
        public string? CenterId { get; set; }

        [Display(Name = "Registration Number")]
        [Required(ErrorMessage = "Please Enter Registration Number")]
        public string? RegistrationNumber { get; set; }

        [Display(Name = "Zone")]
        [Required(ErrorMessage = "Please Select Zone")]
        public int? ZoneId { get; set; }
        public string? ZoneName { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();


        [Display(Name = "District")]
        [Required(ErrorMessage = "Please Select District")]
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public List<DistrictModel> DistrictList { get; set; } = new List<DistrictModel>();


        [Display(Name = "Particulars For Upgradation")]
        [Required(ErrorMessage = "Please Enter Particulars For Upgradation")]
        [StringLength(500)]
        public string? ParticularsForUpgradation { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Please Enter Quantity")]
        [StringLength(50)]
        public string? Quantity { get; set; }

        [Display(Name = "Remarks")]
        [Required(ErrorMessage = "Please Enter Remarks")]
        [StringLength(500)]
        public string? Remarks { get; set; }

        public List<UTCRegistrationModel> UTCRegistrationList { get; set; } = new List<UTCRegistrationModel>();
    }
}
