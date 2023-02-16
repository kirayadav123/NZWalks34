using Microsoft.EntityFrameworkCore;
using Remotepractice.Models.Domain;


namespace Remotepractice.Data
{
    public class RemotePracticeDbContext : DbContext
    {
        public RemotePracticeDbContext(DbContextOptions<RemotePracticeDbContext> options) : base(options)
        {

        }
        

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<UserModel>().HasOne<CartModel>
            (s => s.CartId).WithOne(a => a.UserModel).HasForeignKey<CartModel>(a => a.UserId);
            modelbuilder.Entity<UserModel>().HasOne<WalletModel>
        (s => s.WalletId).WithOne(a => a.UserModel).HasForeignKey<WalletModel>(a => a.UserModel_UserId).OnDelete(DeleteBehavior.ClientSetNull);

        }
        public DbSet<RoleModel> roleModels { get; set; }
        public DbSet<UserModel> userModels { get; set; }
        public DbSet<CategoryModel> categoryModels { get; set; }
        public DbSet<ProductModel> productModels { get; set; }
        public DbSet<CartModel> cartModels { get; set; }
        public DbSet<WalletModel> walletModels { get; set; }
        public DbSet<OrderModel> orderModels { get; set; }
    }
}
