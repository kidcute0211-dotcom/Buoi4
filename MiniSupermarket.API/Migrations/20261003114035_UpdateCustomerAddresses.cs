using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Address",
                value: "12 Nguyễn Văn Cừ, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Address",
                value: "25 Phan Đình Phùng, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Address",
                value: "38 Thống Nhất, Thủ Đức, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "Address",
                value: "46 Hai Bà Trưng, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "Address",
                value: "19 Trần Phú, Gò Vấp, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                column: "Address",
                value: "57 Bùi Thị Xuân, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                column: "Address",
                value: "23 Lang Biang, Bình Thạnh, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                column: "Address",
                value: "68 Xô Viết Nghệ Tĩnh, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                column: "Address",
                value: "31 Lê Lợi, Quận 12, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                column: "Address",
                value: "42 Trần Hưng Đạo, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                column: "Address",
                value: "15 Nguyễn Công Trứ, Gò Vấp, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                column: "Address",
                value: "72 Hoàng Diệu, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                column: "Address",
                value: "29 Quốc lộ 20, Thủ Đức, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                column: "Address",
                value: "36 Pasteur, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                column: "Address",
                value: "54 đường 19/5, Bình Thạnh, TP. Hồ Chí Minh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Address",
                value: "Thủ Đức, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "Address",
                value: "Gò Vấp, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                column: "Address",
                value: "Bình Thạnh, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                column: "Address",
                value: "Quận 12, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11,
                column: "Address",
                value: "Gò Vấp, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13,
                column: "Address",
                value: "Thủ Đức, TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14,
                column: "Address",
                value: "TP. Hồ Chí Minh");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15,
                column: "Address",
                value: "Bình Thạnh, TP. Hồ Chí Minh");
        }
    }
}
