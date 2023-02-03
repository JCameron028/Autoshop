using Autoshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Autoshop.Infrastructure
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}