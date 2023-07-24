using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace UoM.Blazor.Models
{
    public class Assay
    {
        public int AssayId { get; set; }
        public Department Department { get; set; }
        public AssayGroup? AssayGroup { get; set; }
        public string? AssayName { get; set; }

        // Performance targets
        public double? AnalyticalGoalCVOptimum { get; set; }
        public double? AnalyticalGoalCVDesirable { get; set; }
        public double? AnalyticalGoalCVMinimum { get; set; }

        public double? KitInsertLowCV { get; set; }
        public double? KitInsertMediumCV { get; set; }
        public double? KitInsertHighCV { get; set; }

        public List<AssayData>? AssayData { get; set; }
    }

    public enum Department
    {
        [Display(Name = "Routine")]
        Routine,

        [Display(Name = "Newborn Screening")]
        NBS,

        [Display(Name = "Metabolic")]
        Metabolic,

        [Display(Name = "Point of Care")]
        POCT,
    }

    public enum AssayGroup
    {
        [Display(Name = "TMS")]
        TMS,

        [Display(Name = "GSP")]
        GSP,

        [Display(Name = "Sebia 1")]
        SebiaOne,

        [Display(Name = "Sebia 2")]
        SebiaTwo,
    }

    public static class EnumExtensions
    {
        // Get display name rather than prop name
        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()?.GetName();
        }
    }
}
