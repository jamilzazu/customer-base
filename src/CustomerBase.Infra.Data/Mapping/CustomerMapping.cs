using CustomerBase.Domain.Entities;
using CustomerBase.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerBase.Infra.Data.Mapping
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name)
               .HasColumnType("varchar(150)")
               .IsRequired();

            builder.Property(e => e.Document)
                .HasColumnType("varchar(150)"); 

            builder.Property(e => e.Email)
                .HasColumnType("varchar(max)");

            builder.Property(e => e.Phone)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(e => e.Status);

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Customer");
        }
    }
}