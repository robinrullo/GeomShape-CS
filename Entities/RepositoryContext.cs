using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public DbSet<Circle> Circles { get; set; }
        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<Triangle> Triangles { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Circle>().ToTable("circle");
            modelBuilder.Entity<Rectangle>().ToTable("rectangle");
            modelBuilder.Entity<Triangle>().ToTable("triangle");
        }
    }
}