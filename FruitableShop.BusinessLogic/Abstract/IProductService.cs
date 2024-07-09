using ShopECommerce.BusinessLogic.Dtos.Categories;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.Service
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewDto>> GetAllProducts(int? categoryId);
        Task<IEnumerable<CategoriesViewDto>> GetAllCategories();
        Task AddProducts(ProductAddDto productAddDto);
    }
}
