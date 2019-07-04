using DietaDiaria.Domain.Users.Entities;
using DietaDiaria.Generics.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DietaDiaria.Infra.Data.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.Property(_ => _.Username)
                   .IsRequired();

            builder.Property(_ => _.Password)
                   .IsRequired();

            builder.Property(_ => _.Name)
                   .IsRequired();

            builder.Property(_ => _.Image);

            builder.Ignore(_ => _.CascadeMode);
            builder.Ignore(_ => _.ValidationResult);

            builder.ToTable("User");
        }
    }
}
