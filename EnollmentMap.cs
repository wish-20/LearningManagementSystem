using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class EnollmentMap : IEntityTypeConfiguration<Enrollment>


    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(k => k.EnrollmentDate).HasColumnType("nvarchar(250)");
            builder.Property(k => k.StudentId).HasColumnType("int(20)");
            builder.Property(k => k.CourseId).HasColumnType("int(20)");
            builder.ToTable(nameof(Enrollment));
        }
    }
}
