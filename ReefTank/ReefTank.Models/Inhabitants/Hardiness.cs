using System.ComponentModel.DataAnnotations;

namespace ReefTank.Models.Inhabitants
{
    public enum Hardiness
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Delicate")]
        Delicate = 1,

        [Display(Name = "Moderate")]
        Average = 2,

        [Display(Name = "Hardy")]
        Hardy = 3
    }
}