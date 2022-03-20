using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspThesisPro.Areas.Manage.ViewModels
{
    public class StudentListViewModel
    {
        [Key]
        [Display(Name = "Student Id")]
        public Guid Id { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [Display(Name = "Roles of the User")]
        public List<string> RolesOfUser { get; set; }
    }
}