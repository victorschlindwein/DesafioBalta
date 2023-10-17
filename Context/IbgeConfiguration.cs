using DesafioBalta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioBalta.Context
{
    public class IbgeConfiguration : IEntityTypeConfiguration<Ibge>
    {
        public void Configure(EntityTypeBuilder<Ibge> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.Property(x => x.City)
                .IsRequired();

            builder.Property(x => x.State)
                .IsRequired();
        }
    }
}
