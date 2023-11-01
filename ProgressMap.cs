using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class ProgressMap : IEntityTypeConfiguration<Progress>
    {
        public void Configure(EntityTypeBuilder<Progress> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(k => k.CourseId).HasColumnType("int(25)");
            builder.Property(k => k.StudentID).HasColumnType("int(25)");
            builder.Property(k => k.lesson_id).HasColumnType("int(25)");
            builder.Property(k => k.CompletionStatus).HasColumnType("nvarchar(25)");
            builder.ToTable(nameof(Progress));
        }
    }
}
