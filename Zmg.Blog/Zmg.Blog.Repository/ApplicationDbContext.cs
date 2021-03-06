using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.Configuration;
using Zmg.Blog.Repository.Helpers;

namespace Zmg.Blog.Repository
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.HasDefaultSchema("Identity");
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<Role>(entity =>
            {
                entity.ToTable(name: "Role");
                entity.HasData(
                    //new IdentityRole { Id =Constants.PUBLIC_ROLE_ID, Name = "Public", NormalizedName = "PUBLIC" },
                    new IdentityRole { Id = Constants.WRITER_ROLE_ID, Name = "Writer", NormalizedName = "WRITER" },
                    new IdentityRole { Id = Constants.EDITOR_ROLE_ID, Name = "Editor", NormalizedName = "EDITOR" },
                    new IdentityRole { Id = Constants.ADMIN_ROLE_ID, Name = "Admin", NormalizedName = "ADMIN" }
                    );
            });


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
                new Post { id = 1, title = "First post", content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis nibh nec sapien rutrum fermentum ut sit amet nulla. Vestibulum id dignissim erat, a aliquam purus. Aenean tellus odio, facilisis at ex vitae, pellentesque aliquam enim. Duis eget mi vel turpis molestie dignissim sit amet et tellus. In et erat nunc. Duis tincidunt imperdiet elit in vestibulum.", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "blogwriter", status = 1 },
                new Post { id = 2, title = "Second post", content = "In dolor lacus, pulvinar id blandit nec, aliquet quis ante. Sed ac efficitur lacus, vel finibus felis. Cras condimentum ex quis ante mollis, vel pretium diam ultricies. Integer vel fermentum sem, et venenatis ligula.", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "blogwriter", status = 2 },
                new Post { id = 3, title = "Third post", content = "In hac habitasse platea dictumst. In rhoncus, arcu et euismod maximus, nulla elit consequat dui, vitae bibendum erat quam eu odio. Vivamus sed odio dui. Nulla facilisi. Cras elementum feugiat sem, in pellentesque augue lobortis ut. Duis eleifend, nisl id convallis luctus, ex enim fermentum ex, non vehicula diam risus in ante. Fusce ac facilisis nulla.", created_at = DateTime.Now, last_modified_at = DateTime.Now, username = "blogwriter", status = 1 }
                );

            // Seed users and roles.
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new UserWithRolesConfig());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> Comments { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
