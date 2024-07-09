using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using System.Threading.Tasks;

namespace ShopECommerce.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MessageController : Controller
    {
        private readonly IContactService _contactService;

        public MessageController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var messages = await _contactService.GetAllMessages();
            return View(messages);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            var carousel = await _contactService.GetMessageById(id);
            if (carousel == null)
            {
                return NotFound();
            }
            await _contactService.DeleteMessage(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
