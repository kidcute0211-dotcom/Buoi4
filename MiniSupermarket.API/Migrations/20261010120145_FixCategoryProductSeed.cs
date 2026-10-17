using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class FixCategoryProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 7, "Rau hữu cơ", "Sản phẩm chăm sóc cá nhân" },
                    { 8, "Trái cây theo mùa", "Thực phẩm đóng hộp" },
                    { 9, "Nấm tươi", "Nấm tươi" },
                    { 10, "Trái cây nhập khẩu", "Trái cây nhập khẩu các loại" },
                    { 11, "Củ quả", "Củ quả đóng gói" },
                    { 12, "Rau gia vị", "Chất tẩy rửa gia dụng" },
                    { 13, "Các loại đậu", "Các loại đậu cơ bản" },
                    { 14, "Nông sản sơ chế", "Nông sản sơ chế" },
                    { 15, "Combo nông sản", "Các mặt hàng tiêu dùng khác" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 2, 22000m, "Cà rốt Đà Lạt 1kg", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 30000m, "Cà chua hữu cơ 1kg", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Dưa leo sạch 1kg", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 45000m, "Ớt chuông Đà Lạt 500g", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Price", "ProductName" },
                values: new object[] { 3, 32000m, "Nước rửa chén" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 4, 120000m, "Dâu tây tươi 500g", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Price", "ProductName" },
                values: new object[] { 4, 65000m, "Cam sành 1kg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 4, 55000m, "Dầu ăn 1 lít", 30 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 16, "8930000000165", 4, 35000m, "Hành tím 500g", 35 },
                    { 17, "8930000000172", 5, 40000m, "Nấm bào ngư 300g", 30 },
                    { 18, "8930000000189", 5, 60000m, "Nấm đùi gà 300g", 25 },
                    { 19, "8930000000196", 5, 18000m, "Đậu que 500g", 40 },
                    { 20, "8930000000202", 5, 75000m, "Bí đỏ 1kg", 20 },
                    { 21, "8930000000219", 6, 15000m, "Hành lá 200g", 35 },
                    { 22, "8930000000226", 6, 12000m, "Rau mùi 200g", 30 },
                    { 23, "8930000000233", 6, 15000m, "Ngò gai 200g", 25 },
                    { 24, "8930000000240", 6, 14000m, "Gừng tươi 300g", 25 },
                    { 25, "8930000000257", 7, 35000m, "Bắp cải xanh 1kg", 30 },
                    { 26, "8930000000264", 7, 30000m, "Bông cải xanh 500g", 35 },
                    { 27, "8930000000271", 7, 40000m, "Xà lách hữu cơ 500g", 25 },
                    { 28, "8930000000288", 7, 32000m, "Su su tươi 1kg", 25 },
                    { 29, "8930000000295", 8, 25000m, "Thanh long ruột đỏ 1kg", 20 },
                    { 30, "8930000000301", 8, 30000m, "Chuối cau 1kg", 20 },
                    { 31, "8930000000318", 8, 22000m, "Đậu xanh hữu cơ 500g", 25 },
                    { 32, "8930000000325", 8, 25000m, "Đậu đen 500g", 20 },
                    { 33, "8930000000332", 9, 45000m, "Đậu Hà Lan tươi 500g", 30 },
                    { 34, "8930000000349", 9, 28000m, "Đậu cô ve 500g", 35 },
                    { 35, "8930000000356", 9, 30000m, "Đậu bắp tươi 500g", 25 },
                    { 36, "8930000000363", 9, 26000m, "Đậu đũa 500g", 25 },
                    { 37, "8930000000370", 10, 85000m, "Táo xanh nhập khẩu 1kg", 25 },
                    { 38, "8930000000387", 10, 150000m, "Xoài cát Hòa Lộc 1kg Hòa Lộc 1kg", 20 },
                    { 39, "8930000000394", 10, 95000m, "Bơ sáp 1kg", 20 },
                    { 40, "8930000000400", 10, 120000m, "Nho xanh 500g", 15 },
                    { 41, "8930000000417", 11, 45000m, "Xoài cát Hòa Lộc 1kg", 35 },
                    { 42, "8930000000424", 11, 35000m, "Ổi sạch 1kg", 30 },
                    { 43, "8930000000431", 11, 25000m, "Dưa hấu 1kg", 30 },
                    { 44, "8930000000448", 11, 30000m, "Cam vàng 1kg", 40 },
                    { 45, "8930000000455", 12, 35000m, "Cà tím 500g", 25 },
                    { 46, "8930000000462", 12, 40000m, "Bắp ngọt 500g", 20 },
                    { 47, "8930000000479", 12, 30000m, "Củ cải trắng 1kg", 25 },
                    { 48, "8930000000486", 12, 45000m, "Rau củ hỗn hợp 500g", 20 },
                    { 49, "8930000000493", 13, 30000m, "Ớt hiểm 200g", 20 },
                    { 50, "8930000000509", 13, 25000m, "Củ cải đỏ 500g", 25 },
                    { 51, "8930000000516", 13, 28000m, "Khoai lang mật 1kg", 20 },
                    { 52, "8930000000523", 13, 22000m, "Khoai môn 1kg", 20 },
                    { 53, "8930000000530", 14, 25000m, "Lê xanh 1kg", 30 },
                    { 54, "8930000000547", 14, 35000m, "Mãng cầu 1kg", 25 },
                    { 55, "8930000000554", 14, 40000m, "Bơ sáp 500g", 25 },
                    { 56, "8930000000561", 14, 28000m, "Chanh không hạt 500g", 30 },
                    { 57, "8930000000578", 15, 45000m, "Combo rau nấu canh", 20 },
                    { 58, "8930000000585", 15, 50000m, "Combo rau xào", 20 },
                    { 59, "8930000000592", 15, 65000m, "Combo rau lẩu", 15 },
                    { 60, "8930000000608", 15, 55000m, "Combo salad", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 30000m, "Cà chua hữu cơ 1kg", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Dưa leo sạch 1kg", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Ớt chuông Đà Lạt 500g", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 4, 120000m, "Dâu tây tươi 500g", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "Price", "ProductName" },
                values: new object[] { 4, 65000m, "Cam sành 1kg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5, 40000m, "Nấm bào ngư 300g", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Price", "ProductName" },
                values: new object[] { 5, 60000m, "Nấm đùi gà 300g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 6, 15000m, "Hành lá 200g", 35 });
        }
    }
}
