using ECommerce.API.Data;
using ECommerce.API.Models;
using ECommerce.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            var category = await _context.Categories.FindAsync(product.CategoryId);

            if (category == null)
            {
                throw new Exception("Category does not exist");
            }
            await _context.Products.AddAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                    .Include(p => p.Category)
                    .ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
