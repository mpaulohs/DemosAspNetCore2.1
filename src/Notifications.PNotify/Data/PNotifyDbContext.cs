using Microsoft.EntityFrameworkCore;
using Notifications.PNotify.Models;

namespace Notifications.PNotify.Data
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
