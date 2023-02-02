using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistence.Contexts.Configurations
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> entity)
        {
            entity.Property(e => e.Abbreviation)
                    .HasMaxLength(5)
                    .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
