﻿// <auto-generated />
using System;
using CustomerBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerBase.Infra.Data.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerBase.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Document")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
