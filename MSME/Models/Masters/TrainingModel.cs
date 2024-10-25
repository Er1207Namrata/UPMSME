using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class TrainingModel : BaseEntity
    {
        [Key]
        public int TrainingId { get; set; }

        [Display(Name = "Intervention")]
        [Required(ErrorMessage = "Please Select Intervention")]
        public int RAMPId { get; set; }
        public string? RAMPName { get; set; }
        public List<RAMPModel> RAMPList { get; set; } = new List<RAMPModel>();

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Enter Title")]
        public string? Title { get; set; }


        [Display(Name = "Division")]
        [Required(ErrorMessage = "Please Select Division")]
        public int ZoneId { get; set; }
        public string? ZoneName { get; set; }
        public List<ZoneModel> ZoneList { get; set; } = new List<ZoneModel>();



        [Display(Name = "District")]
        [Required(ErrorMessage = "Please Select District")]
        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public List<DistrictModel> DistrictList { get; set; }=new List<DistrictModel>();

        



        [Display(Name = "Venue")]
        [Required(ErrorMessage = "Please Enter Venue")]
        [StringLength(500)]
        public string Venue { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Time")]
        [Required(ErrorMessage = "Please Select Time")]
        public string Time { get; set; }

        [Display(Name = "Upload Document")]
        public string? UploadDocPath { get; set; }

        [Required(ErrorMessage = "Please Upload Document")]
        [Display(Name = "Upload Document")]
        public IFormFile? UploadDoc { get; set; }
        public List<TrainingModel> TrainingList { get; set; }= new List<TrainingModel>();

    }
}
