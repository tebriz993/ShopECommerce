using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.UI.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialServicecs _testimonialServices;

        public TestimonialController(ITestimonialServicecs testimonialServices)
        {
            _testimonialServices = testimonialServices;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<TestimonialViewDto> clients = await _testimonialServices.GetAllClients();
            return View(clients);
        }
    }
}
