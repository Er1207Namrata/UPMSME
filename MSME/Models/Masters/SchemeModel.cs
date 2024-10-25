using CoreLayout.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Masters
{
    public class SchemeModel : BaseEntity
    {
        [Key]
        public int SchemeId { get; set; }

        [Required(ErrorMessage = "Please Enter Scheme Name")]
        [Display(Name = "Scheme Name")]
        public string SchemeName { get; set; }



        [Required(ErrorMessage = "Please Enter Scheme Type")]
        [Display(Name = "Scheme Type")]
        public string SchemeType { get; set; }


        //[Display(Name = "Department Description")]
        //public string? DepartmentDescription { get; set; }

        [Required(ErrorMessage = "Please Select Department Type")]
        [Display(Name = "Department Type")]
        public string DepartmentType { get; set; }


        [Display(Name = "Scheme HindiName")]
        public string? SchemeHindiName { get; set; }

        [Display(Name = "Scheme Description")]
        public string? SchemeDescription { get; set; }
    }
}
