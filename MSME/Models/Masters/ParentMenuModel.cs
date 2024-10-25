using CoreLayout.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class ParentMenuModel : BaseEntity
    {
        [Key]
        public int ParentMenuId { get; set; }

        [Display(Name = "Parent Menu")]
        [Required(ErrorMessage = "Please enter parent menu")]
        [Remote(action: "VerifyParentMenuName", controller: "ParentMenu")]
        //[RegularExpression(@"[a-zA-Z ]*$", ErrorMessage = "Use onle character")]
        [StringLength(50)]
        public string ParentMenuName { get; set; }

        [Display(Name = "Sort By")]
        //[Remote(action: "VerifySortBy", controller: "ParentMenu")]
        //[MaxLength(4)]
        //[MinLength(1)]
        public int SortBy { get; set; }
        //public int IsRecordDeleted { get; set; }

        //public string IPAddress { get; set; }

        //public int UserId { get; set; }

        //public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter menu class")]
        [Display(Name = "Menu Class")]
        public string MenuClass { get; set; }

        //public DateTime ModTs { get; set; }

        //public DateTime CreateTs { get; set; }
    }
}
