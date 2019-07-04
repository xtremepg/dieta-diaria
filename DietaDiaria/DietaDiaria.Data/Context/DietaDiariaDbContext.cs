using DietaDiaria.Generics.Extensions;
using DietaDiaria.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DietaDiaria.Infra.Data.Context
{
    public class DietaDiariaDbContext : DbContext
    {
        public DietaDiariaDbContext() { }

        public DietaDiariaDbContext(DbContextOptions<DietaDiariaDbContext> options) : base(options) { }
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
