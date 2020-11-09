using Internship_Exam_2020.dal.Configuration;
using Internship_Exam_2020.dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name="Gabriellia", Age=1, Email="gcattrall0@cloudflare.com"},
                new User { Id = 2, Name = "Gab", Age = 2, Email = "gcfdsfattrall0@cloudflare.com" },
                new User { Id = 3, Name = "Gabie", Age = 3, Email = "gcattrall0@cloudfdfsflare.com" },
                new User { Id = 4, Name = "John", Age = 4, Email = "gcattrallfdf0@cloudflare.com" },
                new User { Id = 5, Name = "Dave", Age = 6, Email = "gcattrafdfdll0@cloudflare.com" },
                new User { Id = 6, Name = "Gabriefdfdllia", Age = 20, Email = "gcattrfddall0@cloudflare.com" }
                        );

            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id=1, Title="First Title", Summary="NJDNJKNFKJSDNKDS", UserId=1},
                new Blog { Id = 2, Title = "First Title", Summary = "NJDNJKNFKJSDNKDS", UserId = 2 },
                new Blog { Id = 3, Title = "First Title", Summary = "NJDNJKNFKJSDNKDS", UserId = 3 },
                new Blog { Id = 4, Title = "First Title", Summary = "NJDNJKNFKJSDNKDS", UserId = 5 },
                new Blog { Id = 5, Title = "First Title", Summary = "NJDNJKNFKJSDNKDS", UserId = 2 },
                new Blog { Id = 6, Title = "First Title", Summary = "NJDNJKNFKJSDNKDS", UserId = 3 }
                );
                

        }

    }
}
