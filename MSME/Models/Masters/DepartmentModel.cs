using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class DepartmentModel : BaseEntity
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }


        [Display(Name = "Departent Code")]
        public string? DepartentCode { get; set; }


        [Display(Name = "Department Description")]
        public string? DepartmentDescription { get; set; }

        [Required(ErrorMessage = "Please Select Department Type")]
        [Display(Name = "Department Type")]
        public  string DepartmentType { get; set; }


        [Display(Name = "Department HindiName")]
        public string? DepartmentHindiName { get; set; }
    }
}
