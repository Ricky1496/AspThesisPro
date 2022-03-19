using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspThesisPro.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SubjectId { get; set; }

        [Display(Name = "Subject Name")]
        [Required]
        [StringLength(50,ErrorMessage ="{0} cannot be more than {1} characters.")]
        public string SubjectName { get; set; }

    }
}
