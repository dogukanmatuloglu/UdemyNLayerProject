using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //id propertysini otomatik artacak şekilde productconfigucs clasında tanımladık ancak default verileri eklerken ıd vermeliyiz.
            builder.HasData(
                new Product { Id = 1, Name = "Gamebooster Ogre RGB Red Switch Mekanik Klavye", Price = 520.99M, Stock = 67, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Logitech MK220 Kablosuz Türkçe Klavye", Price = 129.99M, Stock = 59, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Monster Pusat K3 Pro Mekanik", Price = 679.99M, Stock = 34, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Msı Gg Clutch GM41 Kablosuz Mouse", Price = 784.99M, Stock = 16, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Razer Deathadder Essential Mouse", Price = 55.78M, Stock = 74, CategoryId = _ids[1] }

                

                );
        }
    }
}
