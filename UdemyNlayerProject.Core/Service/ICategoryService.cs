using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Core.Service
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWitchProductsByIdAsync(int categoryId);
        //Kategoriye özgü metodlar da burada tanımlanmalıdır 

        //Aslında bazı modellerde onlara özgü metodlar yoksa onunla ilgili repository ve service classlarının oluşturulmasına gerek yok

    }
}
