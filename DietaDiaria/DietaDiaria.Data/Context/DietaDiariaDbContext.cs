using DietaDiaria.Infra.Data._Base;
using DietaDiaria.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DietaDiaria.Infra.Data.Context
{
    public class DietaDiariaDbContext : DbContext
    {
        public DietaDiariaDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DietaDiaria;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new UserMapping());
        }
    }
}
