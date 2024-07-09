using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace ShopECommerce.Entity.Concrete.Common.Home
{
    public class Home_Carousel : BaseEntity
    {
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Title { get; set; } = string.Empty;

    }
}
