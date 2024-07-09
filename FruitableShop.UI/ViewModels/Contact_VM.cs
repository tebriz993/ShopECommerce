using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;


namespace ShopECommerce.UI.ViewModels
{
    public class Contact_VM
    {
        public IEnumerable<ContactViewDto> Contacts { get; set; }
        public IEnumerable<MessageViewDto> Messages { get; set; }
    }
}
