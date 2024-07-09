using Microsoft.AspNetCore.Http;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.BusinessLogic.Dtos.TestimonialDtos
{
    public class TestimonialViewDto
    {
        public int Id { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Name { get; set; }
        public string ProfessionName { get; set; }

        public int ProfessionId { get; set; }
        //public ProfessionsViewDto ProfessionName { get; set; }

    }
}
