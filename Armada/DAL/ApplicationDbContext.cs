using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using Armada.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Armada.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
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