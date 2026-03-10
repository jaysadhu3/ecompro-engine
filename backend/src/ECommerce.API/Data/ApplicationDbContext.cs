using ECommerce.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public required DbSet<Product> Products { get; set; }

        public required DbSet<Category> Categories { get; set; }
    }
}
