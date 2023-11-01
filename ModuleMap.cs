using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class ModuleMap : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(k => k.CourseID).HasColumnType("int(25)");
            builder.Property(k => k.Title).HasColumnType("nvarchar(25)");
            builder.Property(k => k.Instructors).HasColumnType("nvarchar(25)");
            builder.Property(k => k.StartDate).HasColumnType("int(25)");
            builder.Property(k => k.EndDate).HasColumnType("int(25)");
            builder.Property(k => k.Resources).HasColumnType("nvarchar(250)");


            builder.ToTable(nameof(Module));
        }
    }
}
