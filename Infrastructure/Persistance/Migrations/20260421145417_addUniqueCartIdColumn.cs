using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addUniqueCartIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueCartId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7501), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7508), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9714), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9718), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9729), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 879, DateTimeKind.Unspecified).AddTicks(9729), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1685), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1695), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1696), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1786), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 21, 14, 54, 16, 880, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueCartId",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5135), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5139), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5147), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(5148), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7834), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7840), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7844), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9906), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9915), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9927), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9928), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9935), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 783, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(60), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(61), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(67), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(81), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 18, 10, 31, 15, 784, DateTimeKind.Unspecified).AddTicks(82), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
