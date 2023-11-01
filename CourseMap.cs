using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(k => k.CourseName).HasColumnType("nvarchar(250)");
            builder.Property(k => k.Description).HasColumnType("nvarchar(250)");
            builder.Property(k => k.InstructorId).HasColumnType("int(20)");
            builder.Property(k => k.InstructorName).HasColumnType("nvarchar(250)");
            builder.ToTable(nameof(Course));
        }










    }
}
