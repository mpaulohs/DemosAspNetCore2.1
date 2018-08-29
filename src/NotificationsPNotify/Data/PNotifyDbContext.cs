using Microsoft.EntityFrameworkCore;
using NotificationsPNotify.Models;

namespace NotificationsPNotify.Data
{
    public class PNotifyDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public PNotifyDbContext(DbContextOptions<PNotifyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
