using UoM.Blazor.Models;
using static UoM.Blazor.Models.Enums.AssayEnums;

namespace UoM.Blazor.Interfaces
{
    public interface IAssayModel
    {
        int AssayId { get; set; }
        string AssayName { get; set; }
        Department Department { get; set; }
        AssayGroup AssayGroup { get; set; }

        double? AnalyticalGoalCVDesirable { get; set; }
        double? AnalyticalGoalCVMinimum { get; set; }
        double? AnalyticalGoalCVOptimum { get; set; }

        
        double? KitInsertHighCV { get; set; }
        double? KitInsertLowCV { get; set; }
        double? KitInsertMediumCV { get; set; }

        List<AssayDataModel>? AssayData { get; set; }
    }
}