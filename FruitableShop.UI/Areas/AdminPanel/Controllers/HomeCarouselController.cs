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
    public class HomeCarouselController : Controller
    {
        private readonly IHomeService _homeService;
       
        private readonly IWebHostEnvironment _env;

        public HomeCarouselController(IHomeService homeService, IWebHostEnvironment env)
        {
            _homeService = homeService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Home_CarouselViewDto> carousels = await _homeService.GetAllHomeCarousels();
            return View(carousels);
        }

        public IActionResult Create()
        {
            var model = new Home_CarouselViewDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Home_CarouselViewDto home_CarouselViewDto)
        {
            if (!ModelState.IsValid) return View();

            if (home_CarouselViewDto.Photo == null)
            {
                ModelState.AddModelError("Photo", "Şəkil seçilməyib");
                return View();
            }

            if (!home_CarouselViewDto.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Tipi səhvdir");
                return View();
            }

            if (home_CarouselViewDto.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", "Ölçü ödənmir");
                return View();
            }

            var filename = Guid.NewGuid().ToString() + "_" + home_CarouselViewDto.Photo.FileName;
            home_CarouselViewDto.Image = filename;
            string path = Path.Combine(_env.WebRootPath, "assets/img", filename);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await home_CarouselViewDto.Photo.CopyToAsync(stream);
            }
            //home_CarouselViewDto.Image = path;

            await _homeService.CreateHomeCarousel(home_CarouselViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var carousel = await _homeService.GetHomeCarouselById(id);
            if (carousel == null)
            {
                return NotFound();
            }

            return View(carousel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Home_CarouselViewDto homeCarouselViewDto)
        {
            if (!ModelState.IsValid) return View(homeCarouselViewDto);

            var homeCarousel = await _homeService.GetHomeCarouselById(homeCarouselViewDto.Id);

            if (homeCarouselViewDto.Photo != null)
            {
                if (!homeCarouselViewDto.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Tipi səhvdir");
                    return View(homeCarouselViewDto);
                }

                if (homeCarouselViewDto.Photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photo", "Ölçü ödənmir");
                    return View(homeCarouselViewDto);
                }

                var oldImage = homeCarousel.Image;

                var filename = Guid.NewGuid().ToString() + "_" + homeCarouselViewDto.Photo.FileName;
                homeCarouselViewDto.Image = filename;
                string path = Path.Combine(_env.WebRootPath, "assets/img", filename);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await homeCarouselViewDto.Photo.CopyToAsync(stream);
                }

                // Eski resmi sil
                string oldImagePath = Path.Combine(_env.WebRootPath, "assets/img", oldImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            // _mapper.Map(homeCarouselViewDto, homeCarousel);
            await _homeService.UpdateHomeCarousel(homeCarouselViewDto);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            var carousel = await _homeService.GetHomeCarouselById(id);
            if (carousel == null)
            {
                return NotFound();
            }
            await _homeService.DeleteHomeCarousel(id);
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var carousel = await _homeService.GetHomeCarouselById(id);
        //    if (carousel == null)
        //    {
        //        return NotFound();
        //    }

        //    string path = Path.Combine(_env.WebRootPath, "assets/img", carousel.Image);
        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }

        //    await _homeService.DeleteHomeCarousel(id);

        //    return RedirectToAction(nameof(Index));
        //}


    }
}
