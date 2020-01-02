using Microsoft.EntityFrameworkCore;

namespace PieFunction
{
    public class FunctionDBContext:DbContext
    {
        public FunctionDBContext(DbContextOptions<FunctionDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Pie>()
                .HasOne(p => p.RecipeInformation)
                .WithOne(i => i.Pie)
                .HasForeignKey<RecipeInformation>(b => b.PieId);
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PieReview> PieReviews { get; set; }
        public DbSet<PieGiftOrder> PieGiftOrders { get; set; }
    }
}
