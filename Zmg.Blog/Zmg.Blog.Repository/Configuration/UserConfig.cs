using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zmg.Blog.Repository.Helpers;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.Repository.Configuration
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admin = new User
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

            var writer = new User
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


            var editor = new User
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

        public string PassGenerate(User user)
        {
            var passHash = new PasswordHasher<User>();
            return passHash.HashPassword(user, "password");
        }

    }
}
