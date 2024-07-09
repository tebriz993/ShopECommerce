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
    public class HomeCompanyRatesController : Controller
    {
        private readonly IHomeService _homeService;
        

        public HomeCompanyRatesController(IHomeService homeService)
        {
            _homeService = homeService;
            
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Home_CompanyRatesViewDto> companyRates = await _homeService.GetAllHomeCompanyRates();
            return View(companyRates);
        }

        public IActionResult Create()
        {
            var model = new Home_CompanyRatesViewDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Home_CompanyRatesViewDto home_CompanyRatesViewDto)
        {
            if (!ModelState.IsValid) return View();

            await _homeService.CreateHomeCompanyRates(home_CompanyRatesViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var companyRates = await _homeService.GetHomeCompanyRatesById(id);
            if (companyRates == null)
            {
                return NotFound();
            }

            return View(companyRates);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Home_CompanyRatesViewDto home_CompanyRatesViewDto)
        {
            if (!ModelState.IsValid) return View(home_CompanyRatesViewDto);

            var homeCarousel = await _homeService.GetHomeCompanyRatesById(home_CompanyRatesViewDto.Id);

            await _homeService.UpdateHomeCompanyRates(home_CompanyRatesViewDto);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            var companyRates = await _homeService.GetHomeCompanyRatesById(id);
            if (companyRates == null)
            {
                return NotFound();
            }
            await _homeService.DeleteHomeCompanyRates(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
