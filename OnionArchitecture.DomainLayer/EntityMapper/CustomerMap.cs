using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitecture.DomainLayer.Models;
using System;

namespace OnionArchitecture.DomainLayer.EntityMapper
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(x => x.Id)
                            .HasName("pk_customerid");

            builder.Property(x => x.CustomerName)
                .HasColumnName("Customer_Name")
                .HasColumnType("NVARCHAR(200)")
                .IsRequired();

            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id")
                   .HasColumnType("INT");

            builder.Property(x => x.PurchasesProduct)
                .HasColumnName("purchased_product")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();

            builder.Property(x => x.PaymentType)
              .HasColumnName("payment_type")
                 .HasColumnType("NVARCHAR(50)")
                 .IsRequired();

            builder.Property(x => x.CreatedDate)
              .HasColumnName("created_date")
                 .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
              .HasColumnName("modified_date")
                 .HasColumnType("datetime");

            builder.Property(x => x.IsActive)
              .HasColumnName("is_active")
                 .HasColumnType("bit");

            builder.HasData(
                new Customer { Id = 1, CustomerName = "João Augusto", PaymentType = "Cartão", PurchasesProduct = "S", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = false },
                new Customer { Id = 2, CustomerName = "Maria Augusta", PaymentType = "Dinheiro", PurchasesProduct = "S", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true },
                new Customer { Id = 3, CustomerName = "José Augusto Rodrigues", PaymentType = "Cheque", PurchasesProduct = "S", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true },
                new Customer { Id = 4, CustomerName = "Fernando Medeiros de Almeida", PaymentType = "Cartão Débito", PurchasesProduct = "S", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = false },
                new Customer { Id = 5, CustomerName = "João Alfredo", PaymentType = "Pix", PurchasesProduct = "S", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true }
            );
        }
    }
}
