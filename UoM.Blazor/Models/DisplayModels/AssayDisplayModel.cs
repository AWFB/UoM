using System.ComponentModel.DataAnnotations;
using UoM.Blazor.Interfaces;
using static UoM.Blazor.Models.Enums.AssayEnums;

namespace UoM.Blazor.Models.DisplayModels
{
    public class AssayDisplayModel : IAssayModel
    {
        public int AssayId { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required]
        public AssayGroup AssayGroup { get; set; }
        [Required]
        public string? AssayName { get; set; }

        // Performance targets
        public double? AnalyticalGoalCVOptimum { get; set; }
        public double? AnalyticalGoalCVDesirable { get; set; }
        public double? AnalyticalGoalCVMinimum { get; set; }

        public double? KitInsertLowCV { get; set; }
        public double? KitInsertMediumCV { get; set; }
        public double? KitInsertHighCV { get; set; }

        public List<AssayDataModel>? AssayData { get; set; }
    }
}
