﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Remotepractice.Data;

#nullable disable

namespace Remotepractice.Migrations
{
    [DbContext(typeof(RemotePracticeDbContext))]
    partial class RemotePracticeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Remotepractice.Models.Domain.CartModel", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<int>("ProductModel_ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("productname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartId");

                    b.HasIndex("ProductModel_ProductId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("cartModels");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.CategoryModel", b =>
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

            modelBuilder.Entity("Remotepractice.Models.Domain.OrderModel", b =>
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

            modelBuilder.Entity("Remotepractice.Models.Domain.ProductModel", b =>
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

            modelBuilder.Entity("Remotepractice.Models.Domain.RoleModel", b =>
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

            modelBuilder.Entity("Remotepractice.Models.Domain.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleModelUserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleModelUserTypeId");

                    b.ToTable("userModels");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.WalletModel", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WalletId"), 1L, 1);

                    b.Property<int>("CartModelCartId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("UserModel_UserId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("CartModelCartId");

                    b.HasIndex("UserModel_UserId")
                        .IsUnique();

                    b.ToTable("walletModels");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.CartModel", b =>
                {
                    b.HasOne("Remotepractice.Models.Domain.ProductModel", "ProductModel")
                        .WithMany()
                        .HasForeignKey("ProductModel_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Remotepractice.Models.Domain.UserModel", "UserModel")
                        .WithOne("CartId")
                        .HasForeignKey("Remotepractice.Models.Domain.CartModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.OrderModel", b =>
                {
                    b.HasOne("Remotepractice.Models.Domain.CartModel", "CartModel")
                        .WithMany()
                        .HasForeignKey("CartModelCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartModel");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.ProductModel", b =>
                {
                    b.HasOne("Remotepractice.Models.Domain.CategoryModel", "CategoryModel")
                        .WithMany()
                        .HasForeignKey("CategoryModelCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryModel");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.UserModel", b =>
                {
                    b.HasOne("Remotepractice.Models.Domain.RoleModel", "RoleModel")
                        .WithMany()
                        .HasForeignKey("RoleModelUserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleModel");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.WalletModel", b =>
                {
                    b.HasOne("Remotepractice.Models.Domain.CartModel", "CartModel")
                        .WithMany()
                        .HasForeignKey("CartModelCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Remotepractice.Models.Domain.UserModel", "UserModel")
                        .WithOne("WalletId")
                        .HasForeignKey("Remotepractice.Models.Domain.WalletModel", "UserModel_UserId")
                        .IsRequired();

                    b.Navigation("CartModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Remotepractice.Models.Domain.UserModel", b =>
                {
                    b.Navigation("CartId")
                        .IsRequired();

                    b.Navigation("WalletId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
