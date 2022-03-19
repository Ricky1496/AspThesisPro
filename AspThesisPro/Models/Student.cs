using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspThesisPro.Models
{
    [Table("Students")]
    public class Student
    {
        
        [Display(Name ="Enrollment Id")]
        public int EnrollmentId { get; set; }

        [Display(Name ="Department Name")]
        [Required]
        [StringLength(100,ErrorMessage ="{0} cannot be more than {1} characters.")]
        public string DepartmentName{ get; set; }

        [Display(Name ="Batch Name")]
        [Required]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string BatchName{ get; set; }

        #region 
               
        [ForeignKey(nameof(Student.User))]
        public string Email { get; set; }

        public MyIdentityUser User { get; set; }

        #endregion

    }
}
