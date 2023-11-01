using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using universitysystem.Models;

namespace university_system.EntityMap
{
    public class ReviewMap : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(k => k.CourseID).HasColumnType("int(25)");
            builder.Property(k => k.Title).HasColumnType("nvarchar(25)");
            builder.Property(k => k.Dislikes).HasColumnType("int(25)");
            builder.Property(k => k.Likes).HasColumnType("int(25)");
            builder.Property(k => k.UserID).HasColumnType("int(25)");

            builder.ToTable(nameof(Review));
        }
    }
}
