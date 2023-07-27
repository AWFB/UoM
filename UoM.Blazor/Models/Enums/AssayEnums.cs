using System.ComponentModel.DataAnnotations;

namespace UoM.Blazor.Models.Enums
{
    public class AssayEnums
    {
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
    }
}
