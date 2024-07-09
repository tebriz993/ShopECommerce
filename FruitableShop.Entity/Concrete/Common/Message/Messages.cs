using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.Entity.Concrete.Common.Message
{
    public class Messages:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
    }
}
