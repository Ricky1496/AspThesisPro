using System.ComponentModel.DataAnnotations;

namespace AspThesisPro.Models.Enum
{
    public enum MyDepartmentNames
    {
        [Display(Name = "Chemistry")]
        Chemistry,

        [Display(Name = "Physics")]
        Physics,

        [Display(Name = "Mathematics and Computing")]
        MathematicsAndComputing,

        [Display(Name = "Computer Science and Engnineering")]
        ComputerScienceAndEngineering,

        [Display(Name = "Mechanical Engineering")]
        MechanicalEngineering,

        [Display(Name = "Electrical Engineering")]
        ElectricalEngineering, 
        
        [Display(Name = "Civil Engineering")]
        CivilEngineering,

        [Display(Name = "Biotechnolgy")]
        Biotechnology,
    }
}
