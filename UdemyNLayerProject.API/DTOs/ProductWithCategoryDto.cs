using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNLayerProject.API.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
