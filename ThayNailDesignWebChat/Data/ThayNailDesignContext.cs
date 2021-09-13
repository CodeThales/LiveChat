using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThayNailDesign.Models;

namespace ThayNailDesign.Data
{
    public class ThayNailDesignContext : IdentityDbContext
    {
        public ThayNailDesignContext(DbContextOptions<ThayNailDesignContext> options) : base(options)
        {                
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Agenda> Agenda { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<AppUser>(a => a.App_user)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);
        }
        public DbSet<Message> Message { get; set; }
    }
}
