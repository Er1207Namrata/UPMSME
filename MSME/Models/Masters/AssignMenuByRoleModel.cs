using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class AssignMenuByRoleModel :BaseEntity
    {
        [Key]
        public int MenuPermissionId { get; set; }

        [Required(ErrorMessage = "Please enter menu name")]
        [Display(Name = "Menu Name")]
        //[Remote(action: "VerifyAssignMenuByRole", controller: "AssignMenuByRole")]
        public int MenuId { get; set; }
        public List<int> SelectedMenuList { get; set; }=new List<int>();

        [Required(ErrorMessage = "Please enter role name")]
        [Display(Name = "Role Name")]
        //[Remote(action: "VerifyAssignMenuByRole", controller: "AssignMenuByRole")]
        public int RoleId { get; set; }

        public string? RoleName { get; set; }
        public string? MenuName { get; set; }

        //public int Active { get; set; }
        //public string Controller { get; set; }
        public List<MenuModel> MenuList { get; set; } = new List<MenuModel>();
        public List<RoleModel> RoleList { get; set; } = new List<RoleModel>();

        public List<AssignMenuByRoleModel> DataList { get; set; } = new List<AssignMenuByRoleModel>();
    }
}
