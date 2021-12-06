using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Core.Service
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithCategoryById(int productId);
    }
}
