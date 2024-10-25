using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.RAMP
{
    public class ESGAwarenessModel
    {
        public string ESGRegistrationId { get; set; }

        [Display(Name = "RAMP")]
        //[StringLength(100)]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<ESGAwarenessModel> RAMPList { get; set; } = new List<ESGAwarenessModel>();


        [Display(Name = "Name of the Enterprise (MSME Unit)")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Name of the Enterprise (MSME Unit)")]
        public string? MSMEUnit { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address")]
        [StringLength(500)]
        public string? Address { get; set; }

        [Display(Name = "Zone")]
        [Required(ErrorMessage = "Please Select Zone")]
        public int? ZoneID { get; set; }
        public string? Zone { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();

        [Display(Name = "District")]
        [Required(ErrorMessage = "Please Select District")]
        public int? DistrictID { get; set; }
        public string? District { get; set; }
        public List<DistrictModel> DistrictList { get; set; } = new List<DistrictModel>();


        [Display(Name = "Authorized Person")]
        [Required(ErrorMessage = "Please Enter Authorized Person")]
        public string? PersonName { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please Enter Designation")]
        public string? Designation { get; set; }

        [Display(Name = "PhoneNo")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        public string? PhoneNo { get; set; }

        [Display(Name = "EmailId")]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please Select Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please Select Category")]
        public string? SocialCategory { get; set; }

        
        [Required(ErrorMessage = "Please Select Exporter")]
        public int? IsExporter { get; set; }

        [Display(Name = "IECNo")]
        //[Required(ErrorMessage = "Please Select IECNo")]
        public string? IECNo { get; set; }

        [Display(Name = "Export Country")]
        [Required(ErrorMessage = "Please Select Export Country")]
        public string? ExportCountry { get; set; }


        [Display(Name = "Industry Type")]
        [Required(ErrorMessage = "Please Select Industry Type")]
        public string? IndustryType { get; set; }

        [Display(Name = "Annual Turnover")]
        [Required(ErrorMessage = "Please Enter Annual Turnover")]
        public string? AnnualTurnOver { get; set; }

        [Display(Name = "Udyam No")]
        [Required(ErrorMessage = "Please Enter Udyam No")]
        public string? UdyamNo { get; set; }

        [Display(Name = "Workshop Date")]
        [Required(ErrorMessage = "Please Select Workshop Date")]
        public DateTime WorkshopDate { get; set; }

        [Display(Name = "Workshop Num")]
        [Required(ErrorMessage = "Please Select Workshop Number")]
        public string? WorkshopNum { get; set; }

        [Display(Name = "Training Agency")]
        [Required(ErrorMessage = "Please Enter Training Agency")]
        public string? TrainingAgency { get; set; }

        [Display(Name = "Training Center")]
        [Required(ErrorMessage = "Please Enter Training Center")]
        public string? TrainingCenter { get; set; }

        [Display(Name = "AdoptedESG")]
        [Required(ErrorMessage = "Please Enter MSME unit adoted ESG practices")]
        public string? AdoptedESG { get; set; }

        [Display(Name = "NewInternationalCountry")]
        [Required(ErrorMessage = "Please Enter Any new international countries for export")]
        public string? NewInternationalCountry { get; set; }

        [Display(Name = "AnyTechnologyChanges")]
        [Required(ErrorMessage = "Please Enter Adopted any Changes in Technology")]
        public string? AnyTechnologyChanges { get; set; }

        public string? IpAddress { get; set; }
        public int IsRecordDeleted { get; set; }
        public string ReturnMsg {  get; set; }
        public int CreatedBy { get; set; }
    }
}
