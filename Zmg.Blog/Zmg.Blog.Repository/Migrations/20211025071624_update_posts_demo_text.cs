using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class update_posts_demo_text : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis nibh nec sapien rutrum fermentum ut sit amet nulla. Vestibulum id dignissim erat, a aliquam purus. Aenean tellus odio, facilisis at ex vitae, pellentesque aliquam enim. Duis eget mi vel turpis molestie dignissim sit amet et tellus. In et erat nunc. Duis tincidunt imperdiet elit in vestibulum.", new DateTime(2021, 10, 25, 2, 16, 23, 820, DateTimeKind.Local).AddTicks(6366), new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "In dolor lacus, pulvinar id blandit nec, aliquet quis ante. Sed ac efficitur lacus, vel finibus felis. Cras condimentum ex quis ante mollis, vel pretium diam ultricies. Integer vel fermentum sem, et venenatis ligula.", new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4141), new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "In hac habitasse platea dictumst. In rhoncus, arcu et euismod maximus, nulla elit consequat dui, vitae bibendum erat quam eu odio. Vivamus sed odio dui. Nulla facilisi. Cras elementum feugiat sem, in pellentesque augue lobortis ut. Duis eleifend, nisl id convallis luctus, ex enim fermentum ex, non vehicula diam risus in ante. Fusce ac facilisis nulla.", new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4147), new DateTime(2021, 10, 25, 2, 16, 23, 821, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1E6284BA-3365-4F58-9FF7-24ECC21B5095",
                column: "ConcurrencyStamp",
                value: "10d486c1-415d-4f30-9923-430d20734bc1");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1F990C39-A60D-4598-A7AC-1B33C5249897",
                column: "ConcurrencyStamp",
                value: "be5d5af1-09de-4bc5-9b9f-8f1b9a5a7346");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5CE205D4-FD33-4889-81FD-974E1D5DAA85",
                column: "ConcurrencyStamp",
                value: "d35fbe02-d85e-43e4-8452-cca349d34fee");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2699ba4-1464-49dd-ba33-19f801144525", "AQAAAAEAACcQAAAAENvMpQjLyUwrrxyVBdeoODPWsxN01BfmOlYdjmcTZ095YuPRY6YdtyHrApJI5N94XQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b014efb-d890-409f-9c7a-f6920d3ce91f", "AQAAAAEAACcQAAAAEHGQPyiKK3N5v32goauXvE9TomXYSFGw8+JvIbT1HK3Rb7rUNPmmgaJTXilao45uMw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d9fdee3-1ee3-49b8-a7d7-50a5353e4b73", "AQAAAAEAACcQAAAAEO3VpzY34ToXxHHz6JKMblS0oF5Nw9lFTyYTSvNNcASXjBwyePFoSOsV08oifNzYTA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "Test 1", new DateTime(2021, 10, 25, 0, 18, 32, 378, DateTimeKind.Local).AddTicks(8653), new DateTime(2021, 10, 25, 0, 18, 32, 379, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "Test 2", new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1342), new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "created_at", "last_modified_at" },
                values: new object[] { "Test 3", new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1353), new DateTime(2021, 10, 25, 0, 18, 32, 380, DateTimeKind.Local).AddTicks(1355) });

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
    }
}
