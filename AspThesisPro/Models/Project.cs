using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspThesisPro.Models

{
    [Table("Project Details")]
    public class Project
    {
                
        [Key]
        [Display(Name ="Project Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ProjectId { get; set; }

        [Display(Name ="Project Name")]
        [Required]
        [StringLength(50,ErrorMessage ="{0} Cannot have more than {1} characters.")]
        public string ProjectName { get; set; }

        [Display(Name ="Project Descripton")]
        [Required]
        [StringLength (100,ErrorMessage ="{0} cannot have more than {1} characters.")]
        public string ProjectDescription { get; set; }

        #region Navigation Properties to the Subject Model

        [ForeignKey(nameof(Project.Subject))]
        public short SubjectId { get; set; }

        public Subject Subject { get; set; }

        #endregion

        #region Navigation Properties to the Student Model

        [ForeignKey(nameof(Project.Student))]
        public string Email { get; set; }

        public Student Student { get; set; }

        #endregion
    }
}
