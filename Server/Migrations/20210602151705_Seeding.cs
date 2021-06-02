using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Url", "name" },
                values: new object[] { 1, "book", "books", "Books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Url", "name" },
                values: new object[] { 2, "camera-slr", "electronics", "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Url", "name" },
                values: new object[] { 3, "aperture", "video-games", "Video games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 2, 17, 17, 4, 391, DateTimeKind.Local).AddTicks(8458), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The hitchhiker's guide to the galaxy", "https://en.wikipedia.org/wiki/File:H2G2_UK_front_cover.jpg#/media/File:H2G2_UK_front_cover.jpg", false, false, 19.99m, 9.99m, "The hitchhiker" },
                    { 4, 1, new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALF=LIFE the best game", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp", false, false, 19.99m, 9.99m, "The Half-life4" },
                    { 2, 2, new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALF=LIFE the best game", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp", false, false, 19.99m, 9.99m, "The Half-life2" },
                    { 5, 2, new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALF=LIFE the best game", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp", false, false, 19.99m, 9.99m, "The Half-life5" },
                    { 3, 3, new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALF=LIFE the best game", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp", false, false, 19.99m, 9.99m, "The Half-life3" },
                    { 6, 3, new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HALF=LIFE the best game", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-life_2_cover.jgp", false, false, 19.99m, 9.99m, "The Half-life6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
