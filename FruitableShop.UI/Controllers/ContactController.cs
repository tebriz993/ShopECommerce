using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Message;
using ShopECommerce.UI.ViewModels;

namespace ShopECommerce.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public async Task<IActionResult> Index()
        {
            var contacts = await _contactService.GetAllContacts();
           var messages=await _contactService.GetAllMessages();

            var viewModel = new Contact_VM
            {
                Contacts = contacts,
                Messages= messages
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitMessage(MessageViewDto model)
        {
            if (ModelState.IsValid)
            {
                await _contactService.CreateMessage(model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }


    }
}
