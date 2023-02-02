using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistence.Contexts.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> entity)
        {
            entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("URL");
        }
    }
}
