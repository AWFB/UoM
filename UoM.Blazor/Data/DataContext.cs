using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UoM.Blazor.Models;

namespace UoM.Blazor.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions opts) : base(opts) { }

        public DbSet<Assay> Assays { get; set; }
        public DbSet<AssayData> AssayData { get; set; }

    }
}
