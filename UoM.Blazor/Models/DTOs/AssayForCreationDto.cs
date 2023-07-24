using System.ComponentModel.DataAnnotations;

namespace UoM.Blazor.Models.DTOs
{
    public record AssayForCreationDto
    {
        [Required]
        public Department Department { get; set; }
        [Required]
        public AssayGroup? AssayGroup { get; set; }
        [Required]
        public string? AssayName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Performance targets
        public double? AnalyticalGoalCVOptimum { get; set; }
        public double? AnalyticalGoalCVDesirable { get; set; }
        public double? AnalyticalGoalCVMinimum { get; set; }

        public double? KitInsertLowCV { get; set; }
        public double? KitInsertMediumCV { get; set; }
        public double? KitInsertHighCV { get; set; }
    }
}
