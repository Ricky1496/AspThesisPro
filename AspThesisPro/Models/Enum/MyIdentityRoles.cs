using System.ComponentModel.DataAnnotations;

namespace AspThesisPro.Models.Enum
{
    public enum MyIdentityRoles
    {
        [Display(Name = "Student")]
        Student,

        [Display(Name = "Admin")]
        Admin,

        [Display(Name = "Faculty")]
        Faculty,
    }
}
