using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class added_rejected_comments_to_posts_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "reject_comments",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(2039), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9205), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9212), new DateTime(2021, 10, 24, 20, 20, 34, 208, DateTimeKind.Local).AddTicks(9212) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reject_comments",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 13, 19, 473, DateTimeKind.Local).AddTicks(9195), new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9448), new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified_at" },
                values: new object[] { new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9458), new DateTime(2021, 10, 24, 18, 13, 19, 474, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "ebbac7bf-130f-4052-af1f-a1c510220e1a");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "0a3db40e-eb8a-42ad-b796-980aed76150d");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "168d4f10-5fce-4418-b72f-5e24f6ad5774");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db11abc9-58f4-4b67-884d-3025450a7627", "AQAAAAEAACcQAAAAEJHkTsEE+UUho+lTYCO3Ab1SInZFELLA3BdLnRjcxbnGGfqeO81wCutnfJfx00zCJg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c22f4b3a-1737-4751-98ad-bb1fab38972e", "AQAAAAEAACcQAAAAEF7XsRlhgZ7ajX2hIu0xa9bDqqdPbxwWgGOqylaztjRxErfw02F1/72BM3bJ4zEEjg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9dd0af6-b0d1-4890-9431-31c3a7ec088a", "AQAAAAEAACcQAAAAEDxwMjMmnHbi4KGJsnp6Hm1LyK+g6UpENdd7QX6f1N26FGQu5Bu88h69CQKBlaNsNg==" });
        }
    }
}
