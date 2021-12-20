﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyNlayerProject.Data;

namespace UdemyNlayerProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UdemyNlayerProject.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Klavyeler"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Fareler"
                        });
                });

            modelBuilder.Entity("UdemyNlayerProject.Core.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("UdemyNlayerProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Gamebooster Ogre RGB Red Switch Mekanik Klavye",
                            Price = 520.99m,
                            Stock = 67
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Logitech MK220 Kablosuz Türkçe Klavye",
                            Price = 129.99m,
                            Stock = 59
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Monster Pusat K3 Pro Mekanik",
                            Price = 679.99m,
                            Stock = 34
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Msı Gg Clutch GM41 Kablosuz Mouse",
                            Price = 784.99m,
                            Stock = 16
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Razer Deathadder Essential Mouse",
                            Price = 55.78m,
                            Stock = 74
                        });
                });

            modelBuilder.Entity("UdemyNlayerProject.Core.Models.Product", b =>
                {
                    b.HasOne("UdemyNlayerProject.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("UdemyNlayerProject.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
