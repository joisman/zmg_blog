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
    [Migration("20211025071624_update_posts_demo_text")]
    partial class update_posts_demo_text
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<string>("reject_comments")
                        .HasColumnType("nvarchar(max)");

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
                            content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis nibh nec sapien rutrum fermentum ut sit amet nulla. Vestibulum id dignissim erat, a aliquam purus. Aenean tellus odio, facilisis at ex vitae, pellentesque aliquam enim. Duis eget mi vel turpis molestie dignissim sit amet et tellus. In et erat nunc. Duis tincidunt imperdiet elit in vestibulum.",
                            created_at = new DateTime(2021, 10, 25, 2, 16, 23, 820, DateTimeKind.Local).AddTicks(6366),
                            last_modified_at = new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(3447),
                            status = 1,
                            title = "First post",
                            username = "blogwriter"
                        },
                        new
                        {
                            id = 2,
                            content = "In dolor lacus, pulvinar id blandit nec, aliquet quis ante. Sed ac efficitur lacus, vel finibus felis. Cras condimentum ex quis ante mollis, vel pretium diam ultricies. Integer vel fermentum sem, et venenatis ligula.",
                            created_at = new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4141),
                            last_modified_at = new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4145),
                            status = 2,
                            title = "Second post",
                            username = "blogwriter"
                        },
                        new
                        {
                            id = 3,
                            content = "In hac habitasse platea dictumst. In rhoncus, arcu et euismod maximus, nulla elit consequat dui, vitae bibendum erat quam eu odio. Vivamus sed odio dui. Nulla facilisi. Cras elementum feugiat sem, in pellentesque augue lobortis ut. Duis eleifend, nisl id convallis luctus, ex enim fermentum ex, non vehicula diam risus in ante. Fusce ac facilisis nulla.",
                            created_at = new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4147),
                            last_modified_at = new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4148),
                            status = 1,
                            title = "Third post",
                            username = "blogwriter"
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
                            ConcurrencyStamp = "d35fbe02-d85e-43e4-8452-cca349d34fee",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        },
                        new
                        {
                            Id = "1F990C39-A60D-4598-A7AC-1B33C5249897",
                            ConcurrencyStamp = "be5d5af1-09de-4bc5-9b9f-8f1b9a5a7346",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                            ConcurrencyStamp = "10d486c1-415d-4f30-9923-430d20734bc1",
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
                            ConcurrencyStamp = "d2699ba4-1464-49dd-ba33-19f801144525",
                            Email = "Admin@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENvMpQjLyUwrrxyVBdeoODPWsxN01BfmOlYdjmcTZ095YuPRY6YdtyHrApJI5N94XQ==",
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
                            ConcurrencyStamp = "2d9fdee3-1ee3-49b8-a7d7-50a5353e4b73",
                            Email = "writer@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "WRITER@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGWRITER",
                            PasswordHash = "AQAAAAEAACcQAAAAEO3VpzY34ToXxHHz6JKMblS0oF5Nw9lFTyYTSvNNcASXjBwyePFoSOsV08oifNzYTA==",
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
                            ConcurrencyStamp = "5b014efb-d890-409f-9c7a-f6920d3ce91f",
                            Email = "editor@zemogablog.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@ZEMOGABLOG.COM",
                            NormalizedUserName = "BLOGEDITOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEHGQPyiKK3N5v32goauXvE9TomXYSFGw8+JvIbT1HK3Rb7rUNPmmgaJTXilao45uMw==",
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
