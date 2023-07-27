using System.ComponentModel.DataAnnotations.Schema;
using UoM.Blazor.Interfaces;

namespace UoM.Blazor.Models
{
    public class AssayDataModel : IAssayData
    {
        public int Id { get; set; }
        public double Mean { get; set; }
        public double StandardDeviation { get; set; }
        public double Uncertainty => StandardDeviation != 0 ? StandardDeviation * 2 : double.NaN;
        public double CV => Mean != 0 ? (StandardDeviation / Mean) * 100.0 : double.NaN;
        public double UoMRangeLow => Mean != 0 && StandardDeviation != 0 ? Mean - 2 * StandardDeviation : double.NaN;
        public double UoMRangeHigh => Mean != 0 && StandardDeviation != 0 ? Mean + 2 * StandardDeviation : double.NaN;

        public DateTime? DateRangeDataTakenFrom { get; set; }
        public DateTime? DateRangeDataTakenTo { get; set; }
        public int? NumberOfDataPoints { get; set; }
        public string? Comments { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(Assay))]
        public int AssayId { get; set; }
        public AssayModel? Assay { get; set; }
    }
}
