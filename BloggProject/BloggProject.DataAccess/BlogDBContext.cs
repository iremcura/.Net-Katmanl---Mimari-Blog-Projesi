using BloggProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace BloggProject.DataAccess
{
   public class BlogDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) //bir yerden referans alınca referans alınan sınıfın özelliklerini bireir kullanmak zorunda degiliz. değiştirebiliriz.
        {
            base.OnConfiguring(optionBuilder);
            optionBuilder.UseSqlServer("Server=DESKTOP-CHFCN5M;Database=BlogProject;uid=sa;pwd=123");
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Rols { get; set; }


    }
}
