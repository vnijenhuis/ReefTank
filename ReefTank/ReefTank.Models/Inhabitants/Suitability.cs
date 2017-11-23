using System.ComponentModel.DataAnnotations;

namespace ReefTank.Models.Inhabitants
{
    public enum Suitability
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Suitable")]
        Suitable = 1,

        [Display(Name = "Requires special care")]
        CareRequired = 2,

        [Display(Name = "Requires a specific aquarium.")]
        SpecialAquarium = 3,

        [Display(Name = "Requires experience, knowledge and special care.")]
        ExperienceRequired = 4,

        [Display(Name = "Not suitable for home aquariums.")]
        NotSuitable = 5
    }
}