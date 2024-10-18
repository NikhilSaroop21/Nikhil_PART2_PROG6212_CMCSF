using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nikhil_PART2_PROG6212_CMCSF.Models;


namespace Nikhil_PART2_PROG6212_CMCSF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        // Add this line to include the Claims DbSet
        public DbSet<Claim> Claims { get; set; }
    }
}
