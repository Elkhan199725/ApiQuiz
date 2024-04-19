using Microsoft.EntityFrameworkCore;
using WebAPIQuiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Models;

namespace WebAPIQuiz.Data.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blogs");
        
        builder.HasKey(builder => builder.Id);
        builder.Property(b => b.Title).IsRequired().HasMaxLength(500);

        builder.Property(b => b.Description).IsRequired().HasMaxLength(1000);

        builder.Property(b => b.ImageUrl).IsRequired().HasMaxLength(100);
    }
}
