﻿// <auto-generated />
using System;
using MB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MB.Data.Migrations
{
    [DbContext(typeof(MbDbContext))]
    [Migration("20181229222100_AddIsDeletedToHotelCommentAndMonumentComment")]
    partial class AddIsDeletedToHotelCommentAndMonumentComment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MB.Models.Hotels.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OblastId");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Stars");

                    b.HasKey("Id");

                    b.HasIndex("OblastId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("HotelId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("HotelComments");
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelCommentLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelCommentId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HotelCommentId");

                    b.HasIndex("UserId");

                    b.ToTable("HotelCommentLikes");
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("HotelId");

                    b.Property<string>("Rating");

                    b.Property<string>("TimeOfYear");

                    b.Property<string>("TravellerType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("HotelReviews");
                });

            modelBuilder.Entity("MB.Models.MbUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MB.Models.Monuments.Monument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OblastId");

                    b.HasKey("Id");

                    b.HasIndex("OblastId");

                    b.ToTable("Monuments");
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MonumentId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MonumentId");

                    b.HasIndex("UserId");

                    b.ToTable("MonumentComments");
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentCommentLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MonumentCommentId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MonumentCommentId");

                    b.HasIndex("UserId");

                    b.ToTable("MonumentCommentLikes");
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("MonumentId");

                    b.Property<string>("Rating");

                    b.Property<string>("TimeOfYear");

                    b.Property<string>("TravellerType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MonumentId");

                    b.HasIndex("UserId");

                    b.ToTable("MonumentReviews");
                });

            modelBuilder.Entity("MB.Models.Oblasts.Oblast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<double>("LandArea");

                    b.Property<int>("MunicipalitiesCount");

                    b.Property<string>("Name");

                    b.Property<int>("Population");

                    b.Property<double>("PopulationDensity");

                    b.HasKey("Id");

                    b.ToTable("Oblasts");
                });

            modelBuilder.Entity("MB.Models.Trips.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("HotelId");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MonumentId");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("MonumentId");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MB.Models.Hotels.Hotel", b =>
                {
                    b.HasOne("MB.Models.Oblasts.Oblast", "Oblast")
                        .WithMany("Hotels")
                        .HasForeignKey("OblastId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelComment", b =>
                {
                    b.HasOne("MB.Models.Hotels.Hotel", "Hotel")
                        .WithMany("HotelComments")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("HotelComments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelCommentLike", b =>
                {
                    b.HasOne("MB.Models.Hotels.HotelComment", "HotelComment")
                        .WithMany("Likes")
                        .HasForeignKey("HotelCommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("HotelCommentLikes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Hotels.HotelReview", b =>
                {
                    b.HasOne("MB.Models.Hotels.Hotel", "Hotel")
                        .WithMany("HotelReviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("HotelReviews")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Monuments.Monument", b =>
                {
                    b.HasOne("MB.Models.Oblasts.Oblast", "Oblast")
                        .WithMany("Monuments")
                        .HasForeignKey("OblastId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentComment", b =>
                {
                    b.HasOne("MB.Models.Monuments.Monument", "Monument")
                        .WithMany("MonumentComments")
                        .HasForeignKey("MonumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("MonumentComments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentCommentLike", b =>
                {
                    b.HasOne("MB.Models.Monuments.MonumentComment", "MonumentComment")
                        .WithMany("Likes")
                        .HasForeignKey("MonumentCommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("MonumentCommentLikes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Monuments.MonumentReview", b =>
                {
                    b.HasOne("MB.Models.Monuments.Monument", "Monument")
                        .WithMany("MonumentReviews")
                        .HasForeignKey("MonumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("MonumentReviews")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MB.Models.Trips.Trip", b =>
                {
                    b.HasOne("MB.Models.Hotels.Hotel", "Hotel")
                        .WithMany("Trips")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MB.Models.Monuments.Monument", "Monument")
                        .WithMany("Trips")
                        .HasForeignKey("MonumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MB.Models.MbUser", "User")
                        .WithMany("Trips")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MB.Models.MbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MB.Models.MbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MB.Models.MbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MB.Models.MbUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
