﻿// <auto-generated />
using System;
using HarmonyHaven;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HarmonyHaven.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 3
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 4
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 21
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 22
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 23
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 24
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 31
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 32
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 33
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 34
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 35
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 36
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 37
                        });
                });

            modelBuilder.Entity("HarmonyHaven.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CartTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartTotal = 0.00m
                        });
                });

            modelBuilder.Entity("HarmonyHaven.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<decimal>("CartItemTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("HarmonyHaven.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Hygiene Products"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Towels"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Personal Items"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Bedding"
                        });
                });

            modelBuilder.Entity("HarmonyHaven.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CVC")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("CardExpiryDate")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CardHoldersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardNumber")
                        .HasMaxLength(16)
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("HarmonyHaven.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pmv-chamara-BzrLJzP4q6w-unsplash.jpg",
                            ProductDescription = "Rice Milk & Cherry Blossom",
                            ProductName = "Hand Soap",
                            ProductPrice = 15.00m
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-hype-international-395825114-14798571.jpg",
                            ProductDescription = "Black Rice & Youshino Cherry",
                            ProductName = "Shower gel",
                            ProductPrice = 19.99m
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-dogu-tuncer-339534179-16749131.jpg",
                            ProductDescription = "Rice Milk & Cherry Blossom",
                            ProductName = "Shampoo",
                            ProductPrice = 29.90m
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-dogu-tuncer-339534179-16749131.jpg",
                            ProductDescription = "Rice Milk & Cherry Blossom",
                            ProductName = "Conditioner",
                            ProductPrice = 25.90m
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/bath-towel.jpeg",
                            ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 27 x 56",
                            ProductName = "Bath towel",
                            ProductPrice = 35.00m
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/hand-towel.jpeg",
                            ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 16 x 27",
                            ProductName = "Hand towel",
                            ProductPrice = 19.99m
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/washcloth.jpeg",
                            ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, 12 x 12",
                            ProductName = "Washcloth",
                            ProductPrice = 5.90m
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/towel-set.jpeg",
                            ProductDescription = "Cotton blend, Subway tile pattern border, Machine wash and dry, Includes: 2 Bath Towels (27\" x 56\"), 2 Hand Towels (16\" x 27\"), 2 Washcloths (12\" x 12\")",
                            ProductName = "Towel Set",
                            ProductPrice = 139.00m
                        },
                        new
                        {
                            Id = 21,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-ketut-subiyanto-4474051.jpg",
                            ProductDescription = "Leather Slippers, Brown",
                            ProductName = "Slippers",
                            ProductPrice = 15.00m
                        },
                        new
                        {
                            Id = 22,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-shvets-production-8416110.jpg",
                            ProductDescription = "Hotel Women's Sateen Pyjamas",
                            ProductName = "Pyjamas",
                            ProductPrice = 49.99m
                        },
                        new
                        {
                            Id = 23,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/robe.jpeg",
                            ProductDescription = "Diamond Waffle Robe",
                            ProductName = "Bathrobe",
                            ProductPrice = 59.90m
                        },
                        new
                        {
                            Id = 24,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-jenyzest-3722151.jpg",
                            ProductDescription = "Hotel du Cap Swimsuit",
                            ProductName = "Swimsuit",
                            ProductPrice = 35.00m
                        },
                        new
                        {
                            Id = 31,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6903157.jpg",
                            ProductDescription = "Blend Cotton, 300 thread count, Machine Washable",
                            ProductName = "Duvet",
                            ProductPrice = 150.00m
                        },
                        new
                        {
                            Id = 32,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6394593.jpg",
                            ProductDescription = "1 Square Pillowcase Pair,1 Duvet, 1 Signature Duvet Cover, 1 Signature Flat Sheet (Except for the Twin Size), 1 Signature Fitted Sheet",
                            ProductName = "Bedding set",
                            ProductPrice = 509.99m
                        },
                        new
                        {
                            Id = 33,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-rednguyen-11626953.jpg",
                            ProductDescription = "100% Sateen Cotton, 300 Thread Count, Machine Washable",
                            ProductName = "Bed sheet",
                            ProductPrice = 89.90m
                        },
                        new
                        {
                            Id = 34,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-castorlystock-3682238.jpg",
                            ProductDescription = "The Inner fill: 100% new white duck feathersThe outer fill: natural hybrid blend of new white duck down 90% and sustainable fibre balls, Pillow case: 100% cotton.",
                            ProductName = "Pillow",
                            ProductPrice = 35.00m
                        },
                        new
                        {
                            Id = 35,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-ron-lach-8762876.jpg",
                            ProductDescription = "100% Sateen Cotton, 300 Thread Count, 5.5 cm hem, Sold as a pair, Machine Washable",
                            ProductName = "Pillowcase",
                            ProductPrice = 30.00m
                        },
                        new
                        {
                            Id = 36,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6438743.jpg",
                            ProductDescription = "100% OCS organic cotton",
                            ProductName = "Bedspread",
                            ProductPrice = 75.00m
                        },
                        new
                        {
                            Id = 37,
                            ImageUrl = "https://demo.justvalue.se/cal/wp-content/uploads/2024/05/pexels-heyho-6394704.jpg",
                            ProductDescription = "100% Sateen Cotton, 300 Thread Count, Machine Washable",
                            ProductName = "Duvet cover",
                            ProductPrice = 50.00m
                        });
                });

            modelBuilder.Entity("HarmonyHaven.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "Hygienic"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Comfortable"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Sleep"
                        });
                });

            modelBuilder.Entity("HarmonyHaven.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ProductTag");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 2,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 3,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 4,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 11,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 12,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 13,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 14,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 21,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 22,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 23,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 24,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 31,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 32,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 33,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 34,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 35,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 36,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 37,
                            TagsId = 3
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("HarmonyHaven.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HarmonyHaven.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HarmonyHaven.Models.CartItem", b =>
                {
                    b.HasOne("HarmonyHaven.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HarmonyHaven.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.HasOne("HarmonyHaven.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HarmonyHaven.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HarmonyHaven.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
