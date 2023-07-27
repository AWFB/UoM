using UoM.Blazor.Models;

namespace UoM.Blazor.Interfaces
{
    public interface IAssayData
    {
        AssayModel? Assay { get; set; }
        int AssayId { get; set; }
        string? Comments { get; set; }
        DateTime CreatedAt { get; set; }
        double CV { get; }
        DateTime? DateRangeDataTakenFrom { get; set; }
        DateTime? DateRangeDataTakenTo { get; set; }
        int Id { get; set; }
        double Mean { get; set; }
        int? NumberOfDataPoints { get; set; }
        double StandardDeviation { get; set; }
        double Uncertainty { get; }
        double UoMRangeHigh { get; }
        double UoMRangeLow { get; }
    }
}