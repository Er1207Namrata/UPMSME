using CoreLayout.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MSME.Models.Masters
{
    public class SubMenuModel : BaseEntity
    {
        [Key]
        public int SubMenuId { get; set; }

        [Display(Name = "Sub Menu")]
        [Required(ErrorMessage = "Please enter sub menu")]
        [Remote(action: "VerifySubMenuName", controller: "SubMenu")]
        //[RegularExpression(@"[a-zA-Z ]*$", ErrorMessage = "Use onle character")]
        [StringLength(50)]
        public string SubMenuName { get; set; }

        [Display(Name = "Parent Menu")]
        [Required(ErrorMessage = "Please enter parent menu")]
        public int ParentMenuId { get; set; }

        public string? ParentMenuName { get; set; }

        //public string URL { get; set; }
        //public int IsRecordDeleted { get; set; }

        //public string IPAddress { get; set; }

   

        public List<ParentMenuModel> ParentMenuList { get; set; } = new List<ParentMenuModel>();
    }
}
