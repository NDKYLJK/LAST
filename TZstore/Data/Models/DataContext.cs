using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //ProductDO是Data里面的类Products是里面指定的表名
            modelBuilder.Entity<ProductDO>().ToTable("Products");

            modelBuilder.Entity<UserDO>().ToTable("User");

            modelBuilder.Entity<OrderDO>().ToTable("Orders");
        }
    }
}
