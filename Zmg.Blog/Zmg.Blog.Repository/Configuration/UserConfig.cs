using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zmg.Blog.Repository.Helpers;

namespace Zmg.Blog.Repository.Configuration
{
    internal class UserConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var admin = new IdentityUser
            {
                Id = Constants.ADMIN_ID,
                UserName = "blogadmin",
                NormalizedUserName = "BLOGADMIN",
                Email = "Admin@zemogablog.com",
                NormalizedEmail = "ADMIN@ZEMOGABLOG.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
            };
            admin.PasswordHash = PassGenerate(admin);

            var writer = new IdentityUser
            {
                Id = Constants.WRITER_ID,
                UserName = "blogwriter",
                NormalizedUserName = "BLOGWRITER",
                Email = "writer@zemogablog.com",
                NormalizedEmail = "WRITER@ZEMOGABLOG.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
            };
            writer.PasswordHash = PassGenerate(writer);


            var editor = new IdentityUser
            {
                Id = Constants.EDITOR_ID,
                UserName = "blogeditor",
                NormalizedUserName = "BLOGEDITOR",
                Email = "editor@zemogablog.com",
                NormalizedEmail = "EDITOR@ZEMOGABLOG.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
            };
            editor.PasswordHash = PassGenerate(editor);

            builder.HasData(admin);
            builder.HasData(writer);
            builder.HasData(editor);
        }

        public string PassGenerate(IdentityUser user)
        {
            var passHash = new PasswordHasher<IdentityUser>();
            return passHash.HashPassword(user, "password");
        }

    }
}
