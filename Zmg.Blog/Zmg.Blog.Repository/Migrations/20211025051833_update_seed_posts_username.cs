using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class update_seed_posts_username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 25, 0, 18, 32, 378, DateTimeKind.Local).AddTicks(8653), new DateTime(2021, 10, 25, 0, 18, 32, 379, DateTimeKind.Local).AddTicks(9988), "blogwriter" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1342), new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1350), "blogwriter" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1353), new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1355), "blogwriter" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "12b9ed25-4b93-4118-91fa-90e9fb5d1995");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "d727e60a-91c1-4423-aac7-1b21ca15519f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "8fc2bef2-b131-4a35-a409-3bc5a5ccf0b0");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca30006e-a7df-4c2a-b2ca-330b276f07c9", "AQAAAAEAACcQAAAAEMWdBf8OeEMErfbySWJnHKBcn1lwaTS6zTGScEtWmqANZDICKLULWWlEBeSVQbHDUA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3871170f-6d6c-4435-8a8a-086d5193adb7", "AQAAAAEAACcQAAAAEGrD/mR1c3ZWjRpjnbHoDEB9DyQHAd7Ez8EoTi1qCk0NuTNSz/qSmvtgWpzcchHP3w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2e718ec-cb46-4062-88ae-fda5d9488f80", "AQAAAAEAACcQAAAAEOXSOCGHNCXfbGlmlM8i99z34IM+THPSRHTf3JYKUSwHPRJhDdYVcou0dxPormcFbw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(2039), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(8458), "jdoe" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9205), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9210), "jdoe" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at", "username" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9212), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9212), "jdoe" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "9469fa6d-6f50-4aae-b5fb-8c0d2d1985ca");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "5077c4fb-3d3c-4c38-b786-4a512170a56f");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "74ec5aa7-e69f-4f09-98d9-03e3d0ca4444");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8a0e975-539d-4049-9a18-3d7cb5de7725", "AQAAAAEAACcQAAAAEA9Pz0Duk7Smf4IVcyTH+S9bY6+zIwuhvF52/byY3Jy24kELurGTOScpofnyiy1neQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65c19bd1-0d70-4e08-bac6-0026d10a3ca8", "AQAAAAEAACcQAAAAEL0kzsGioXOBnMnGwyqj102CJ5krsQvCoLe1c3nMQKwvdbxlhvgQGLE5qHRXdZGfdA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27f61c73-3994-46f7-89b1-fafb322ca3db", "AQAAAAEAACcQAAAAELv8ZHObCWj5s4HQSXUffYlV3pAUbIpTh3bjRaxFGr3OLND1fs+YC8vh5Y6zBho5Dw==" });
        }
    }
}
