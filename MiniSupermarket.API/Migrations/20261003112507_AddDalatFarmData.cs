using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDalatFarmData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RewardPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipRank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau ăn lá", "Rau ăn lá tươi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau củ", "Các loại củ tươi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Củ quả", "Cà chua, dưa leo và ớt chuông" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau gia vị", "Trái cây sạch theo mùa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nông sản sơ chế", "Nông sản sơ chế và bảo quản đúng cách" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 6, "Nông sản hữu cơ", "Rau gia vị tươi sạch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 1, "TP. Hồ Chí Minh", "Nguyễn Văn An", "Vàng", "0901000001", 150 },
                    { 2, "TP. Hồ Chí Minh", "Trần Thị Bình", "Bạc", "0901000002", 50 },
                    { 3, "Thủ Đức, TP. Hồ Chí Minh", "Lê Hoàng Nam", "Chuẩn", "0901000003", 10 },
                    { 4, "TP. Hồ Chí Minh", "Phạm Thị Lan", "Vàng", "0901000004", 220 },
                    { 5, "Gò Vấp, TP. Hồ Chí Minh", "Hoàng Minh Khang", "Chuẩn", "0901000005", 30 },
                    { 6, "TP. Hồ Chí Minh", "Võ Ngọc Hà", "Bạc", "0901000006", 85 },
                    { 7, "Bình Thạnh, TP. Hồ Chí Minh", "Đặng Quốc Bảo", "Chuẩn", "0901000007", 15 },
                    { 8, "TP. Hồ Chí Minh", "Bùi Thị Mai", "Vàng", "0901000008", 310 },
                    { 9, "Quận 12, TP. Hồ Chí Minh", "Đỗ Thành Đạt", "Chuẩn", "0901000009", 40 },
                    { 10, "TP. Hồ Chí Minh", "Ngô Thị Hương", "Bạc", "0901000010", 65 },
                    { 11, "Gò Vấp, TP. Hồ Chí Minh", "Dương Minh Đức", "Chuẩn", "0901000011", 20 },
                    { 12, "TP. Hồ Chí Minh", "Phan Ngọc Trâm", "Vàng", "0901000012", 180 },
                    { 13, "Thủ Đức, TP. Hồ Chí Minh", "Lý Tuấn Kiệt", "Bạc", "0901000013", 55 },
                    { 14, "TP. Hồ Chí Minh", "Mai Thị Thảo", "Chuẩn", "0901000014", 5 },
                    { 15, "Bình Thạnh, TP. Hồ Chí Minh", "Cao Gia Huy", "Bạc", "0901000015", 100 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "8930000000011", 1, 25000m, "Xà lách xanh 500g", 50 },
                    { 2, "8930000000028", 1, 30000m, "Cải ngọt 500g", 40 },
                    { 3, "8930000000035", 1, 22000m, "Cải bó xôi 500g", 35 },
                    { 4, "8930000000042", 1, 18000m, "Gạo lứt hữu cơ 1kg", 45 },
                    { 5, "8930000000059", 2, 20000m, "Cà rốt Đà Lạt 1kg", 60 },
                    { 6, "8930000000066", 2, 25000m, "Khoai tây sạch 1kg", 55 },
                    { 7, "8930000000073", 2, 28000m, "Củ dền tươi 500g", 25 },
                    { 8, "8930000000080", 3, 30000m, "Cà chua hữu cơ 1kg", 50 },
                    { 9, "8930000000097", 3, 18000m, "Dưa leo sạch 1kg", 45 },
                    { 10, "8930000000103", 3, 45000m, "Ớt chuông Đà Lạt 500g", 30 },
                    { 11, "8930000000110", 4, 120000m, "Dâu tây tươi 500g", 20 },
                    { 12, "8930000000127", 4, 65000m, "Cam sành 1kg", 25 },
                    { 13, "8930000000134", 5, 40000m, "Nấm bào ngư 300g", 30 },
                    { 14, "8930000000141", 5, 60000m, "Nấm đùi gà 300g", 25 },
                    { 15, "8930000000158", 6, 15000m, "Hành lá 200g", 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau ăn lá", "Snack, bánh quy, kẹo dẻo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau củ", "Nước ngọt, nước khoáng, trà" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Trái cây tươi", "Sữa tươi, sữa chua, phô mai" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nấm tươi", "Mì ăn liền, phở khô, cháo gói" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau gia vị", "Nước mắm, hạt nêm, dầu thực vật" });
        }
    }
}
