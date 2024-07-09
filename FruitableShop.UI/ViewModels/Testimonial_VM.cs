using ShopECommerce.BusinessLogic.Dtos.Categories;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;

namespace ShopECommerce.UI.ViewModels
{
    public class Testimonial_VM
    {
        public IEnumerable<TestimonialViewDto> Testimonials { get; set; }
        public IEnumerable<ProfessionsViewDto> Professions { get; set; }
    }
}
