using Microsoft.EntityFrameworkCore;

namespace OrderServices.Data
{
    public class OrderSerDbContext:DbContext
    {
        public OrderSerDbContext(DbContextOptions<OrderSerDbContext> options):base(options) 
        {
            
        }
        public DbSet<OrderServices.Entities.Orders> Orders { get; set; }
    }
}
