using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace UoM.Blazor.Models.Enums
{
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
