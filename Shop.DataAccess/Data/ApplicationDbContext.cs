using BookShop.Models.Models;
using BookShopProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libo.",
                    ISBN = "SWD999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId =  1
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libo.",
                    ISBN = "CAW77776",
                    ListPrice = 95,
                    Price = 87,
                    Price50 = 82,
                    Price100 = 72,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in te Sunset",
                    Author = "Julian Button",
                    Description = "Praesent vitae sodales libo.",
                    ISBN = "BVR44448",
                    ListPrice = 88,
                    Price = 80,
                    Price50 = 78,
                    Price100 = 68,
                    CategoryId = 2
                }
                );
        }
    }
}
