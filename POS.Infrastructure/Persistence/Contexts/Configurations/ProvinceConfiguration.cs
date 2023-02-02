
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistence.Contexts.Configurations
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> entity)
        {
            entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

            entity.HasOne(d => d.Department)
                .WithMany(p => p.Provinces)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Provinces__Depar__52593CB8");
        }
    }
}
