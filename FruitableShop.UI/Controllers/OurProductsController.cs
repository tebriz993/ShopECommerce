using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Service;
using ShopECommerce.UI.ViewModels;
using System.Threading.Tasks;

namespace ShopECommerce.UI.Controllers
{
    public class OurProductsController : Controller
    {
        private readonly IProductService _productService;

        public OurProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            var products = await _productService.GetAllProducts(categoryId);
            var categories = await _productService.GetAllCategories();

            var viewModel = new OurProducts_VM
            {
                Products = products,
                Categories = categories
            };

            return View(viewModel);
        }
    }
}
