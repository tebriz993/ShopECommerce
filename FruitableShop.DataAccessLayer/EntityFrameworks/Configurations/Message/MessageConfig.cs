using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entity.Concrete.Common;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Message
{
    public class MessageConfig:BaseConfiguration<Messages>
    {
        public override void Configure(EntityTypeBuilder<Messages> builder)
        {
            base.Configure(builder);
            builder.Property(i => i.Name)
                .IsRequired();
            builder.Property(t => t.Email)
                .IsRequired();
            builder.Property(t => t.Content)
                .IsRequired();
        }
    }
}
