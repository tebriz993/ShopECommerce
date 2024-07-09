using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Dtos.HomeDtos
{
    public class Home_CarouselViewDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


        public string Title { get; set; }
    }
}
