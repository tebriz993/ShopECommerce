using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IHome_CarouselRepository:IGenericRepository<Home_Carousel>
    {
        Task<IEnumerable<Home_Carousel>> GetCarousels();
        Task UpdateAsync(Home_Carousel homeCarousel); 
        Task DeleteAsync(Home_Carousel homeCarousel);
    }
}
