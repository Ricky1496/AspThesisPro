using System.ComponentModel.DataAnnotations;

namespace AspThesisPro.Models.Enum
{
    public enum MyIdentityRoles
    {
        [Display(Name = "Student")]
        Student,
        
        [Display(Name = "Principal")]
        Principal,

        [Display(Name = "Admin")]
        Admin,

        [Display(Name = "Faculty")]
        Faculty,

        [Display(Name = "Mentor")]
        Mentor
    }
}
