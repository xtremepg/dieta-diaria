using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietaDiaria.Generics.Configuration
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
