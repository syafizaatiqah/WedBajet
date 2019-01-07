using System.Web;
using System.Data.Entity;
using WedBajet.Models;

namespace WedBajet.DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }
    }
}