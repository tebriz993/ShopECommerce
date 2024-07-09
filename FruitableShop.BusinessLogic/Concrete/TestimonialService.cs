using AutoMapper;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Concrete
{
    public class TestimonialService : ITestimonialServicecs
    {
        private readonly IClientSaysRepository _clientSaysRepository;
        private readonly IProfessionsRepository _professionsRepository;
        private readonly IMapper _mapper;

        public TestimonialService(IClientSaysRepository clientSaysRepository, IProfessionsRepository professionsRepository, IMapper mapper)
        {
            _clientSaysRepository = clientSaysRepository;
            _professionsRepository = professionsRepository;
            _mapper = mapper;
        }

        public async Task CreateTestimonial(TestimonialViewDto testimonialViewDto)
        {
            var testimonial = _mapper.Map<ClientSays>(testimonialViewDto);
            await _clientSaysRepository.AddAsync(testimonial);
            await _clientSaysRepository.SaveChanges();
        }

        public async Task DeleteTestimoniall(int id)
        {
            var testimonial = await _clientSaysRepository.GetByIdAsync(id);
            if (testimonial != null)
            {
                await _clientSaysRepository.DeleteAsync(testimonial);
            }
        }

        public async Task<IEnumerable<TestimonialViewDto>> GetAllClients()
        {
            var clientsList = await _clientSaysRepository.GetClientSays();
            var clientsViewDtos = _mapper.Map<IEnumerable<TestimonialViewDto>>(clientsList);
            return clientsViewDtos;
        }

        public async Task<TestimonialViewDto> GetTestimonialById(int id)
        {
            var testimonial = await _clientSaysRepository.GetByIdAsync(id);
            return _mapper.Map<TestimonialViewDto>(testimonial);
        }

        public async Task UpdateTestimonial(TestimonialViewDto testimonialViewDto)
        {
            var testimonial = await _clientSaysRepository.GetByIdAsync(testimonialViewDto.Id);
            if (testimonial != null)
            {
                _mapper.Map(testimonialViewDto, testimonial);
                await _clientSaysRepository.UpdateAsync(testimonial);
            }
        }


        public async Task<IEnumerable<ProfessionsViewDto>> GetAllProfessions()
        {
            var professions = await _professionsRepository.GetProfessions();

           return _mapper.Map<IEnumerable<ProfessionsViewDto>>(professions);
        }
    }


}
