using System.ComponentModel.DataAnnotations;

namespace ReefTank.Models.Corals
{
    public enum CoralType
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Soft")]
        Soft = 1,

        [Display(Name = " LPS (large polyp stony)")]
        LargePolypStony = 2,

        [Display(Name = " SPS (small polyp stony)")]
        SmallPolypStony = 3,
    }
}