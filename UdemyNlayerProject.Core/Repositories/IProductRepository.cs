using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Core.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
