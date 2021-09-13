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
        
        public DbSet<Drawing> Drawings { get; set; }
        public DbSet<Circle> Circles { get; set; }
        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<Triangle> Triangles { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("GeomShape");
            modelBuilder.Entity<Drawing>().ToTable("Drawing");
            modelBuilder.Entity<Circle>().ToTable("Circle");
            modelBuilder.Entity<Rectangle>().ToTable("Rectangle");
            modelBuilder.Entity<Triangle>().ToTable("Triangle");
        }
    }
}