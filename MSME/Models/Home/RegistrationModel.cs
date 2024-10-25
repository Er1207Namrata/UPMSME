using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Home
{
    public class RegistrationModel :BaseEntity
    {
        [Key]
        public int RegistrationId { get; set; }

        [Display(Name = "Name of the Enterprise (MSME Unit)")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Name of the Enterprise (MSME Unit)")]
        public string EnterpriseName { get; set; }


        [Display(Name = "District of the Enterprise (MSME Unit)")]
        [Required(ErrorMessage = "Please Select District of the Enterprise")]
        public int EnterpriseDistrictId { get; set; }
        public string? EnterpriseDistrict { get; set; }
        public List<DistrictModel> EnterpriseDistrictList { get; set; }

        [Display(Name = "Address of the Enterprise (MSME Unit)")]
        [Required(ErrorMessage = "Please Enter Address of the Enterprise")]
        [StringLength(500)]
        public string EnterpriseAddress { get; set; }

        [Display(Name = "Category of MSME unit")]
        [Required(ErrorMessage = "Please Select Category of MSME unit")]
        public string EnterpriseCategory { get; set; }

        [Display(Name = "Industry Type")]
        [Required(ErrorMessage = "Please Select Industry Type")]
        public string IndustryType { get; set; }

        [Display(Name = "Sector (Product Category)")]
        [Required(ErrorMessage = "Please Select Sector")]
        public string Sector { get; set; }

        [Display(Name = "Udyam Registration No. (NA, if not registered on UR)")]
        [Required(ErrorMessage = "Please Enter Udyam Registration No")]
        [StringLength(20)]
        public string UdyamRegistrationNo { get; set; }

        [Display(Name = "Are You ZED Certified ?")]
        [Required(ErrorMessage = "Please Select ZED Certification")]
        public string IsZEDCertification { get; set; }

        [Display(Name = "ZED Certification Year of Acquisition")]
        [RegularExpression(@"^([0-9]{4})$", ErrorMessage = "allowed only 4 digit year")]
        [StringLength(4)]
        //[Required(ErrorMessage = "Please Select ZED Certification Year of acquisition")]
        public string? IsZEDCertificationYear { get; set; }

        [Display(Name = "ZED Certification Type")]
        //[Required(ErrorMessage = "Please Select ZED Certification Type")]
        public string? IsZEDCertificationType { get; set; }

        [Display(Name = "Year of Incorporation of the Enterprise")]
        [Required(ErrorMessage = "Please Select Year of incorporation of the Enterprise")]
        public string IncorporationYear { get; set; }

        [Display(Name = "Name of the Promoter/Entreprenuer")]
        [Required(ErrorMessage = "Please Enter Promoter/Entreprenuer Name")]
        [StringLength(50)]
        public string Promoter_Entreprenuer_Name { get; set; }

        [Display(Name = "Contact No. of the Promoter/  Entrepreneur")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        [Required(ErrorMessage = "Please Enter Promoter/Entreprenuer Contact")]
        public string Promoter_Entreprenuer_Contact { get; set; }

        [Display(Name = "Email Id of the Promoter/ Entrepreneur")]
        [EmailAddress]
        [Required(ErrorMessage = "Please Enter Promoter/Entreprenuer EmailId")]
        public string Promoter_Entreprenuer_EmailId { get; set; }

        [Display(Name = "Gender of the Promoter/ Entrepreneur")]
        [Required(ErrorMessage = "Please Select Promoter/Entreprenuer Gender")]
        public string Promoter_Entreprenuer_Gender { get; set; }

        [Display(Name = "Age of the Promoter/  Entrepreneur")]
        [Required(ErrorMessage = "Please Enter Promoter/Entreprenuer Age")]
        [RegularExpression(@"^([0-9]{2})$", ErrorMessage = "allowed only 2 digit age")]
        [StringLength(2)]
        public string Promoter_Entreprenuer_Age { get; set; }

        [Display(Name = "Social Category of the Promoter/ Entrepreneur")]
        [Required(ErrorMessage = "Please Enter Promoter/Entreprenuer Social Category")]
        public string Promoter_Entreprenuer_SocialCategory { get; set; }

        [Display(Name = "Are you an Exporter")]
        [Required(ErrorMessage = "Please Select Exporter")]
        public string IsExporter { get; set; }

        [Display(Name = "If an Exporter , mention product exported")]
        //[Required(ErrorMessage = "Please Enter Exported Product")]
        public string? ExportedProduct { get; set; }

        [Display(Name = "If an Exporter , mention country of export")]
        //[Required(ErrorMessage = "Please Enter Exported Country")]
        public string? ExportedCountry { get; set; }

        //FOr Other Registration
        [Display(Name = "Name of the Participant")]
        public string? PartcipantsName { get; set; }

        [Display(Name = "Name of the Organisation")]
        public string? OrganisationName { get; set; }

        [Display(Name = "Designation of the Participant")]
        public string? PartcipantsDesignation { get; set; }

        [Display(Name = "Contact Number of the Participant")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        public string? PartcipantsContact { get; set; }

        [Display(Name = "Email Id of the Participant")]
        [EmailAddress]
        public string? PartcipantsEmailId { get; set; }

        [Display(Name = "Registration Type")]
        [Required(ErrorMessage = "Please Select Registration Type")]
        public string RegistrationType { get; set; }

        public List<RegistrationModel> RegistrationList { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? UserName { get; set; }


        //registration
        [Display(Name = "Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please Enter Name")]
        public string? Name { get; set; }

        [Display(Name = "Contact No")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        [Required(ErrorMessage = "Please Enter ContactNo")]
        public string? ContactNo { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Please Enter EmailId")]
        public string? EmailId { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Password")]
        public string? Password { get; set; }

        [Display(Name = "Captcha")]
        [Required(ErrorMessage = "Please Enter Captcha")]
        public string? Captcha { get; set; }

        [Display(Name = "OTP")]
        [Required(ErrorMessage = "Please Enter OTP")]
        public string? OTP { get; set; }
    }
}
