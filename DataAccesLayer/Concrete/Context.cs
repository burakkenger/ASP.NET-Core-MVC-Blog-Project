using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CoreDemo;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasOne(p => p.Category).WithMany(p => p.Blogs).HasForeignKey(p => p.CategoryID);
            modelBuilder.Entity<Comment>().HasOne(p => p.Blog).WithMany(p => p.Comments).HasForeignKey(p => p.BlogID);
            modelBuilder.Entity<Blog>().HasOne(p => p.Writer).WithMany(p => p.Blogs).HasForeignKey(p => p.WriterID);
        }
    }
}
