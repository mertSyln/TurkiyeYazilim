﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Project1.Persistence.Context;

#nullable disable

namespace Project1.Persistence.Migrations
{
    [DbContext(typeof(Project1DbContext))]
    [Migration("20241128013705_createtables")]
    partial class createtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Project1.Domain.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ItemId"));

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ItemImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Project1.Domain.Entities.ItemProperty", b =>
                {
                    b.Property<int>("ItemPropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ItemPropertyId"));

                    b.Property<int?>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ItemPropertyId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemProperties");
                });

            modelBuilder.Entity("Project1.Domain.Entities.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OfferId"));

                    b.Property<int>("BuyerItemId")
                        .HasColumnType("integer");

                    b.Property<int>("BuyerUserId")
                        .HasColumnType("integer");

                    b.Property<string>("OfferDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("OfferPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SellerUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OfferId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Project1.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyFile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyWeb")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project1.Domain.Entities.ItemProperty", b =>
                {
                    b.HasOne("Project1.Domain.Entities.Item", null)
                        .WithMany("ItemProperties")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("Project1.Domain.Entities.Item", b =>
                {
                    b.Navigation("ItemProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
