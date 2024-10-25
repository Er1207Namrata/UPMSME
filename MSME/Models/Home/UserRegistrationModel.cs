using CoreLayout.Models.Common;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Home
{
    public class UserRegistrationModel :BaseEntity
    {
        [Key]
        public int RegistrationId { get; set; }

        [Display(Name = "Name of the Organisation")]
        public string? OrganisationName { get; set; }

        public int? RoleId { get; set; }
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

        //[Display(Name = "Captcha")]
        //[Required(ErrorMessage = "Please Enter Captcha")]
        //public string? Captcha { get; set; }

        [Display(Name = "OTP")]
        //[Required(ErrorMessage = "Please Enter OTP")]
        public string? OTP { get; set; }

        public bool? IsEmailOTPSend { get; set; }
        public bool? IsMobileOTPSend { get; set; }
        public bool? IsVerified { get; set; }
        public string? UniqueId { get; set; }
        public string? EmailVerificationCode { get; set; }
        public string? MobileVerificationCode { get; set; }

        public string ReturnMsg { get; set; }=string.Empty;
    }
}
