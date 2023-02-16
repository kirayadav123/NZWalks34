using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shoppingcart.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryModels",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryModels", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "roleModels",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roleModels", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "productModels",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CategoryModelCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productModels", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_productModels_categoryModels_CategoryModelCategoryId",
                        column: x => x.CategoryModelCategoryId,
                        principalTable: "categoryModels",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userModels",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleModelUserTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userModels", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_userModels_roleModels_RoleModelUserTypeId",
                        column: x => x.RoleModelUserTypeId,
                        principalTable: "roleModels",
                        principalColumn: "UserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cartModels",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false),
                    ProductModelProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartModels", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_cartModels_productModels_ProductModelProductId",
                        column: x => x.ProductModelProductId,
                        principalTable: "productModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartModels_userModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "userModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderModels",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountPaid = table.Column<float>(type: "real", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartModelCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderModels", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_orderModels_cartModels_CartModelCartId",
                        column: x => x.CartModelCartId,
                        principalTable: "cartModels",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "walletModels",
                columns: table => new
                {
                    WalletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false),
                    CartModelCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_walletModels", x => x.WalletId);
                    table.ForeignKey(
                        name: "FK_walletModels_cartModels_CartModelCartId",
                        column: x => x.CartModelCartId,
                        principalTable: "cartModels",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_walletModels_userModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "userModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartModels_ProductModelProductId",
                table: "cartModels",
                column: "ProductModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_cartModels_UserModelUserId",
                table: "cartModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_orderModels_CartModelCartId",
                table: "orderModels",
                column: "CartModelCartId");

            migrationBuilder.CreateIndex(
                name: "IX_productModels_CategoryModelCategoryId",
                table: "productModels",
                column: "CategoryModelCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_userModels_RoleModelUserTypeId",
                table: "userModels",
                column: "RoleModelUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_walletModels_CartModelCartId",
                table: "walletModels",
                column: "CartModelCartId");

            migrationBuilder.CreateIndex(
                name: "IX_walletModels_UserModelUserId",
                table: "walletModels",
                column: "UserModelUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderModels");

            migrationBuilder.DropTable(
                name: "walletModels");

            migrationBuilder.DropTable(
                name: "cartModels");

            migrationBuilder.DropTable(
                name: "productModels");

            migrationBuilder.DropTable(
                name: "userModels");

            migrationBuilder.DropTable(
                name: "categoryModels");

            migrationBuilder.DropTable(
                name: "roleModels");
        }
    }
}
