using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;
namespace MSME.Models.RAMP
{
    public class ExportsRegistrationModel
    {
        public string CapacityRegistrationId { get; set; }
        [Display(Name = "RAMP")]       
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<TUSRegistrationModel> RAMPList { get; set; } = new List<TUSRegistrationModel>();

        [Display(Name = "Export Unit")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please Enter Name of Export Unit")]
        public string? ExportUnit { get; set; }

        [Display(Name = "Unit Type")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please Enter Export type of Unit")]
        public string? UnitType { get; set; }

        [Display(Name = "Person Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please Enter Authorized Person Name")]
        public string? PersonName { get; set; }

        [Display(Name = "Contact No")]        
        [Required(ErrorMessage = "Please Enter Contact Number")]
        public int ContactNo { get; set; }
        [Display(Name = "Email Id")]
        [StringLength(200)]
        [Required(ErrorMessage = "Please Enter Email Id")]
        public string? EmailId { get; set; }
        [Display(Name = "Gender")]       
        [Required(ErrorMessage = "Please Enter Gender")]
        public string? Gender { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string? Address { get; set; }
        [Display(Name = "Zone")]
        [Required(ErrorMessage = "Please Select Zone")]
        public int? ZoneId { get; set; }
        public string? Zone { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();

        [Display(Name = "District")]
        [Required(ErrorMessage = "Please Select District")]
        public int? DistrictId { get; set; }
        public string? District { get; set; }
        public List<DistrictModel> DistrictList { get; set; } = new List<DistrictModel>();
        [Display(Name = "Socail Category")]
        [Required(ErrorMessage = "Please Enter Social Cetgory")]
        public string? SocialCategory { get; set; }

        [Display(Name = "MSME Type")]
        [Required(ErrorMessage = "Please Enter MSME Type")]
        public string? MSMEType { get; set; }
        [Display(Name = "Udhyam No")]
        [Required(ErrorMessage = "Please Enter Udhyam Number")]
        public int UdhyamNo { get; set; }
        [Display(Name = "License No")]
        [Required(ErrorMessage = "Please Enter Export License Number")]
        public string LicenseNo { get; set; }
        [Display(Name = "Expiry Date")]
        [Required(ErrorMessage = "Please Enter Export Expiry Date")]
        public DateTime ExpiryDate { get; set; }
        [Display(Name = "No. Of Employees")]
        [Required(ErrorMessage = "Please Enter No. Of Employees")]
        public int NoOfEmployees { get; set; }
        [Display(Name = "Product Category")]
        [Required(ErrorMessage = "Please Enter Product Category")]
        public string ProductCat { get; set; }
        [Display(Name = "HSN Code")]
        [Required(ErrorMessage = "Please Enter Commodity HSN Code")]
        public string HSNCode { get; set; }
        [Display(Name = "Export Value")]
        [Required(ErrorMessage = "Please Enter Export Value")]
        public string ExportValue { get; set; }
        [Display(Name = "No. Of Export Country")]
        [Required(ErrorMessage = "Please Enter Number of Exporting Country")]
        public int NoOfExportCountry { get; set; }
        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Please Enter Country Name")]
        public string CountryName { get; set; }
        [Display(Name = "B2B Workshop No")]
        [Required(ErrorMessage = "Please Enter Reverse B2B Workshop Number")]
        public string B2BWorkshopNo { get; set; }
        [Display(Name = "B2B Workshop Date")]
        [Required(ErrorMessage = "Please Enter Reverse B2B Workshop Date")]
        public DateTime B2BWorkshopDate { get; set; }
        [Display(Name = "Imoprter Name")]
        [Required(ErrorMessage = "Please Enter Name of the Importers")]
        public string ImporterName { get; set; }
        [Display(Name = "Sector")]
        [Required(ErrorMessage = "Please Enter Sector")]
        public string Sector { get; set; }
        public string ImporterFeedback { get; set; }
        public string Location { get; set; }
        public string Survey { get; set; }
        public DateTime SurveyDate { get; set; }
        public string Results { get; set; }

        public string? IPAddress { get; set; }
        public int IsRecordDeleted { get; set; }
        public string ReturnMsg { get; set; }
        public int CreatedBy { get; set; }        
    }
}
