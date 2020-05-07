using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<UsersPost> UsersPosts { get; set; }
        public DbSet<LikesPost> LikesPosts { get; set; }
        

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Friend>()
                 .HasKey(t => new { t.Person1Id, t.Person2Id });
            
            modelBuilder.Entity<Friend>()
                .HasOne(sc => sc.Person1)
                .WithMany(u => u.Friends1)
                .HasForeignKey(sc => sc.Person1Id);
            
            modelBuilder.Entity<Friend>()
                .HasOne(sc => sc.Person2)
                .WithMany(u => u.Friends2)
                .HasForeignKey(sc => sc.Person2Id);

            modelBuilder.Entity<UsersPost>().HasKey(t => new {t.OwnerId, t.PostId});
            
            modelBuilder.Entity<UsersPost>().HasOne(p => p.Owner)
                .WithMany(up => up.UserPosts)
                .HasForeignKey(u => u.OwnerId);
            
            modelBuilder.Entity<UsersPost>().HasOne(p => p.Post)
                .WithMany(up => up.UserPosts)
                .HasForeignKey(u => u.PostId);
            
            modelBuilder.Entity<LikesPost>().HasKey(t => new {t.RatingPersonId, t.PostId});
            
            modelBuilder.Entity<LikesPost>().HasOne(p => p.RatingPerson)
                .WithMany(up => up.LikesPosts)
                .HasForeignKey(u => u.RatingPersonId);
            
            modelBuilder.Entity<LikesPost>().HasOne(p => p.Post)
                .WithMany(up => up.LikesPosts)
                .HasForeignKey(u => u.RatingPersonId);
            
        }

        

        

    }
}