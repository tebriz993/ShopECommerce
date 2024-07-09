using AutoMapper;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Concrete
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;
        public ContactService(IContactRepository contactRepository,
                              IMessageRepository messageRepository,
                              IMapper mapper)
        {
            _contactRepository = contactRepository;
            _messageRepository=messageRepository;
            _mapper = mapper;
        }

        //For Contact
        public async Task CreateContacts(ContactViewDto contactsViewDto)
        {
            var contacts = _mapper.Map<Contacts>(contactsViewDto);
            await _contactRepository.AddAsync(contacts);
            await _contactRepository.SaveChanges();
        }

        public async Task DeleteContacts(int id)
        {
            var contacts = await _contactRepository.GetByIdAsync(id);
            if (contacts != null)
            {
                await _contactRepository.DeleteAsync(contacts);
            }
        }

        public async Task<IEnumerable<ContactViewDto>> GetAllContacts()
        {
            var contactList = await _contactRepository.GetContacts();
            var contactViewDtos = _mapper.Map<IEnumerable<ContactViewDto>>(contactList);
            return contactViewDtos;
        }

        public async Task<ContactViewDto> GetContactsById(int id)
        {
            var contact = await _contactRepository.GetByIdAsync(id);
            return _mapper.Map<ContactViewDto>(contact);
        }

        public async Task UpdateContacts(ContactViewDto contactsViewDto)
        {
            var contacts = await _contactRepository.GetByIdAsync(contactsViewDto.Id);
            if (contacts != null)
            {
                _mapper.Map(contactsViewDto, contacts);
                await _contactRepository.UpdateAsync(contacts);
            }
        }





        // For Messages
        public async Task<IEnumerable<MessageViewDto>> GetAllMessages()
        {
            var messages = await _messageRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<MessageViewDto>>(messages);
        }

        public async Task<MessageViewDto> GetMessageById(int id)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            return _mapper.Map<MessageViewDto>(message);
        }

        public async Task CreateMessage(MessageViewDto messageViewDto)
        {
            var message = _mapper.Map<Messages>(messageViewDto);
            await _messageRepository.AddAsync(message);
            await _messageRepository.SaveChanges();
        }

        public async Task DeleteMessage(int id)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            if (message != null)
            {
                await _messageRepository.DeleteAsync(message);
                await _messageRepository.SaveChanges();
            }
        }
    }
}
