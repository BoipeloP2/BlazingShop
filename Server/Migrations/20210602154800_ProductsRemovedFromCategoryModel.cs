using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class ProductsRemovedFromCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 323, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 47, 59, 325, DateTimeKind.Local).AddTicks(3629));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 391, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 2, 17, 17, 4, 393, DateTimeKind.Local).AddTicks(4380));
        }
    }
}
