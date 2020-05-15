﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200515125058_wtf_2")]
    partial class wtf_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApp.Models.Friend", b =>
                {
                    b.Property<int>("PersonInputRequestId")
                        .HasColumnType("integer");

                    b.Property<int>("PersonOutputRequestId")
                        .HasColumnType("integer");

                    b.HasKey("PersonInputRequestId", "PersonOutputRequestId");

                    b.HasIndex("PersonOutputRequestId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("WebApp.Models.LikePost", b =>
                {
                    b.Property<int>("RatingPersonId")
                        .HasColumnType("integer");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.HasKey("RatingPersonId", "PostId");

                    b.ToTable("LikesPosts");
                });

            modelBuilder.Entity("WebApp.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Owner")
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Time")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PostModel");
                });

            modelBuilder.Entity("WebApp.Models.Subscriber", b =>
                {
                    b.Property<int>("senderId")
                        .HasColumnType("integer");

                    b.Property<int>("targetId")
                        .HasColumnType("integer");

                    b.HasKey("senderId", "targetId");

                    b.HasIndex("targetId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("WebApp.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<List<int>>("Posts")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("WebApp.Models.Friend", b =>
                {
                    b.HasOne("WebApp.Models.UserModel", "PersonOutputRequest")
                        .WithMany("Friends1")
                        .HasForeignKey("PersonInputRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.UserModel", "PersonInputRequest")
                        .WithMany("Friends2")
                        .HasForeignKey("PersonOutputRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.LikePost", b =>
                {
                    b.HasOne("WebApp.Models.PostModel", "PostModel")
                        .WithMany("LikesPost")
                        .HasForeignKey("RatingPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.UserModel", "RatingPerson")
                        .WithMany("LikesPosts")
                        .HasForeignKey("RatingPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Subscriber", b =>
                {
                    b.HasOne("WebApp.Models.UserModel", "sender")
                        .WithMany("OutputSubscribtions")
                        .HasForeignKey("senderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.UserModel", "target")
                        .WithMany("InputSubscriptions")
                        .HasForeignKey("targetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
