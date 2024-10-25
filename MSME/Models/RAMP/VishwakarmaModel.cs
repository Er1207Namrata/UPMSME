using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.RAMP
{
    public class VishwakarmaModel : BaseEntity
    {
        [Key]
        public int? VishwakarmaId { get; set; }

        [Display(Name = "RAMP")]
        //[StringLength(100)]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<TUSRegistrationModel> RAMPList { get; set; } = new List<TUSRegistrationModel>();


        [Display(Name = "Artisan Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Artisan Name")]
        public string? ArtisanName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please Select Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please Enter Age")]
        [RegularExpression(@"^([0-9]{2})$", ErrorMessage = "allowed only 2 digit")]
        public int? Age { get; set; }

        [Display(Name = "PhoneNo")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit")]
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


        [Display(Name = "AadhaarNo")]
        [RegularExpression(@"^([0-9]{12})$", ErrorMessage = "allowed only 12 digit")]
        [Required(ErrorMessage = "Please Enter AadhaarNo")]
        [StringLength(12)]
        public string? AadhaarNo { get; set; }

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

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please Select Category")]
        public string? Category { get; set; }

        [Display(Name = "Skill Type")]
        [Required(ErrorMessage = "Please Enter Skill Type")]
        public string? SkillType { get; set; }

        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Please Select Enrollment Date")]
        public string? EnrollmentDate { get; set; }

        [Display(Name = "Artisan Onboarded")]
        [Required(ErrorMessage = "Please Select Artisan Onboarded")]
        public string? ArtisanOnboarded { get; set; }

        [Display(Name = "Approval")]
        [Required(ErrorMessage = "Please Enter Approval")]
        public string? Approval { get; set; }

        [Display(Name = "Artisan Benefited")]
        [Required(ErrorMessage = "Please Enter Artisan Benefited")]
        public string? ArtisanBenefited { get; set; }

        public List<VishwakarmaModel> VishwakarmaList { get; set; } = new List<VishwakarmaModel>();
    }
}
