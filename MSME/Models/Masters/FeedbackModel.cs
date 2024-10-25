using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class FeedbackModel : BaseEntity
    {
        [Key]
        public int FeedbackId { get; set; }

        [Display(Name = "Name of the Participant")]
        [Required(ErrorMessage = "Please Enter Name of the Participant")]
        public string ParticipantName { get; set; }

        [Display(Name = "Name of the Organization")]
        [Required(ErrorMessage = "Please Enter Name of the Organization")]
        public string Organization { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please Enter Designation")]
        public string Designation { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Please Enter Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "allowed only 10 digit contact")]
        [StringLength(10)]
        public string ContactNumber { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Please Enter Email ID")]
        [EmailAddress]
        public string EmailId { get; set; }





        [Display(Name = "How was the RAMP Workshop managed")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string RAMPWorkshopManaged { get; set; }


        [Display(Name = "Required")]
        [Required(ErrorMessage = "Please Select Atleast One Scoring (Indicators a)")]
        public string RAMPWorkshopManagedScoring { get; set; }




        [Display(Name = "How was your experience at RAMP Workshop")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string RAMPWorkshopExperience { get; set; }


        [Display(Name = "Required")]
        [Required(ErrorMessage = "Please Select Atleast One Scoring (Indicators b)")]
        public string RAMPWorkshopExperienceScoring { get; set; }




        [Display(Name = "How well was the information shared at Workshop")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string RAMPWorkshopInformation { get; set; }


        [Display(Name = "Required")]
        [Required(ErrorMessage = "Please Select Atleast One Scoring (Indicators c)")]
        public string RAMPWorkshopInformationScoring { get; set; }



        [Display(Name = "How relevant were the topics at the Workshop")]
        [Required(ErrorMessage = "Please Enter Address")]
        public string RAMPWorkshopTopics { get; set; }

        [Display(Name = "Required")]
        [Required(ErrorMessage = "Please Select Atleast One Scoring (Indicators d)")]
        public string RAMPWorkshopTopicsScoring { get; set; }


        [Display(Name = "Did you find the RAMP Workshop to be useful")]
        [Required(ErrorMessage = "Please Select RAMP Workshop to be useful")]
        public string RAMPWorkshopUseful { get; set; }

        [Display(Name = "Did you face any challenges at the RAMP Workshop")]
       // [Required(ErrorMessage = "Please Select challenges at the RAMP Workshop")]
        public string RAMPWorkshopChallenges { get; set; }

        [Display(Name = "Which session proved to be the most useful/informative")]
        [Required(ErrorMessage = "Please enter session proved to be the most useful/informative")]
        public string RAMPWorkshopSessionUseful { get; set; }

        [Display(Name = "Suggestions (If any)")]
        [Required(ErrorMessage = "Please Enter Suggestions ")]
        public string Challenges { get; set; }
        public string Suggestions { get; set; }

        public string? Suggestions1 { get; set; }

        public string? Suggestions2 { get; set; }

        public string IPAddress { get; set; }

        public List<FeedbackModel> FeedbackList { get; set; }
    }
}
