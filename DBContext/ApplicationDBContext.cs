using Microsoft.EntityFrameworkCore;
using Serilog.Context;
using Microsoft.EntityFrameworkCore;
using BurnSociety.umbraco.custome_models;

namespace BurnSociety.Application
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FullNames).HasColumnName("FullNames");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.Phone).HasColumnName("Phone");
                entity.Property(e => e.Country).HasColumnName("Country");
                entity.Property(e => e.Password).HasColumnName("Password");
              
            });
    }
   
    
}
