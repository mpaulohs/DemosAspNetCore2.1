using demo11serve.api.Models;
using Microsoft.EntityFrameworkCore;

namespace demo11serve.api.Data
{

    public class ServeDbContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public ServeDbContext(DbContextOptions<ServeDbContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
