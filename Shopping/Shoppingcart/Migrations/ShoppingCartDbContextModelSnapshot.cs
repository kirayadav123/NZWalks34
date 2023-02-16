﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shoppingcart.Data;

#nullable disable

namespace Shoppingcart.Migrations
{
    [DbContext(typeof(ShoppingCartDbContext))]
    partial class ShoppingCartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shoppingcart.Models.Domain.CartModel", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<int>("ProductModelProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.Property<int>("UserModelUserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("ProductModelProductId");

                    b.HasIndex("UserModelUserId");

                    b.ToTable("cartModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categoryModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.OrderModel", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<float>("AmountPaid")
                        .HasColumnType("real");

                    b.Property<int>("CartModelCartId")
                        .HasColumnType("int");

                    b.Property<string>("ModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("CartModelCartId");

                    b.ToTable("orderModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryModelCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryModelCategoryId");

                    b.ToTable("productModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.RoleModel", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeId"), 1L, 1);

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeId");

                    b.ToTable("roleModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleModelUserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleModelUserTypeId");

                    b.ToTable("userModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.WalletModel", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletId"), 1L, 1);

                    b.Property<int>("CartModelCartId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("UserModelUserId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("CartModelCartId");

                    b.HasIndex("UserModelUserId");

                    b.ToTable("walletModels");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.CartModel", b =>
                {
                    b.HasOne("Shoppingcart.Models.Domain.ProductModel", "ProductModel")
                        .WithMany()
                        .HasForeignKey("ProductModelProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoppingcart.Models.Domain.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.OrderModel", b =>
                {
                    b.HasOne("Shoppingcart.Models.Domain.CartModel", "CartModel")
                        .WithMany()
                        .HasForeignKey("CartModelCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartModel");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.ProductModel", b =>
                {
                    b.HasOne("Shoppingcart.Models.Domain.CategoryModel", "CategoryModel")
                        .WithMany()
                        .HasForeignKey("CategoryModelCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryModel");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.UserModel", b =>
                {
                    b.HasOne("Shoppingcart.Models.Domain.RoleModel", "RoleModel")
                        .WithMany()
                        .HasForeignKey("RoleModelUserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleModel");
                });

            modelBuilder.Entity("Shoppingcart.Models.Domain.WalletModel", b =>
                {
                    b.HasOne("Shoppingcart.Models.Domain.CartModel", "CartModel")
                        .WithMany()
                        .HasForeignKey("CartModelCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shoppingcart.Models.Domain.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartModel");

                    b.Navigation("UserModel");
                });
#pragma warning restore 612, 618
        }
    }
}
