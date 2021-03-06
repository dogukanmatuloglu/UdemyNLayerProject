using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;

namespace UdemyNlayerProject.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
       return await _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
        }
    }
}
