using System;
using Azure;
using HarmonyHaven.Controllers;
using HarmonyHaven.Models;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHaven
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        //public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categories Table
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Hygiene Products" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, CategoryName = "Towels" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, CategoryName = "Personal Items" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, CategoryName = "Bedding" });


            //Products Table

            // -- Hygiene Products --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "Hand Soap", ProductDescription = "Rice Milk & Cherry Blossom", ProductPrice = 15.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pmv-chamara-BzrLJzP4q6w-unsplash.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 2, ProductName = "Shower gel", ProductDescription = "Black Rice & Youshino Cherry", ProductPrice = 19.99M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-hype-international-395825114-14798571.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 3, ProductName = "Shampoo", ProductDescription = "Rice Milk & Cherry Blossom", ProductPrice = 29.90M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-dogu-tuncer-339534179-16749131.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 4, ProductName = "Conditioner", ProductDescription = "Rice Milk & Cherry Blossom", ProductPrice = 25.90M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-dogu-tuncer-339534179-16749131.jpg" });

            // -- Towels --
            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 11, ProductName = "Bath towel", ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 27 x 56", ProductPrice = 35.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/bath-towel.jpeg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 12, ProductName = "Hand towel", ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 16 x 27", ProductPrice = 19.99M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/hand-towel.jpeg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 13, ProductName = "Washcloth", ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 12 x 12", ProductPrice = 5.90M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/washcloth.jpeg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 14, ProductName = "Towel Set", ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, Includes: 2 Bath Towels (27\" x 56\"), 2 Hand Towels (16\" x 27\"), 2 Washcloths (12\" x 12\")", ProductPrice = 139.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/towel-set.jpeg" });

            // -- Personal Items --
            modelBuilder.Entity<Product>().HasData(
              new Product { Id = 21, ProductName = "Slippers", ProductDescription = "Leather Slippers, Brown", ProductPrice = 15.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-ketut-subiyanto-4474051.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 22, ProductName = "Pyjamas", ProductDescription = "Hotel Women's Sateen Pyjamas", ProductPrice = 49.99M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-shvets-production-8416110.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 23, ProductName = "Bathrobe", ProductDescription = "Diamond Waffle Robe", ProductPrice = 59.90M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/robe.jpeg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 24, ProductName = "Swimsuit", ProductDescription = "Hotel du Cap Swimsuit", ProductPrice = 35.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-jenyzest-3722151.jpg" });

            // -- Bedding --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 31, ProductName = "Duvet", ProductDescription = "Blend Cotton, 300 thread count, Machine Washable", ProductPrice = 150.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6903157.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 32, ProductName = "Bedding set", ProductDescription = "1 Square Pillowcase Pair,1 Duvet, 1 Signature Duvet Cover, 1 Signature Flat Sheet (Except for the Twin Size), 1 Signature Fitted Sheet", ProductPrice = 509.99M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6394593.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 33, ProductName = "Bed sheet", ProductDescription = "100% Sateen Cotton, 300 Thread Count, Machine Washable", ProductPrice = 89.90M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-rednguyen-11626953.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 34, ProductName = "Pillow", ProductDescription = "The Inner fill: 100% new white duck feathers" +
                "The outer fill: natural hybrid blend of new white duck down 90% and sustainable fibre balls, Pillow case: 100% cotton.",
                    ProductPrice = 35.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-castorlystock-3682238.jpg"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 35, ProductName = "Pillowcase", ProductDescription = "100% Sateen Cotton, 300 Thread Count, 5.5 cm hem, Sold as a pair, Machine Washable", ProductPrice = 30.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-ron-lach-8762876.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 36, ProductName = "Bedspread", ProductDescription = "100% OCS organic cotton", ProductPrice = 75.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6438743.jpg" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 37, ProductName = "Duvet cover", ProductDescription = "100% Sateen Cotton, 300 Thread Count, Machine Washable", ProductPrice = 50.00M, ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6394704.jpg" });

            // -- Tags Table
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, TagName = "Hygienic" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 2, TagName = "Comfortable" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 3, TagName = "Sleep" });

            //CategoryProduct Table
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 1 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 2 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 3 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 4 });


            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 11 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 12 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 13 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 14 });


            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId =3, ProductsId = 21 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 22 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 23 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 24 });


            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 31 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 32 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 33 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 34 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 35 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 36 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 37 });

            //ProductTag Table
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 1, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 2, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
               new { ProductsId = 3, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 4, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
               new { ProductsId = 11, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 12, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
               new { ProductsId = 13, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 14, TagsId = 1 });



            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 21, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 22, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 23, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 24, TagsId = 2 });


            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 31, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 32, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
               new { ProductsId = 33, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 34, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
               new { ProductsId = 35, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 36, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 37, TagsId = 3 });

            //Carts Table
            modelBuilder.Entity<Cart>().HasData(
                new { Id = 1, CartTotal = 00.00M });
        }
    }
}
