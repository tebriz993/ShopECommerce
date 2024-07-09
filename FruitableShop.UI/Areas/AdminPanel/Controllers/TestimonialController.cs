using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SoftwareVillage.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialServicecs _testimonialServices;
        private readonly IWebHostEnvironment _env;

        public TestimonialController(ITestimonialServicecs testimonialServices, IWebHostEnvironment env)
        {
            _testimonialServices = testimonialServices;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<TestimonialViewDto> testimonials = await _testimonialServices.GetAllClients();
            return View(testimonials);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Professions = await _testimonialServices.GetAllProfessions();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TestimonialViewDto testimonialViewDto)
        {
            ViewBag.Professions = await _testimonialServices.GetAllProfessions();
            if (!ModelState.IsValid)
            {
                //ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                return View(testimonialViewDto);
            }

            if (testimonialViewDto.Photo == null)
            {
                ModelState.AddModelError("Photo", "Şəkil seçilməyib");
               // ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                return View(testimonialViewDto);
            }

            if (!testimonialViewDto.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Tipi səhvdir");
               // ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                return View(testimonialViewDto);
            }

            if (testimonialViewDto.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", "Ölçü ödənmir");
                //ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                return View(testimonialViewDto);
            }

            var filename = Guid.NewGuid().ToString() + "_" + testimonialViewDto.Photo.FileName;
            testimonialViewDto.Image = filename;
            string path = Path.Combine(_env.WebRootPath, "assets/img", filename);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await testimonialViewDto.Photo.CopyToAsync(stream);
            }

            await _testimonialServices.CreateTestimonial(testimonialViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var testimonial = await _testimonialServices.GetTestimonialById(id);
            if (testimonial == null)
            {
                return NotFound();
            }

            ViewBag.Professions = await _testimonialServices.GetAllProfessions();
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TestimonialViewDto testimonialViewDto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                return View(testimonialViewDto);
            }

            if (testimonialViewDto.Photo != null)
            {
                if (!testimonialViewDto.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Tipi səhvdir");
                    ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                    return View(testimonialViewDto);
                }

                if (testimonialViewDto.Photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photo", "Ölçü ödənmir");
                    ViewBag.Professions = await _testimonialServices.GetAllProfessions();
                    return View(testimonialViewDto);
                }

                var filename = Guid.NewGuid().ToString() + "_" + testimonialViewDto.Photo.FileName;
                testimonialViewDto.Image = filename;
                string path = Path.Combine(_env.WebRootPath, "assets/img", filename);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await testimonialViewDto.Photo.CopyToAsync(stream);
                }
            }

            await _testimonialServices.UpdateTestimonial(testimonialViewDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _testimonialServices.DeleteTestimoniall(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
