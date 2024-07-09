using ShopECommerce.BusinessLogic.Dtos.Categories;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using ShopECommerce.Entity.Concrete.Common.OurProducts;

namespace ShopECommerce.UI.ViewModels
{
    public class OurProducts_VM
    {
        public IEnumerable<ProductViewDto> Products { get; set; }
        public IEnumerable<CategoriesViewDto> Categories { get; set; }
        
    }
}
