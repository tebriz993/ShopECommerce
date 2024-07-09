using System;

namespace ShopECommerce.BusinessLogic.Dtos.MessagesDtos
{
    public class MessageViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
}
