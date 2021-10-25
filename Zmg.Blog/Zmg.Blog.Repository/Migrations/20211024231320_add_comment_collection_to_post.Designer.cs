﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zmg.Blog.Repository;

namespace Zmg.Blog.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211024231320_add_comment_collection_to_post")]
    partial class add_comment_collection_to_post
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                            RoleId = "1E6284BA-3365-4F58-9FF7-24ECC21B5095"
                        },
                        new
                        {
                            UserId = "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                            RoleId = "5CE205D4-FD33-4889-81FD-974E1D5DAA85"
                        },
                        new
                        {
                            UserId = "8238CBD2-3304-4346-BF20-00F897881458",
                            RoleId = "1F990C39-A60D-4598-A7AC-1B33C5249897"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("last_modified_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            content = "Test 1",
                            created_at = new DateTime(2021, 10, 24, 18, 13, 19, 473, DateTimeKind.Local).AddTicks(9195),
                            last_modified_at = new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(8121),
                            status = 1,
                            title = "First post",
                            username = "jdoe"
                        },
                        new
                        {
                            id = 2,
                            content = "Test 2",
                            created_at = new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9448),
                            last_modified_at = new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9455),
                            status = 2,
                            title = "Second post",
                            username = "jdoe"
                        },
                        new
                        {
                            id = 3,
                            content = "Test 3",
                            created_at = new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9458),
                            last_modified_at = new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9460),
                            status = 1,
                            title = "Third post",
                            username = "jdoe"
                        });
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.PostComment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Postid")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("last_modified_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Postid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                            ConcurrencyStamp = "168d4f10-5fce-4418-b72f-5e24f6ad5774",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        },
                        new
                        {
                            Id = "1F990C39-A60D-4598-A7AC-1B33C5249897",
                            ConcurrencyStamp = "0a3db40e-eb8a-42ad-b796-980aed76150d",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                            ConcurrencyStamp = "ebbac7bf-130f-4052-af1f-a1c510220e1a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db11abc9-58f4-4b67-884d-3025450a7627",
                            Email = "Admin@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJHkTsEE+UUho+lTYCO3Ab1SInZFELLA3BdLnRjcxbnGGfqeO81wCutnfJfx00zCJg==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "blogadmin"
                        },
                        new
                        {
                            Id = "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b9dd0af6-b0d1-4890-9431-31c3a7ec088a",
                            Email = "writer@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "WRITER@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGWRITER",
                            PasswordHash = "AQAAAAEAACcQAAAAEDxwMjMmnHbi4KGJsnp6Hm1LyK+g6UpENdd7QX6f1N26FGQu5Bu88h69CQKBlaNsNg==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "blogwriter"
                        },
                        new
                        {
                            Id = "8238CBD2-3304-4346-BF20-00F897881458",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c22f4b3a-1737-4751-98ad-bb1fab38972e",
                            Email = "editor@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGEDITOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEF7XsRlhgZ7ajX2hIu0xa9bDqqdPbxwWgGOqylaztjRxErfw02F1/72BM3bJ4zEEjg==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "blogeditor"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zmg.Blog.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.PostComment", b =>
                {
                    b.HasOne("Zmg.Blog.Domain.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("Postid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Zmg.Blog.Domain.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
