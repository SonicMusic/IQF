﻿// <auto-generated />
using System;
using IQF.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IQF.DataAccess.Migrations
{
    [DbContext(typeof(IqfDbContext))]
    partial class IqfDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GamesTeams", b =>
                {
                    b.Property<Guid>("GamesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeamsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("GamesTeams");
                });

            modelBuilder.Entity("IQF.Core.Models.Events", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("IQF.Core.Models.Games", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartMatch")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("IQF.Core.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Image");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("IQF.Core.Models.Profiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("IQF.Core.Models.RoomProfiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<Guid>("ProfilesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfilesId");

                    b.HasIndex("RoomsId");

                    b.ToTable("RoomProfiles");
                });

            modelBuilder.Entity("IQF.Core.Models.Rooms", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("IQF.Core.Models.Teams", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("GoalsInTheMatch")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("IQF.Core.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProfilesRooms", b =>
                {
                    b.Property<Guid>("ProfilesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfilesId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("ProfilesRooms");
                });

            modelBuilder.Entity("IQF.Core.Models.Avatar", b =>
                {
                    b.HasBaseType("IQF.Core.Models.Image");

                    b.Property<Guid>("ProfilesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("ProfilesId")
                        .IsUnique()
                        .HasFilter("[ProfilesId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Avatar");
                });

            modelBuilder.Entity("IQF.Core.Models.Logo", b =>
                {
                    b.HasBaseType("IQF.Core.Models.Image");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("TeamId")
                        .IsUnique()
                        .HasFilter("[TeamId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Logo");
                });

            modelBuilder.Entity("GamesTeams", b =>
                {
                    b.HasOne("IQF.Core.Models.Games", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IQF.Core.Models.Teams", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IQF.Core.Models.Events", b =>
                {
                    b.HasOne("IQF.Core.Models.Rooms", "Room")
                        .WithMany("Events")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("IQF.Core.Models.Games", b =>
                {
                    b.HasOne("IQF.Core.Models.Events", "Event")
                        .WithMany("Games")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("IQF.Core.Models.Profiles", b =>
                {
                    b.HasOne("IQF.Core.Models.Users", "User")
                        .WithOne("Profile")
                        .HasForeignKey("IQF.Core.Models.Profiles", "UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IQF.Core.Models.RoomProfiles", b =>
                {
                    b.HasOne("IQF.Core.Models.Profiles", "Profile")
                        .WithMany("RoomProfiles")
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IQF.Core.Models.Rooms", "Room")
                        .WithMany("RoomProfiles")
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ProfilesRooms", b =>
                {
                    b.HasOne("IQF.Core.Models.Profiles", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IQF.Core.Models.Rooms", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IQF.Core.Models.Avatar", b =>
                {
                    b.HasOne("IQF.Core.Models.Profiles", "Profile")
                        .WithOne("Avatar")
                        .HasForeignKey("IQF.Core.Models.Avatar", "ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("IQF.Core.Models.Logo", b =>
                {
                    b.HasOne("IQF.Core.Models.Teams", "Team")
                        .WithOne("Logo")
                        .HasForeignKey("IQF.Core.Models.Logo", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("IQF.Core.Models.Events", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("IQF.Core.Models.Profiles", b =>
                {
                    b.Navigation("Avatar");

                    b.Navigation("RoomProfiles");
                });

            modelBuilder.Entity("IQF.Core.Models.Rooms", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("RoomProfiles");
                });

            modelBuilder.Entity("IQF.Core.Models.Teams", b =>
                {
                    b.Navigation("Logo");
                });

            modelBuilder.Entity("IQF.Core.Models.Users", b =>
                {
                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}