using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class MenuModel :BaseEntity
    {
        [Key]
        public int MenuId { get; set; }

        [Display(Name = "Parent Menu")]
        [Required(ErrorMessage = "Please enter parent menu")]
        public int ParentMenuId { get; set; }

        [Display(Name = "Sub Menu")]
        [Required(ErrorMessage = "Please enter sub menu")]
        public int SubMenuId { get; set; }

        [RegularExpression(@"[a-zA-Z ]*$", ErrorMessage = "Use onle character")]
        [Display(Name = "Controller Name")]
        [Required(ErrorMessage = "Please enter controller name")]
        [StringLength(50)]
        public string Controller { get; set; }

        [RegularExpression(@"[a-zA-Z ]*$", ErrorMessage = "Use onle character")]
        [Display(Name = "Action Name")]
        [Required(ErrorMessage = "Please enter menu url")]
        [StringLength(50)]
        public string Action { get; set; }

        public string? ParentMenuName { get; set; }
        public string? MenuClass { get; set; }
        public string? SubMenuName { get; set; }

        [Display(Name = "Menu Name")]
        [Required(ErrorMessage = "Please enter menu name")]
       // [Remote(action: "VerifyMenuName", controller: "Menu")]
        //[RegularExpression(@"[a-zA-Z ]*$", ErrorMessage = "Use onle character")]
        [StringLength(50)]
        public string MenuName { get; set; }

        //public int Active { get; set; }
        //public int IsRecordDeleted { get; set; }
        //public string IPAddress { get; set; }
        //public int UserId { get; set; }
        public int RoleId { get; set; }

        public List<ParentMenuModel> ParentMenuList { get; set; }=new List<ParentMenuModel>();
        public List<SubMenuModel> SubMenuList { get; set; } = new List<SubMenuModel>();

    }
}
