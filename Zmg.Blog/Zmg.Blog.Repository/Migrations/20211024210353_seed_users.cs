using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class seed_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Role",
                keyColumn: "Id",
                keyValue: "0c7f5aec-1391-4ea0-8e7a-5787a1b4d07e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9cb7cfb7-2783-4b74-98ee-d817ee58f94d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "dd9e2ddf-e5f3-408f-bcb5-db6ea09c34ac");

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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5CE205D4-FD33-4889-81FD-974E1D5DAA85", "9f929c82-92ef-4043-a9bf-d697dbeb88ec", "Writer", "WRITER" },
                    { "1F990C39-A60D-4598-A7AC-1B33C5249897", "f090721c-ebdd-4ac2-901e-3a78205bc446", "Editor", "EDITOR" },
                    { "1E6284BA-3365-4F58-9FF7-24ECC21B5095", "70f2b523-b07b-4ca0-a204-98b104be4f37", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1E6284BA-3365-4F58-9FF7-24ECC21B5095", "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5CE205D4-FD33-4889-81FD-974E1D5DAA85", "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1F990C39-A60D-4598-A7AC-1B33C5249897", "8238CBD2-3304-4346-BF20-00F897881458" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1E6284BA-3365-4F58-9FF7-24ECC21B5095", "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1F990C39-A60D-4598-A7AC-1B33C5249897", "8238CBD2-3304-4346-BF20-00F897881458" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5CE205D4-FD33-4889-81FD-974E1D5DAA85", "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85");

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 23, 16, 15, 15, 476, DateTimeKind.Local).AddTicks(3360), new DateTime(2021, 10, 23, 16, 15, 15, 477, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 23, 16, 15, 15, 477, DateTimeKind.Local).AddTicks(1875), new DateTime(2021, 10, 23, 16, 15, 15, 477, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 23, 16, 15, 15, 477, DateTimeKind.Local).AddTicks(1882), new DateTime(2021, 10, 23, 16, 15, 15, 477, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd9e2ddf-e5f3-408f-bcb5-db6ea09c34ac", "de2b7987-1447-44a2-839e-c6a2ef80bf21", "Public", "PUBLIC" },
                    { "0c7f5aec-1391-4ea0-8e7a-5787a1b4d07e", "5cd109fb-c1df-4e3b-a4f4-708afa2c7bc6", "Writer", "WRITER" },
                    { "9cb7cfb7-2783-4b74-98ee-d817ee58f94d", "6e850afd-68db-4cae-86c9-95743c4e4788", "Editor", "EDITOR" }
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
    }
}
