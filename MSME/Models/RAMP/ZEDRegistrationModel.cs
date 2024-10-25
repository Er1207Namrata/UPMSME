using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.RAMP
{
    public class ZEDRegistrationModel : BaseEntity
    {
        [Key]
        public int? ZEDRegistrationId { get; set; }

        [Display(Name = "RAMP")]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<ZEDRegistrationModel> RAMPList { get; set; }=new List<ZEDRegistrationModel>();


        [Display(Name = "Enterprise Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Name of the Enterprise (MSME Unit)")]
        public string? EnterpriseName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address")]
        [StringLength(500)]
        public string? Address { get; set; }

        [Display(Name = "Division")]
        [Required(ErrorMessage = "Please Select Division")]
        public int? ZoneId { get; set; }
        public string? ZoneName { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();


        [Display(Name = "Industry Type")]
        [Required(ErrorMessage = "Please Select Industry Type")]
        public string? IndustryType { get; set; }

        [Display(Name = "Product Type")]
        [Required(ErrorMessage = "Please Select Product Type")]
        public string? ProductType { get; set; }

        [Display(Name = "Authorized Person")]
        [Required(ErrorMessage = "Please Enter Authorized Person")]
        public string? AuthorizedPerson { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please Enter Designation")]
        public string? Designation { get; set; }

        [Display(Name = "PhoneNo")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [Required(ErrorMessage = "Please Enter Phone No")]
        [StringLength(10)]
        public string? PhoneNo { get; set; }

        [Display(Name = "EmailId")]
        [Required(ErrorMessage = "Please Enter Email Id")]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please Select Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please Select Category")]
        public string? Category { get; set; }

        [Display(Name = "Exporter")]
        [Required(ErrorMessage = "Please Select Exporter")]
        public string? Exporter { get; set; }

        [Display(Name = "IECNo")]
        //[Required(ErrorMessage = "Please Select IECNo")]
        public string? IECNo { get; set; }

        [Display(Name = "Commodity Type")]
        [Required(ErrorMessage = "Please Enter Commodity Type")]
        public string? CommodityType { get; set; }

        [Display(Name = "HSNCode")]
        [Required(ErrorMessage = "Please Enter HSNCode")]
        public string? HSNCode { get; set; }

        [Display(Name = "MSME Type")]
        [Required(ErrorMessage = "Please Enter MSME Type")]
        public string? MSMEType { get; set; }

        [Display(Name = "Actual Turnover")]
        [Required(ErrorMessage = "Please Enter Actual Turnover")]
        public string? ActualTurnover { get; set; }

        [Display(Name = "Udyam No")]
        [Required(ErrorMessage = "Please Enter Udyam No")]
        public string? UdyamNo { get; set; }

        [Display(Name = "Workshop Date")]
        [Required(ErrorMessage = "Please Select Workshop Date")]
        public string? WorkshopDate { get; set; }


        [Display(Name = "BatchId")]
        [Required(ErrorMessage = "Please Enter BatchId")]
        public int? BatchId { get; set; }

        [Display(Name = "Facilitator Name")]
        [Required(ErrorMessage = "Please Enter Facilitator Name")]
        public string? FacilitatorName { get; set; }

        [Display(Name = "Training Facilitation Center")]
        [Required(ErrorMessage = "Please Enter Training Facilitation Center")]
        public string? TrainingFacilitationCenter { get; set; }

        [Display(Name = "ZED Certification Opted For")]
        [Required(ErrorMessage = "Please Enter ZED Certification Opted For")]
        public string? ZEDCertificationOptedFor { get; set; }

        [Display(Name = "Assessment Paramenters Approval")]
        [Required(ErrorMessage = "Please Enter Assessment Paramenters Approval")]
        public string? AssessmentParamentersApproval { get; set; }

        [Display(Name = "Approval Remarks")]
        [Required(ErrorMessage = "Please Enter Approval Remarks")]
        public string? ApprovalRemarks { get; set; }

        [Display(Name = "Rejection Remarks")]
        [Required(ErrorMessage = "Please Enter Rejection Remarks")]
        public string? RejectionRemarks { get; set; }

        [Display(Name = "Certificate Status")]
        [Required(ErrorMessage = "Please Enter Certificate Status")]
        public string? CertificateStatus { get; set; }

        [Display(Name = "Training Agency")]
        [Required(ErrorMessage = "Please Enter Training Agency")]
        public string? TrainingAgency { get; set; }

        [Display(Name = "ZED Certification Upgraded Details")]
        [Required(ErrorMessage = "Please Enter Training Agency")]
        public string? ZEDCertUpgradedDetails { get; set; }

        public List<ZEDRegistrationModel> ZEDRegistrationList { get; set; }= new List<ZEDRegistrationModel>();
    }
}
