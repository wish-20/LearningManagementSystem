using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class InstructerMap : IEntityTypeConfiguration<Instructer>
    {
        public void Configure(EntityTypeBuilder<Instructer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(k => k.InstructorName).HasColumnType("nvarchar(250)");
            builder.Property(k => k.Email).HasColumnType("nvarchar(250)");

            builder.ToTable(nameof(Instructer));
        }
    }
}
