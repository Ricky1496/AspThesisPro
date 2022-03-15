using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspThesisPro.Models
{
    public class MyIdentityRole
    {
        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string Description { get; set; }

    }
}
