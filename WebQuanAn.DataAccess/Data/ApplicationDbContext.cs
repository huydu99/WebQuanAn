using WebQuanAn.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace WebQuanAn.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BookTable> BookTables { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Món khai vị", Status=true ,Description="Các món khai vị"},
                new Category { Id = 2, Name = "Món chính", Status = true, Description = "Các món ăn chính" },
                new Category { Id = 3, Name = "Lẫu", Status = true, Description = "Các loại lẫu" },
				new Category { Id = 4, Name = "Đồ uống", Status = true, Description = "Các loại nước uống" }
				);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Khai vị 1",
                    ShortDescription = "Khai vị 1",
                    Description = "Khai vị 1",
                    Status = true,
                    PromotionPrice = 25000,
                    Price = 30000,
                    CategoryId = 1,         
                    CreateAt = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    Name = "Món chính 1",  
                    ShortDescription = "Món chính 2",
                    Description = "Món chính 2",
                    Status = true,
                    PromotionPrice = 25000,
                    Price = 30000,
                    CategoryId = 2,
                    CreateAt = DateTime.Now,
                });
            //modelBuilder.Entity<IdentityUserClaim<Guid>>().
            base.OnModelCreating(modelBuilder);
        }

    }
}
