using global::MyApp.Repository.Models.MyApp.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Repository.Data
{
    namespace MyApp.Repository.Data
    {
        public class MyAppDbContext : DbContext
        {
            public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
            {
            }

            public DbSet<Supplier> Suppliers { get; set; }
        }
    }

}
