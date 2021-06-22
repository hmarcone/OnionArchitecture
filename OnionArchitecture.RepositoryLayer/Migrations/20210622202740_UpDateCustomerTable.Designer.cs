﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionArchitecture.RepositoryLayer;

namespace OnionArchitecture.RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210622202740_UpDateCustomerTable")]
    partial class UpDateCustomerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnionArchitecture.DomainLayer.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("created_date");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)")
                        .HasColumnName("Customer_Name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("modified_date");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("payment_type");

                    b.Property<string>("PurchasesProduct")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("purchased_product");

                    b.HasKey("Id")
                        .HasName("pk_customerid");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
