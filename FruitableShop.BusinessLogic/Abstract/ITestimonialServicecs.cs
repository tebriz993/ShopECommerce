using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Abstract
{
    public  interface ITestimonialServicecs
    {
        public Task<IEnumerable<TestimonialViewDto>> GetAllClients();
        public Task<TestimonialViewDto> GetTestimonialById(int id);
        public Task CreateTestimonial(TestimonialViewDto testimonialViewDto);
        public Task UpdateTestimonial(TestimonialViewDto testimonialViewDto);
        public Task DeleteTestimoniall(int id);
        Task<IEnumerable<ProfessionsViewDto>> GetAllProfessions();
    }
}
