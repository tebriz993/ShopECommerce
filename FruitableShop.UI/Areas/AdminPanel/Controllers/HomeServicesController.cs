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

namespace SoftwareVillage.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class HomeServicesController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly IWebHostEnvironment _env;

        public HomeServicesController(IHomeService homeService, IWebHostEnvironment env)
        {
            _homeService = homeService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Home_ServicesViewDto> services = await _homeService.GetAllHomeServices();
            return View(services);
        }

        public IActionResult Create()
        {
            var model = new Home_ServicesViewDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Home_ServicesViewDto home_ServicesViewDto)
        {
            if (!ModelState.IsValid) return View();

            await _homeService.CreateHomeServices(home_ServicesViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var services = await _homeService.GetHomeServicesById(id);
            if (services == null)
            {
                return NotFound();
            }

            return View(services);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Home_ServicesViewDto home_ServicesViewDto)
        {
            if (!ModelState.IsValid) return View(home_ServicesViewDto);

            var homeServices = await _homeService.GetHomeServicesById(home_ServicesViewDto.Id);

            await _homeService.UpdateHomeServices(home_ServicesViewDto);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            var services = await _homeService.GetHomeServicesById(id);
            if (services == null)
            {
                return NotFound();
            }
            await _homeService.DeleteHomeServices(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
