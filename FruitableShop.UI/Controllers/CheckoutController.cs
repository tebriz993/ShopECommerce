using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.UI.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
