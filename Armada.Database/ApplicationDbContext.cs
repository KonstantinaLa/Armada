using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Armada.Entities;

namespace Armada.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Armada")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Emperor> Emperors { get; set; }
        public DbSet<Empire> Empires { get; set; }

        public DbSet<Admiral> Admirals { get; set; }
        public DbSet<Crew> Crews { get; set; }
    }
}
