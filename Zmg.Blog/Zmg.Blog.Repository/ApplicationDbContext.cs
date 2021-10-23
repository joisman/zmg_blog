﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.Repository
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.HasDefaultSchema("Identity");
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
                entity.HasData(
                    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Public", NormalizedName = "PUBLIC" },
                    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Writer", NormalizedName = "WRITER" },
                    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Editor", NormalizedName = "EDITOR" }
                    );
            })
                ;
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            builder.Entity<Post>().HasData(
                new Post { id = 1, title = "First post", content = "Test 1", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "jdoe", status = 1 },
                new Post { id = 2, title = "Second post", content = "Test 2", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "jdoe", status = 2 },
                new Post { id = 3, title = "Third post", content = "Test 3", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "jdoe", status = 1 }
                );

            //builder.Entity<PostComment>

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> Comments { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}