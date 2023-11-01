using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class VideoMap : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(k => k.URL).HasColumnType("nvarchar(250)");
            builder.Property(k => k.Title).HasColumnType("nvarchar(50)");
            builder.Property(k => k.CourseId).HasColumnType("int(25)");
            builder.Property(k => k.Name).HasColumnType("nvarchar(25)");
            builder.Property(k => k.Duration).HasColumnType("nvarchar(25)");

            builder.ToTable(nameof(Video));
        }
    }
}
