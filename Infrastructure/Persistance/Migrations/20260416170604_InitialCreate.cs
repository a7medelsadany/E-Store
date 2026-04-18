using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    randStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    IsBestSeller = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    ProductStatus = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Description", "IsDeleted", "MetaDescription", "MetaKeywords", "ModifiedDate", "Name", "Slug", "randStatus" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 0, 0, 0, 0)), "Apple Inc.", false, "Apple products", "apple,mac,iphone", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), "Apple", "apple", 0 },
                    { 2L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)), "Samsung Electronics", false, "Samsung products", "samsung,galaxy", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7567), new TimeSpan(0, 0, 0, 0, 0)), "Samsung", "samsung", 0 },
                    { 3L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), "Nike Inc.", false, "Nike products", "nike,shoes,sports", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), "Nike", "nike", 0 },
                    { 4L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7574), new TimeSpan(0, 0, 0, 0, 0)), "Adidas AG", false, "Adidas products", "adidas,shoes,sports", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7575), new TimeSpan(0, 0, 0, 0, 0)), "Adidas", "adidas", 0 },
                    { 5L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 0, 0, 0, 0)), "Sony Corporation", false, "Sony products", "sony,electronics", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 0, 0, 0, 0)), "Sony", "sony", 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryStatus", "CreateDate", "Description", "IsDeleted", "MetaDescription", "MetaKeywords", "ModifiedDate", "Name", "Slug" },
                values: new object[,]
                {
                    { 1L, 0, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)), "Laptop computers", false, "Best laptops", "laptops,computers", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, 0, 0, 0, 0)), "Laptops", "laptops" },
                    { 2L, 0, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 0, 0, 0, 0)), "Mobile phones", false, "Best phones", "phones,mobile", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)), "Phones", "phones" },
                    { 3L, 0, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 0, 0, 0, 0)), "Sports shoes", false, "Best shoes", "shoes,sports", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 0, 0, 0, 0)), "Shoes", "shoes" },
                    { 4L, 0, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 0, 0, 0, 0)), "Televisions", false, "Best TVs", "tv,television,sony", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 49, DateTimeKind.Unspecified).AddTicks(9971), new TimeSpan(0, 0, 0, 0, 0)), "TVs", "tvs" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "ImageUrl", "IsBestSeller", "IsDeleted", "IsFeatured", "MetaDescription", "MetaKeywords", "Model", "ModifiedDate", "Name", "OldPrice", "Price", "ProductStatus", "QuantityInStock", "SKU", "SalePrice", "Slug" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 0, 0, 0, 0)), "Apple MacBook Pro 14 inch", "macbook-pro-14.jpg", true, false, true, "MacBook Pro 14", "apple,macbook,laptop", "MBP14", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 0, 0, 0, 0)), "MacBook Pro 14", 2099.99m, 1999.99m, 0, 50, "APL-MBP-14", 1899.99m, "macbook-pro-14" },
                    { 2L, 1L, 1L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 0, 0, 0, 0)), "Apple MacBook Air M2", "macbook-air-m2.jpg", true, false, false, "MacBook Air M2", "apple,macbook,laptop", "MBAM2", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 0, 0, 0, 0)), "MacBook Air M2", 1399.99m, 1299.99m, 0, 75, "APL-MBA-M2", 1199.99m, "macbook-air-m2" },
                    { 3L, 2L, 1L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1775), new TimeSpan(0, 0, 0, 0, 0)), "Samsung Galaxy Book3 Pro", "galaxy-book3.jpg", false, false, true, "Galaxy Book3", "samsung,laptop", "GB3PRO", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)), "Samsung Galaxy Book3", 1599.99m, 1499.99m, 0, 40, "SAM-GB3-PRO", 1399.99m, "samsung-galaxy-book3" },
                    { 4L, 1L, 2L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, 0, 0, 0, 0)), "Apple iPhone 15 Pro", "iphone-15-pro.jpg", true, false, true, "iPhone 15 Pro", "apple,iphone,phone", "IP15PRO", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, 0, 0, 0, 0)), "iPhone 15 Pro", 1099.99m, 999.99m, 0, 100, "APL-IP15-PRO", 949.99m, "iphone-15-pro" },
                    { 5L, 1L, 2L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1790), new TimeSpan(0, 0, 0, 0, 0)), "Apple iPhone 15", "iphone-15.jpg", true, false, false, "iPhone 15", "apple,iphone,phone", "IP15", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1790), new TimeSpan(0, 0, 0, 0, 0)), "iPhone 15", 899.99m, 799.99m, 0, 120, "APL-IP15", 749.99m, "iphone-15" },
                    { 6L, 2L, 2L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1798), new TimeSpan(0, 0, 0, 0, 0)), "Samsung Galaxy S24 Ultra", "galaxy-s24.jpg", true, false, true, "Galaxy S24", "samsung,galaxy,phone", "GS24ULT", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1799), new TimeSpan(0, 0, 0, 0, 0)), "Samsung Galaxy S24", 1299.99m, 1199.99m, 0, 80, "SAM-GS24-ULT", 1099.99m, "samsung-galaxy-s24" },
                    { 7L, 3L, 3L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1805), new TimeSpan(0, 0, 0, 0, 0)), "Nike Air Max 270", "air-max-270.jpg", true, false, true, "Air Max 270", "nike,shoes,airmax", "AM270", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1806), new TimeSpan(0, 0, 0, 0, 0)), "Nike Air Max 270", 159.99m, 150.00m, 0, 200, "NK-AM-270", 129.99m, "nike-air-max-270" },
                    { 8L, 3L, 3L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 0, 0, 0, 0)), "Nike Revolution 6", "revolution-6.jpg", false, false, false, "Revolution 6", "nike,shoes,running", "REV6", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1812), new TimeSpan(0, 0, 0, 0, 0)), "Nike Revolution 6", 89.99m, 80.00m, 0, 150, "NK-REV-6", 69.99m, "nike-revolution-6" },
                    { 9L, 4L, 3L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1818), new TimeSpan(0, 0, 0, 0, 0)), "Adidas Ultraboost 23", "ultraboost-23.jpg", true, false, true, "Ultraboost 23", "adidas,shoes,ultraboost", "UB23", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1819), new TimeSpan(0, 0, 0, 0, 0)), "Adidas Ultraboost 23", 199.99m, 190.00m, 0, 100, "AD-UB-23", 169.99m, "adidas-ultraboost-23" },
                    { 10L, 5L, 4L, new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, 0, 0, 0, 0)), "Sony BRAVIA XR 55 inch 4K", "bravia-xr-55.jpg", false, false, true, "BRAVIA XR 55", "sony,tv,bravia,4k", "BRV55XR", new DateTimeOffset(new DateTime(2026, 4, 16, 17, 6, 4, 50, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, 0, 0, 0, 0)), "Sony BRAVIA XR 55", 1399.99m, 1299.99m, 0, 30, "SNY-BRV-55", 1199.99m, "sony-bravia-xr-55" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
