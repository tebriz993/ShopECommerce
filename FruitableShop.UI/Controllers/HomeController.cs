using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.UI.ViewModels;

namespace ShopECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public async Task<IActionResult> Index()
        {
            var carousels = await _homeService.GetAllHomeCarousels();
            var companyRates = await _homeService.GetAllHomeCompanyRates();
            var services = await _homeService.GetAllHomeServices();

            var viewModel = new Home_VM
            {
                HomeCarousels = carousels,
                HomeCompanyRates = companyRates,
                HomeServices = services
            };

            return View(viewModel);
        }


    }
}
