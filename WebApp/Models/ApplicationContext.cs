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
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<LikePost> LikesPosts { get; set; }
        public DbSet<PhotoModel> PhotoModels { get; set; }
        public DbSet<DialogModel> DialogsModels { get; set; }
        public DbSet<MessageModel> MessagesModels { get; set; }
        public DbSet<UserDialog> UserDialogs { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDialog>()
                .HasKey(t => new { t.UserId, t.DialogId });

            modelBuilder.Entity<UserDialog>().HasOne(u => u.User)
                .WithMany(up => up.UserDialogs)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserDialog>().HasOne(d => d.Dialog)
                .WithMany(dm => dm.UsersDialogs)
                .HasForeignKey(d => d.DialogId);

            modelBuilder.Entity<LikePost>()
                .HasKey(t => new {t.RatingPersonId, t.PostId});
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.RatingPerson)
                .WithMany(up => up.LikesPost)
                .HasForeignKey(u => u.RatingPersonId);
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.PostModel)
                .WithMany(up => up.LikesPost)
                .HasForeignKey(u => u.PostId);

            
            modelBuilder.Entity<LikePost>()
                .HasKey(t => new {t.RatingPersonId, t.PostId});
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.RatingPerson)
                .WithMany(up => up.LikesPost)
                .HasForeignKey(u => u.RatingPersonId);
            
            modelBuilder.Entity<LikePost>().HasOne(p => p.PostModel)
                .WithMany(up => up.LikesPost)
                .HasForeignKey(u => u.PostId);
            
            modelBuilder.Entity<Subscriber>()
                .HasKey(t => new {t.senderId, t.targetId});
            
            modelBuilder.Entity<Subscriber>().HasOne(p => p.sender)
                .WithMany(up => up.OutputSubscribtions)
                .HasForeignKey(u => u.senderId);
            
            modelBuilder.Entity<Subscriber>().HasOne(p => p.target)
                .WithMany(up => up.InputSubscriptions)
                .HasForeignKey(u => u.targetId);
            
        }

        

        

    }
}