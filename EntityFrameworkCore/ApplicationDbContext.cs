using EntityFrameworkCore.Configurations;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EntityFrameworkCore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Post>();
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
 