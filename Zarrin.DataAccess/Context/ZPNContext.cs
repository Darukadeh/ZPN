using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Zarrin.Models.Entities;

namespace Zarrin.DataAccess.Context
{
    public class ZPNContext : IdentityDbContext
    {
        static ZPNContext()
        {
            AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
                // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
            (context as ZPNContext).History.AddRange(audit.Entries);
        }
        public ZPNContext(DbContextOptions<ZPNContext> options)
        : base(options){}
        
        // Entityframework-Plus audit log entites
        public DbSet<AuditEntry> History { get; set; }
        public DbSet<AuditEntryProperty> HistoryDetails { get; set; }

        // Domain Models
        public DbSet<User> Users { get; set; }
    }
}