using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspThesisPro.Models.Enum;

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

        [Display(Name = "Gender")]
        [Required]
        public MyIdentityGenders Gender { get; set; }

        [Display(Name = "Role Type")]
        [Required]
        public MyIdentityRoles RoleType { get; set; }
    }
}
