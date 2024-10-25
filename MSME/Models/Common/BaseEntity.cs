using System.ComponentModel.DataAnnotations;

namespace CoreLayout.Models.Common
{
    public class BaseEntity
    {
        [Display(Name = "Entry Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Entry By")]
        public int? CreatedBy { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        
        public int? ButtonMasterId { get; set; }
        public int IsRecordDeleted { get; set; }
        public string? IPAddress { get; set; }

        public string? EncryptedId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        //public int RoleId { get; set; }


    }
}
