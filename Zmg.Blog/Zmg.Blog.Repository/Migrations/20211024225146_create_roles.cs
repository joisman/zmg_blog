using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class create_roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 17, 51, 45, 977, DateTimeKind.Local).AddTicks(8423), new DateTime(2021, 10, 24, 17, 51, 45, 978, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 17, 51, 45, 978, DateTimeKind.Local).AddTicks(5993), new DateTime(2021, 10, 24, 17, 51, 45, 978, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 17, 51, 45, 978, DateTimeKind.Local).AddTicks(5999), new DateTime(2021, 10, 24, 17, 51, 45, 978, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "656eb43c-872b-4730-b7c6-94c191ed87de");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "a3cc3559-6da3-4004-bae3-85931d477d91");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "bd7d86e0-a60c-48bd-afdf-6ad274b6c661");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D", 0, "da6d9816-bb54-4047-90cf-893d3a5fb72d", "Admin@zemogablog.com", true, null, false, null, "ADMIN@ZEMOGABLOG.COM", "BLOGADMIN", "AQAAAAEAACcQAAAAEM6IrAHFvP8pQ/s63W/UkX3GmgXexuadJIVpcmxCsYsRWbTRHq2/3/++/kJhpOBKVw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogadmin" },
                    { "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1", 0, "4300d70d-9074-45f5-a53e-a7d413a5cb9d", "writer@zemogablog.com", true, null, false, null, "WRITER@ZEMOGABLOG.COM", "BLOGWRITER", "AQAAAAEAACcQAAAAELkW50+/06k1tF3uWduutIiFtTbdTvPCEm6+HCwqR32cAgMBJICk3Ekb8CkcupO3Tw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogwriter" },
                    { "8238CBD2-3304-4346-BF20-00F897881458", 0, "1e5f9c18-ad0a-4e8f-956c-2c92007038ea", "editor@zemogablog.com", true, null, false, null, "EDITOR@ZEMOGABLOG.COM", "BLOGEDITOR", "AQAAAAEAACcQAAAAEMWThALWDUeX5RiSB0yICi9cyjEKuNkWgubdoYFrlNUABqnJ0k4nkISppyrskew3Wg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogeditor" }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_User_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_User_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_User_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_User_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_User_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_User_UserId",
                table: "UserTokens");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "User");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D", 0, "f3980879-e0c2-4a50-9cb7-3ae1e5100947", "Admin@zemogablog.com", true, null, false, null, "ADMIN@ZEMOGABLOG.COM", "BLOGADMIN", "AQAAAAEAACcQAAAAEBU8Qh1/EQoz6xqhb838EDWcdJiydK5e/Be0OUn0uL6INXmPthfADRgnpL19uPxsiw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogadmin" },
                    { "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1", 0, "04a3fa0c-f4f8-4324-9404-22ea908efe46", "writer@zemogablog.com", true, null, false, null, "WRITER@ZEMOGABLOG.COM", "BLOGWRITER", "AQAAAAEAACcQAAAAECc6s53nxR+0jnUw/EAUrTvdzg/4q9Z7ejeGS/QK7RYqYbquJ1AFl42bOcRAbkuOfA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogwriter" },
                    { "8238CBD2-3304-4346-BF20-00F897881458", 0, "28459f90-f71a-4f5c-9f97-c1c2c6d3a12c", "editor@zemogablog.com", true, null, false, null, "EDITOR@ZEMOGABLOG.COM", "BLOGEDITOR", "AQAAAAEAACcQAAAAEFP7O7ot8CgnAP97LsBoFWDWlVcnNAUM8tXgWIniOyXHTSRq3Fqvme70BJrK5DLT8A==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "blogeditor" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(1136), new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(9704), new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(9710), new DateTime(2021, 10, 24, 16, 3, 53, 261, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "70f2b523-b07b-4ca0-a204-98b104be4f37");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "f090721c-ebdd-4ac2-901e-3a78205bc446");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "9f929c82-92ef-4043-a9bf-d697dbeb88ec");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
