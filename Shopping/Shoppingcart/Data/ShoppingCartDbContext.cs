
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Shoppingcart.Models.Domain;

namespace Shoppingcart.Data
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        {
        //  Protected override void
        //    onModelCreating(ModelBuilder modelBuilder)
        //{
        //    ModelBuilder.Entity<UserModel>()
        //        .HasOne<CartModel>(c=>c.CartId).WithOne(a=>a.User);
        //    .HasForeignKey<CartModel>(c=>c.UserId)
        //}
        }
     public DbSet <UserModel> userModels { get; set; }
        //public DbSet<OrderModel> orderModels { get; set; }
        //public DbSet<CartModel> cartModels { get; set; }
        //public DbSet<ProductModel> productModels { get; set; }
        //public DbSet<CategoryModel> categoryModels { get; set; }
        //public DbSet<WalletModel> walletModels { get; set; }
        public DbSet<RoleModel> roleModels { get; set; }


        }


    }

