using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Repository.Helpers;

namespace Zmg.Blog.Repository.Configuration
{
    internal class UserWithRolesConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
       
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            IdentityUserRole<string> adminUser = new IdentityUserRole<string>
            {
                RoleId = Constants.ADMIN_ROLE_ID,
                UserId = Constants.ADMIN_ID
            };

            IdentityUserRole<string> writerUser = new IdentityUserRole<string>
            {
                RoleId = Constants.WRITER_ROLE_ID,
                UserId = Constants.WRITER_ID
            };

            IdentityUserRole<string> editorUser = new IdentityUserRole<string>
            {
                RoleId = Constants.EDITOR_ROLE_ID,
                UserId = Constants.EDITOR_ID
            };

            builder.HasData(adminUser);
            builder.HasData(writerUser);
            builder.HasData(editorUser);
        }
    }
}
