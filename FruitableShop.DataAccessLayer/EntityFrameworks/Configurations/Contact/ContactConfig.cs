using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Contact
{
    public class ContactConfig:BaseConfiguration<Contacts>
    {
        public override void Configure(EntityTypeBuilder<Contacts> builder)
        {
            base.Configure(builder);
            builder.Property(i => i.AddressIcon)
                .IsRequired();
            builder.Property(t => t.Address)
                .IsRequired();
            builder.Property(i => i.AddressText)
                .IsRequired();

            builder.Property(t => t.MailIcon)
                .IsRequired();
            builder.Property(i => i.Mail)
                .IsRequired();
            builder.Property(t => t.MailText)
                .IsRequired();

            builder.Property(t => t.TelephoneIcon)
                .IsRequired();
            builder.Property(i => i.Telephone)
                .IsRequired();
            builder.Property(t => t.TelephoneText)
                .IsRequired();
        }

    }
}
