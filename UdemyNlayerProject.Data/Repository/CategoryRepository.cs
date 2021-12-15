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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWitchProductsByIdAsync(int categoryId)
        {
          return await  _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
