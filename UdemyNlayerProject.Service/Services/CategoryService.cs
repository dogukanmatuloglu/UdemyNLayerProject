using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;
using UdemyNlayerProject.Core.Service;
using UdemyNlayerProject.Core.UnitOfWork;

namespace UdemyNlayerProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository):base(unitOfWork,repository)
        {
            
        }
        public async Task<Category> GetWitchProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWitchProductsByIdAsync(categoryId);
        }
    }
}
