
using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(
            DbContextOptions<SupermarketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // 1. DANH MỤC RAU SẠCH 
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Đồ uống", Description = "Nước uống đóng chai" },
                new Category { CategoryId = 2, CategoryName = "Thực phẩm khô", Description = "Thực phẩm khô dùng hằng ngày" },
                new Category { CategoryId = 3, CategoryName = "Bánh kẹo", Description = "Đồ ăn vặt và bánh kẹo" },
                new Category { CategoryId = 4, CategoryName = "Gia vị", Description = "Sữa và sản phẩm từ sữa" },
                new Category { CategoryId = 5, CategoryName = "Đồ đông lạnh", Description = "Thực phẩm đông lạnh" },
                new Category { CategoryId = 6, CategoryName = "Đồ gia dụng", Description = "Gia vị nấu ăn" }
            );

            // 2. 15 SẢN PHẨM
            // Giá bán tính bằng VNĐ; CategoryId phải tồn tại trong Categories.
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Barcode = "8930000000011", ProductName = "Nước suối 500ml", Price = 25000, StockQuantity = 50, CategoryId = 1 },
                new Product { ProductId = 2, Barcode = "8930000000028", ProductName = "Sữa chua có đường", Price = 30000, StockQuantity = 40, CategoryId = 1 },
                new Product { ProductId = 3, Barcode = "8930000000035", ProductName = "Mì ly ăn liền", Price = 22000, StockQuantity = 35, CategoryId = 1 },
                new Product { ProductId = 4, Barcode = "8930000000042", ProductName = "Gạo thơm 5kg", Price = 18000, StockQuantity = 45, CategoryId = 1 },
                new Product { ProductId = 5, Barcode = "8930000000059", ProductName = "Mì gói Hảo Hảo", Price = 20000, StockQuantity = 60, CategoryId = 2 },
                new Product { ProductId = 6, Barcode = "8930000000066", ProductName = "Bánh snack khoai tây", Price = 25000, StockQuantity = 55, CategoryId = 2 },
                new Product { ProductId = 7, Barcode = "8930000000073", ProductName = "Cà phê hòa tan", Price = 28000, StockQuantity = 25, CategoryId = 2 },
                new Product { ProductId = 8, Barcode = "8930000000080", ProductName = "Trứng gà hộp 10 quả", Price = 30000, StockQuantity = 50, CategoryId = 3 },
                new Product { ProductId = 9, Barcode = "8930000000097", ProductName = "Nước suối 1.5 lít", Price = 18000, StockQuantity = 45, CategoryId = 3 },
                new Product { ProductId = 10, Barcode = "8930000000103", ProductName = "Nước ngọt Coca-Cola", Price = 45000, StockQuantity = 30, CategoryId = 3 },
                new Product { ProductId = 11, Barcode = "8930000000110", ProductName = "Sữa tươi Vinamilk", Price = 120000, StockQuantity = 20, CategoryId = 4 },
                new Product { ProductId = 12, Barcode = "8930000000127", ProductName = "Bánh quy bơ", Price = 65000, StockQuantity = 25, CategoryId = 4 },
                new Product { ProductId = 13, Barcode = "8930000000134", ProductName = "Cá hộp sốt cà", Price = 40000, StockQuantity = 30, CategoryId = 5 },
                new Product { ProductId = 14, Barcode = "8930000000141", ProductName = "Rong biển ăn liền", Price = 60000, StockQuantity = 25, CategoryId = 5 },
                new Product { ProductId = 15, Barcode = "8930000000158", ProductName = "Nước mắm 500ml", Price = 15000, StockQuantity = 35, CategoryId = 6 }
            );


            // 3. 15 KHÁCH HÀNG
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Nguyễn Văn An", PhoneNumber = "0901000001", Address = "12 Nguyễn Văn Cừ, TP. Hồ Chí Minh", RewardPoints = 150, MembershipRank = "Vàng" },
                new Customer { CustomerId = 2, CustomerName = "Trần Thị Bình", PhoneNumber = "0901000002", Address = "25 Phan Đình Phùng, TP. Hồ Chí Minh", RewardPoints = 50, MembershipRank = "Bạc" },
                new Customer { CustomerId = 3, CustomerName = "Lê Hoàng Nam", PhoneNumber = "0901000003", Address = "38 Thống Nhất, Đức Trọng, Lâm Đồng", RewardPoints = 10, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 4, CustomerName = "Phạm Thị Lan", PhoneNumber = "0901000004", Address = "46 Hai Bà Trưng, TP. Hồ Chí Minh", RewardPoints = 220, MembershipRank = "Vàng" },
                new Customer { CustomerId = 5, CustomerName = "Hoàng Minh Khang", PhoneNumber = "0901000005", Address = "19 Trần Phú, Bảo Lộc, Lâm Đồng", RewardPoints = 30, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 6, CustomerName = "Võ Ngọc Hà", PhoneNumber = "0901000006", Address = "57 Bùi Thị Xuân, TP. Hồ Chí Minh", RewardPoints = 85, MembershipRank = "Bạc" },
                new Customer { CustomerId = 7, CustomerName = "Đặng Quốc Bảo", PhoneNumber = "0901000007", Address = "23 Lang Biang, Lạc Dương, Lâm Đồng", RewardPoints = 15, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 8, CustomerName = "Bùi Thị Mai", PhoneNumber = "0901000008", Address = "68 Xô Viết Nghệ Tĩnh, TP. Hồ Chí Minh", RewardPoints = 310, MembershipRank = "Vàng" },
                new Customer { CustomerId = 9, CustomerName = "Đỗ Thành Đạt", PhoneNumber = "0901000009", Address = "31 Lê Lợi, Đơn Dương, Lâm Đồng", RewardPoints = 40, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 10, CustomerName = "Ngô Thị Hương", PhoneNumber = "0901000010", Address = "42 Trần Hưng Đạo, TP. Hồ Chí Minh", RewardPoints = 65, MembershipRank = "Bạc" },
                new Customer { CustomerId = 11, CustomerName = "Dương Minh Đức", PhoneNumber = "0901000011", Address = "15 Nguyễn Công Trứ, Bảo Lộc, Lâm Đồng", RewardPoints = 20, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 12, CustomerName = "Phan Ngọc Trâm", PhoneNumber = "0901000012", Address = "72 Hoàng Diệu, TP. Hồ Chí Minh", RewardPoints = 180, MembershipRank = "Vàng" },
                new Customer { CustomerId = 13, CustomerName = "Lý Tuấn Kiệt", PhoneNumber = "0901000013", Address = "29 Quốc lộ 20, Đức Trọng, Lâm Đồng", RewardPoints = 55, MembershipRank = "Bạc" },
                new Customer { CustomerId = 14, CustomerName = "Mai Thị Thảo", PhoneNumber = "0901000014", Address = "36 Pasteur, TP. Hồ Chí Minh", RewardPoints = 5, MembershipRank = "Chuẩn" },
                new Customer { CustomerId = 15, CustomerName = "Cao Gia Huy", PhoneNumber = "0901000015", Address = "54 đường 19/5, Lạc Dương, Lâm Đồng", RewardPoints = 100, MembershipRank = "Bạc" }
            
            );
        }
    }
}