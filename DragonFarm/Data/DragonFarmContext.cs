using DragonFarm.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DragonFarm.Data
{
    public class DragonFarmContext : DbContext
    {
        public DragonFarmContext(DbContextOptions<DragonFarmContext> options)
            : base(options)
        {
        }

        public DbSet<Dragons> Dragons { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<UserDragons> UserDragons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDragons>(entity =>
            {
                entity.HasKey(ud => new { ud.UserId, ud.DragonId });

                entity.HasOne(ud => ud.User)
                    .WithMany()
                    .HasForeignKey(ud => ud.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ud => ud.Dragon)
                    .WithMany()
                    .HasForeignKey(ud => ud.DragonId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Dragons>(entity =>
            {
                entity.ToTable("Dragons");
                entity.Property(d => d.Name).IsRequired().HasMaxLength(100);
                entity.Property(d => d.Image).HasMaxLength(500);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(u => u.FullName).IsRequired().HasMaxLength(200);
                entity.Property(u => u.AddressLine1).IsRequired().HasMaxLength(100);
                entity.Property(u => u.AddressLine2).HasMaxLength(100);
                entity.Property(u => u.City).IsRequired().HasMaxLength(50);
                entity.Property(u => u.State).IsRequired().HasMaxLength(50);
                entity.Property(u => u.ZipCode).IsRequired().HasMaxLength(20);
            });
        }
    }
}
