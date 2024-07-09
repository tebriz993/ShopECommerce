using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;
using ShopECommerce.Entity.Concrete.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Abstract
{
    public interface IContactService
    {
        // For Contact
        public Task<IEnumerable<ContactViewDto>> GetAllContacts();
        public Task<ContactViewDto> GetContactsById(int id);
        public Task CreateContacts(ContactViewDto contactsViewDto);
        public Task UpdateContacts(ContactViewDto contactsViewDto);
        public Task DeleteContacts(int id);

        //Methods for Messages
        Task<IEnumerable<MessageViewDto>> GetAllMessages();
        Task<MessageViewDto> GetMessageById(int id);
        Task CreateMessage(MessageViewDto messageViewDto);
        Task DeleteMessage(int id);
    }
}
