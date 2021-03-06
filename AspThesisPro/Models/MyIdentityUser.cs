using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspThesisPro.Models
{
    public class MyIdentityUser
        :IdentityUser<Guid>
    {

        [Display(Name = "Display Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MinLength(2)]
        [StringLength(60, ErrorMessage = "{0} should have atleast {1} Characters.")]
        public string DisplayName { get; set; }

        [Display(Name = "Date of Birth")]

        [Required]
        [PersonalData]              // for GDPR Compliance
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is Required")]
        public string Phonenumber { get; set; }

        [Display(Name = "Role Type")]
        [Required]
        public string Roletype { get; set; }
    }
}
