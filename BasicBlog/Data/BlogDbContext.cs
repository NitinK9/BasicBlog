using System;
using BasicBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<BgModel> BlogModel { get; set; }
    }
}
