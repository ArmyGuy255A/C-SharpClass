using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EFCoreShapes.Models;

namespace EFCoreShapes.Context
{
    public class ShapesContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Circle> Circles {get; set;}
        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<Triangle> Triangles { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EFCoreShapes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Circle>.
        //}
        }
}
