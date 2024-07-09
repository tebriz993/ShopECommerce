using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Dtos.ContactDtos
{
    public class ContactViewDto
    {
        public int Id { get; set; }
        public string AddressIcon { get; set; }
        public string Address { get; set; }
        public string AddressText { get; set; }

        public string MailIcon { get; set; }
        public string Mail { get; set; }
        public string MailText { get; set; }

        public string TelephoneIcon { get; set; }
        public string Telephone { get; set; }
        public string TelephoneText { get; set; }
    }
}
