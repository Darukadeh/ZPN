using Microsoft.EntityFrameworkCore;
using Zarrin.Models.Entities;

namespace Zarrin.DataAccess.Context
{
    public class ZPNContext : DbContext
    {
        public ZPNContext(DbContextOptions<ZPNContext> options)
        : base(options){}
        
        public DbSet<User> Users { get; set; }
    }
}