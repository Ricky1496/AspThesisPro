using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspThesisPro.Models.Enum
{
    public enum MyIdentityGender
    {
        [Display(Name = "Male")]
        Male,

        [Display(Name = "Female")]
        Female,
        
        [Display(Name = "Third Gender")]
        ThirdGender
    }
}
