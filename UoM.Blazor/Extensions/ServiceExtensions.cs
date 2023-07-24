using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UoM.Blazor.Data;
using UoM.Blazor.Models;
using UoM.Blazor.Services;

namespace UoM.Blazor.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.Password.RequireDigit = false;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.SignIn.RequireConfirmedEmail = false;
            })
                .AddEntityFrameworkStores<DataContext>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContextFactory<DataContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureAssayService(this IServiceCollection services) =>
            services.AddScoped<IAssayService, AssayService>();
    }
}
