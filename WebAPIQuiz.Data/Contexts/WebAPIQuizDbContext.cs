using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Models;
using WebAPIQuiz.Data.Configurations;

namespace WebAPIQuiz.Data.Contexts;

public class WebAPIQuizDbContext : DbContext
{
    public WebAPIQuizDbContext(DbContextOptions<WebAPIQuizDbContext> options) : base(options) {}
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new BlogConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
