using ArvatoInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Entity.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public virtual DbSet<Station> stations { get; set; }
        public virtual DbSet<Printer> printers { get; set; }
        public virtual DbSet<Computer> computers { get; set; }
        public virtual DbSet<Zebra> zebras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArvatoInventory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbContextOptionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Station>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name);
                entity.Property(s => s.ESPName);
                entity.Property(s => s.Brand);
                entity.Property(s => s.Description);
                entity.Property(s => s.IsWorking);
                entity.Property(s => s.PrinterId);
                entity.Property(s => s.ComputerId);
                entity.Property(s => s.ZebraId);
            });

            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Producent);
                entity.Property(s => s.Model);
                entity.Property(s => s.IsWorking);
                entity.Property(s => s.Description);
                entity.Property(s => s.FV);
                entity.Property(s => s.Gurantee);
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Producent);
                entity.Property(s => s.Model);
                entity.Property(s => s.IsWorking);
                entity.Property(s => s.Description);
                entity.Property(s => s.FV);
                entity.Property(s => s.Gurantee);
            });

            modelBuilder.Entity<Zebra>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Producent);
                entity.Property(s => s.Model);
                entity.Property(s => s.IsWorking);
                entity.Property(s => s.Description);
                entity.Property(s => s.FV);
                entity.Property(s => s.Gurantee);
            });
        }
    }
}
