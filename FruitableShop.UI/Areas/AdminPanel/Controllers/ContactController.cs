using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Abstract;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;

namespace SoftwareVillage.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
       
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
            
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ContactViewDto> contacts = await _contactService.GetAllContacts();
            return View(contacts);
        }

        public IActionResult Create()
        {
            var model = new ContactViewDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactViewDto contactViewDto)
        {
            if (!ModelState.IsValid) return View();

            await _contactService.CreateContacts(contactViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var contacts = await _contactService.GetContactsById(id);
            if (contacts == null)
            {
                return NotFound();
            }

            return View(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ContactViewDto contactViewDto)
        {
            if (!ModelState.IsValid) return View(contactViewDto);

            var contacts = await _contactService.GetContactsById(contactViewDto.Id);

            await _contactService.UpdateContacts(contacts);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            var contacts = await _contactService.GetContactsById(id);
            if (contacts == null)
            {
                return NotFound();
            }
            await _contactService.DeleteContacts(id);
            return RedirectToAction(nameof(Index));
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
