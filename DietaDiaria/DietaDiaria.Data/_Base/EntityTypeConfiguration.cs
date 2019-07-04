using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietaDiaria.Infra.Data._Base
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
