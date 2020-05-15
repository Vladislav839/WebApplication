using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;



namespace WebApp.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<PostModel> PostModels { get; set; }
        //public DbSet<Friend> Friends { get; set; }
        //public DbSet<Subscriber> Subscribers { get; set; }
        //public DbSet<LikePost> LikesPosts { get; set; }
        

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            /*modelBuilder.Entity<Friend>()
                 .HasKey(t => new { Person1Id = t.PersonInputRequestId, Person2Id = t.PersonOutputRequestId });
            
            modelBuilder.Entity<Friend>()
                .HasOne(sc => sc.PersonOutputRequest)
                .WithMany(u => u.Friends1)
                .HasForeignKey(sc => sc.PersonInputRequestId);
            
            modelBuilder.Entity<Friend>()
                .HasOne(sc => sc.PersonInputRequest)
                .WithMany(u => u.Friends2)
                .HasForeignKey(sc => sc.PersonOutputRequestId);*/

            /*modelBuilder.Entity<LikePost>()
                .HasKey(t => new {t.RatingPersonId, t.PostId});
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.RatingPerson)
                .WithMany(up => up.LikesPosts)
                .HasForeignKey(u => u.RatingPersonId);
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.PostModel)
                .WithMany(up => up.LikesPost)
                .HasForeignKey(u => u.RatingPersonId);*/
            
            /*modelBuilder.Entity<Subscriber>()
                .HasKey(t => new {t.senderId, t.targetId});
            
            modelBuilder.Entity<Subscriber>().HasOne(p => p.sender)
                .WithMany(up => up.OutputSubscribtions)
                .HasForeignKey(u => u.senderId);
            
            modelBuilder.Entity<Subscriber>().HasOne(p => p.target)
                .WithMany(up => up.InputSubscriptions)
                .HasForeignKey(u => u.targetId);*/
            
        }

        

        

    }
}