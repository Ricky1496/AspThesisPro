using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspThesisPro.Models
{
    [Table("Submission Details")]
    public class Submission
    {
        [Key]
        [Required]
        public int SubmissionId { get; set; }

        [Display(Name ="Submission Description")]
        [Required]
        [StringLength(100,ErrorMessage ="{0} cannot have more than {1} characters.")]
        public string SubmissionDescription { get; set; }

        [Display(Name ="Submission Date")]
        [Required]
        public DateTime SubmissionDate { get; set; }

        [Display(Name = "Submission Due Date")]
        [Required]
        public DateTime SubmissionDueDate { get; set; }

        [Required]
        [StringLength (150)]
        public string SubmissionFileUrl { get; set; }

        [Display(Name = "Submission File Content Type")]
        [Required]
        [StringLength(60)]
        public string SubmissionFileContentType { get; set; }

        [Display(Name = "Submission Status")]
        [Required]
        public string SubmissionStatus { get; set; }

        [Display(Name = "Submission Review")]
        [Required]
        public string SubmissionReview{ get; set; }

        [Display(Name = "Submission Review Remark")]
        [Required]
        [StringLength(130,ErrorMessage ="{0} cannot have more than {1} characters.")]
        public string SubmissionReviewRemark{ get; set; }

        #region Navigation Properties to the Project Model

        [ForeignKey(nameof(Submission.Project))]
        public int ProjectId { get; set; }

        public Project Project { get; set; }
        #endregion




    }
}
