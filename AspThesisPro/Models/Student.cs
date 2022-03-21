using System;
using AspThesisPro.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AspThesisPro.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short StudentId { get; set; }

        [Display(Name ="Enrollment Id")]
        [Required(ErrorMessage ="{0} cannot be empty.")]
        public int EnrollmentId { get; set; }

        [Display(Name ="Department Name")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(100,ErrorMessage ="{0} cannot be more than {1} characters.")]
        public string DepartmentName{ get; set; }

        [Display(Name ="Batch Name")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string BatchName{ get; set; }

        #region       
        [ForeignKey(nameof(Student.User))]
        public Guid Id { get; set; }

        public MyIdentityUser User { get; set; }

        #endregion
    }
}
