using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zmg.Blog.Repository.Migrations
{
    public partial class add_comment_collection_to_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Postid",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments",
                column: "Postid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Postid",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "27FF60CB-AE2D-45E5-ACBB-1B7094D73B2D",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da6d9816-bb54-4047-90cf-893d3a5fb72d", "AQAAAAEAACcQAAAAEM6IrAHFvP8pQ/s63W/UkX3GmgXexuadJIVpcmxCsYsRWbTRHq2/3/++/kJhpOBKVw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8238CBD2-3304-4346-BF20-00F897881458",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e5f9c18-ad0a-4e8f-956c-2c92007038ea", "AQAAAAEAACcQAAAAEMWThALWDUeX5RiSB0yICi9cyjEKuNkWgubdoYFrlNUABqnJ0k4nkISppyrskew3Wg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "C5D0CB6E-7575-4C82-A42C-9EBBC41220D1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4300d70d-9074-45f5-a53e-a7d413a5cb9d", "AQAAAAEAACcQAAAAELkW50+/06k1tF3uWduutIiFtTbdTvPCEm6+HCwqR32cAgMBJICk3Ekb8CkcupO3Tw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments",
                column: "Postid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
