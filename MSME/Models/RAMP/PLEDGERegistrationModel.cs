using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.RAMP
{
    public class PLEDGERegistrationModel : BaseEntity
    {

        public string PLEDGERegistrationId { get; set; }
        [Display(Name = "RAMP")]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<ZEDRegistrationModel> RAMPList { get; set; } = new List<ZEDRegistrationModel>();

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
        public int? ZoneId { get; set; }
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

        [Display(Name = "Contact No")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        public string? ContactNo { get; set; }

        public string MSMEType { get; set; }
        [Display(Name = "Actual Turnover")]
        [Required(ErrorMessage = "Please Enter Actual Turnover")]
        public string? ActualTurnOver { get; set; }

        [Display(Name = "Udyam No")]
        [Required(ErrorMessage = "Please Enter Udyam No")]
        public int UdyamNo { get; set; }

        [Display(Name = "Approval")]
        [Required(ErrorMessage = "Please Enter Approval")]
        public string Approval { get; set; }

        public string ApprovalRemarks { get; set; }
        public string RejectionRemarks { get; set; }

        [Display(Name = "Forward to Bank")]
        [Required(ErrorMessage = "Please Enter Application Forward to Bank")]
        public string ForwardToBank { get; set; }
        public string Remarks { get; set; }
        public string BankQuery { get; set; }
        public string BankRemarks {  get; set; }
        public string Disbursement { get; set; }

        [Display(Name = "MSME Name")]
        [Required(ErrorMessage = "Please Enter MSME Name")]
        public string MSMEName { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }

        [Display(Name = "PLEDGE Park Location")]
        [Required(ErrorMessage = "Please Enter PLEDGE Park Location")]
        public string PledgeLocation { get; set; }

        [Display(Name = "Revenue Growth")]
        [Required(ErrorMessage = "Please Enter Revenue Growth")]
        public string RevenueGrowth { get; set; }       
        public string JobsCreated { get; set; }

        public string? IpAddress { get; set; }
        public int IsRecordDeleted { get; set; }
        public string ReturnMsg { get; set; }
        public int CreatedBy { get; set; }
       
    }
}
