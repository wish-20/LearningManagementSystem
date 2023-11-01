using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(k => k.studentname).HasColumnType("nvarchar(250)");
            builder.Property(k => k.Email).HasColumnType("nvarchar(250)");
            builder.Property(k => k.Birthdate).HasColumnType("nvarchar(25)");
            builder.Property(k => k.Password).HasColumnType("nvarchar(25)");
            builder.Property(k => k.PhoneNo).HasColumnType("nvarchar(25)");

            builder.ToTable(nameof(Student));
        }
    }
}
