using CoreLayout.Models.Common;
using MSME.Models.Masters;
using System.ComponentModel.DataAnnotations;
namespace MSME.Models.RAMP
{
    public class CapacityRegistrationModel
    {
        public string CapacityRegistrationId { get; set; }
        [Display(Name = "RAMP")]
        [Required(ErrorMessage = "Please Select RAMP")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<TUSRegistrationModel> RAMPList { get; set; } = new List<TUSRegistrationModel>();


        [Display(Name = "Zone")]
        [Required(ErrorMessage = "Please Select Zone")]
        public int? ZoneId { get; set; }
        public string? Zone { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();
        [Display(Name = "Name")]       
        [Required(ErrorMessage = "Please Enter Name ")]
        public string? Name { get; set; }
        [Display(Name = "Gender")]      
        [Required(ErrorMessage = "Please Enter Gender ")]
        public string? Gender { get; set; }
        [Display(Name = "Phone No.")]
        [Required(ErrorMessage = "Please Enter Phone No. ")]
        public int PhoneNo { get; set; }
        [Display(Name = "Email Id")]
        [Required(ErrorMessage = "Please Enter Email Id ")]
        public string EmailId { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address ")]
        public string Address { get; set; }
        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please Enter Designation ")]
        public string Designation { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Please Enter Department ")]
        public string Department { get; set; }

        [Display(Name = "District")]
        [Required(ErrorMessage = "Please Select District")]
        public int? DistrictId { get; set; }
        public string? District { get; set; }
        public List<DistrictModel> DistrictList { get; set; } = new List<DistrictModel>();
        [Display(Name = "Batch No")]
        [Required(ErrorMessage = "Please Enter Batch No ")]
        public string BatchNo { get; set; }

        [Display(Name = "Batch Size")]
        [Required(ErrorMessage = "Please Enter Batch Size ")]
        public int BatchSize { get; set; }
        [Display(Name = "Training Topic")]
        [Required(ErrorMessage = "Please Enter Training Topic ")]
        public string TrainingTopic { get; set; }
        [Display(Name = "Training Date")]
        [Required(ErrorMessage = "Please Enter Training Date ")]
        public DateTime TrainingDate { get; set; }
        [Display(Name = "Faculty Name")]
        [Required(ErrorMessage = "Please Enter Faculty Name ")]
        public string FacultyName { get; set; }
        [Display(Name = "Duration")]
        [Required(ErrorMessage = "Please Enter Duration")]
        public string Duration { get; set; }
        [Display(Name = "Assesed")]
        [Required(ErrorMessage = "Please Enter Assesed")]
        public string Assesed { get; set; }
        [Display(Name = "Certified")]
        [Required(ErrorMessage = "Please Enter Certified")]
        public string Certified { get; set; }
        public int FeedbackScore { get; set; }
        public string Remraks { get; set; }
        public string? IpAddress { get; set; }
        public int IsRecordDeleted { get; set; }
        public string ReturnMsg { get; set; }
        public int CreatedBy { get; set; }

    }
}
