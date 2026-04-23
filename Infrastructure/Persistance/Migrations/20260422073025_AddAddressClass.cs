using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2961), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4804), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4807), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4811), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(4812), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6117), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6125), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6203), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6204), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6209), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6209), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6213), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6218), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6219), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6228), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 4, 22, 7, 30, 24, 123, DateTimeKind.Unspecified).AddTicks(6228), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

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
    }
}
