﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using part4.Data;

namespace part4.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20201126022833_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("part4.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            OrderDate = new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductID = 1
                        },
                        new
                        {
                            OrderID = 2,
                            OrderDate = new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductID = 1
                        },
                        new
                        {
                            OrderID = 3,
                            OrderDate = new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductID = 2
                        });
                });

            modelBuilder.Entity("part4.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Description = "A small and lightweight PC for basic computing tasks.",
                            ImageName = "mini1.jpg",
                            Name = "The Mini",
                            Price = 599.99m
                        },
                        new
                        {
                            ProductID = 2,
                            Description = "A Business PC for professional applications.",
                            ImageName = "business1.jpg",
                            Name = "The Business",
                            Price = 799.99m
                        },
                        new
                        {
                            ProductID = 3,
                            Description = "A PC for playing all of the latest and greatest video games.",
                            ImageName = "gamer1.jpg",
                            Name = "The Gamer",
                            Price = 999.99m
                        });
                });

            modelBuilder.Entity("part4.Models.Upgrade", b =>
                {
                    b.Property<int>("UpgradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UpgradeCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpgradeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpgradePrice")
                        .HasColumnType("int");

                    b.HasKey("UpgradeID");

                    b.ToTable("Upgrade");

                    b.HasData(
                        new
                        {
                            UpgradeID = 1,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i3 8130u",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 2,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i5 8250u",
                            UpgradePrice = 50
                        },
                        new
                        {
                            UpgradeID = 3,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i7 8550u",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 4,
                            UpgradeCategory = "Memory",
                            UpgradeName = "8 Gb",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 5,
                            UpgradeCategory = "Memory",
                            UpgradeName = "16 Gb",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 6,
                            UpgradeCategory = "Storage",
                            UpgradeName = "1 Tb HDD",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 7,
                            UpgradeCategory = "Storage",
                            UpgradeName = "128 Gb SSD",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 8,
                            UpgradeCategory = "Storage",
                            UpgradeName = "256 Gb SSD",
                            UpgradePrice = 60
                        },
                        new
                        {
                            UpgradeID = 9,
                            UpgradeCategory = "Storage",
                            UpgradeName = "512 Gb SSD",
                            UpgradePrice = 120
                        },
                        new
                        {
                            UpgradeID = 10,
                            UpgradeCategory = "Video",
                            UpgradeName = "Integrated",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 11,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Integrated",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 12,
                            UpgradeCategory = "OS",
                            UpgradeName = "None",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 13,
                            UpgradeCategory = "OS",
                            UpgradeName = "Ubuntu",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 14,
                            UpgradeCategory = "OS",
                            UpgradeName = "Win 10 Home",
                            UpgradePrice = 70
                        },
                        new
                        {
                            UpgradeID = 15,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i3 10100",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 16,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i5 10400",
                            UpgradePrice = 50
                        },
                        new
                        {
                            UpgradeID = 17,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i5 10600",
                            UpgradePrice = 80
                        },
                        new
                        {
                            UpgradeID = 18,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i7 10700",
                            UpgradePrice = 140
                        },
                        new
                        {
                            UpgradeID = 19,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i9 10900",
                            UpgradePrice = 200
                        },
                        new
                        {
                            UpgradeID = 20,
                            UpgradeCategory = "Memory",
                            UpgradeName = "8 Gb",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 21,
                            UpgradeCategory = "Memory",
                            UpgradeName = "16 Gb",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 22,
                            UpgradeCategory = "Memory",
                            UpgradeName = "32 Gb",
                            UpgradePrice = 200
                        },
                        new
                        {
                            UpgradeID = 23,
                            UpgradeCategory = "Storage",
                            UpgradeName = "1 Tb HDD",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 24,
                            UpgradeCategory = "Storage",
                            UpgradeName = "256 Gb SSD",
                            UpgradePrice = 60
                        },
                        new
                        {
                            UpgradeID = 25,
                            UpgradeCategory = "Storage",
                            UpgradeName = "512 Gb SSD",
                            UpgradePrice = 120
                        },
                        new
                        {
                            UpgradeID = 26,
                            UpgradeCategory = "Storage",
                            UpgradeName = "1 Tb SSD",
                            UpgradePrice = 240
                        },
                        new
                        {
                            UpgradeID = 27,
                            UpgradeCategory = "Video",
                            UpgradeName = "Integrated",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 28,
                            UpgradeCategory = "Video",
                            UpgradeName = "Quadro P620",
                            UpgradePrice = 300
                        },
                        new
                        {
                            UpgradeID = 29,
                            UpgradeCategory = "Video",
                            UpgradeName = "Quadro P1000",
                            UpgradePrice = 550
                        },
                        new
                        {
                            UpgradeID = 30,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Integrated",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 31,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Sound Blaster 1000",
                            UpgradePrice = 40
                        },
                        new
                        {
                            UpgradeID = 32,
                            UpgradeCategory = "OS",
                            UpgradeName = "None",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 33,
                            UpgradeCategory = "OS",
                            UpgradeName = "Ubuntu",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 34,
                            UpgradeCategory = "OS",
                            UpgradeName = "Win 10 Home",
                            UpgradePrice = 70
                        },
                        new
                        {
                            UpgradeID = 35,
                            UpgradeCategory = "OS",
                            UpgradeName = "Win 10 Pro",
                            UpgradePrice = 110
                        },
                        new
                        {
                            UpgradeID = 36,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i5 9400",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 37,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i5 10400F",
                            UpgradePrice = 75
                        },
                        new
                        {
                            UpgradeID = 38,
                            UpgradeCategory = "CPU",
                            UpgradeName = "i7 10700k",
                            UpgradePrice = 150
                        },
                        new
                        {
                            UpgradeID = 39,
                            UpgradeCategory = "Memory",
                            UpgradeName = "8 Gb",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 40,
                            UpgradeCategory = "Memory",
                            UpgradeName = "16 Gb",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 41,
                            UpgradeCategory = "Memory",
                            UpgradeName = "32 Gb",
                            UpgradePrice = 200
                        },
                        new
                        {
                            UpgradeID = 42,
                            UpgradeCategory = "Storage",
                            UpgradeName = "256 Gb SSD",
                            UpgradePrice = 60
                        },
                        new
                        {
                            UpgradeID = 43,
                            UpgradeCategory = "Storage",
                            UpgradeName = "512 Gb SSD",
                            UpgradePrice = 120
                        },
                        new
                        {
                            UpgradeID = 44,
                            UpgradeCategory = "Storage",
                            UpgradeName = "1 Tb SSD",
                            UpgradePrice = 240
                        },
                        new
                        {
                            UpgradeID = 45,
                            UpgradeCategory = "Video",
                            UpgradeName = "1650 Ti",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 46,
                            UpgradeCategory = "Video",
                            UpgradeName = "1660 Ti",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 47,
                            UpgradeCategory = "Video",
                            UpgradeName = "RTX 2060",
                            UpgradePrice = 150
                        },
                        new
                        {
                            UpgradeID = 48,
                            UpgradeCategory = "Video",
                            UpgradeName = "RTX 2070",
                            UpgradePrice = 300
                        },
                        new
                        {
                            UpgradeID = 49,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Integrated",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 50,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Sound Blaster 5000",
                            UpgradePrice = 40
                        },
                        new
                        {
                            UpgradeID = 51,
                            UpgradeCategory = "Sound",
                            UpgradeName = "Sound Blaster 10000",
                            UpgradePrice = 100
                        },
                        new
                        {
                            UpgradeID = 52,
                            UpgradeCategory = "OS",
                            UpgradeName = "Win 10 Home",
                            UpgradePrice = 0
                        },
                        new
                        {
                            UpgradeID = 53,
                            UpgradeCategory = "OS",
                            UpgradeName = "Win 10 Pro",
                            UpgradePrice = 40
                        });
                });

            modelBuilder.Entity("part4.Models.UpgradePJT", b =>
                {
                    b.Property<int>("UpgradePJTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("UpgradeID")
                        .HasColumnType("int");

                    b.HasKey("UpgradePJTID");

                    b.HasIndex("OrderID");

                    b.HasIndex("UpgradeID");

                    b.ToTable("UpgradePJT");

                    b.HasData(
                        new
                        {
                            UpgradePJTID = 1,
                            OrderID = 1,
                            UpgradeID = 1
                        },
                        new
                        {
                            UpgradePJTID = 2,
                            OrderID = 1,
                            UpgradeID = 4
                        },
                        new
                        {
                            UpgradePJTID = 3,
                            OrderID = 1,
                            UpgradeID = 6
                        },
                        new
                        {
                            UpgradePJTID = 4,
                            OrderID = 1,
                            UpgradeID = 10
                        },
                        new
                        {
                            UpgradePJTID = 5,
                            OrderID = 1,
                            UpgradeID = 11
                        },
                        new
                        {
                            UpgradePJTID = 6,
                            OrderID = 1,
                            UpgradeID = 12
                        },
                        new
                        {
                            UpgradePJTID = 7,
                            OrderID = 2,
                            UpgradeID = 15
                        },
                        new
                        {
                            UpgradePJTID = 8,
                            OrderID = 2,
                            UpgradeID = 20
                        },
                        new
                        {
                            UpgradePJTID = 9,
                            OrderID = 2,
                            UpgradeID = 23
                        },
                        new
                        {
                            UpgradePJTID = 10,
                            OrderID = 2,
                            UpgradeID = 27
                        },
                        new
                        {
                            UpgradePJTID = 11,
                            OrderID = 2,
                            UpgradeID = 30
                        },
                        new
                        {
                            UpgradePJTID = 12,
                            OrderID = 2,
                            UpgradeID = 32
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("part4.Models.Order", b =>
                {
                    b.HasOne("part4.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("part4.Models.UpgradePJT", b =>
                {
                    b.HasOne("part4.Models.Order", "Order")
                        .WithMany("UpgradePJT")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("part4.Models.Upgrade", "Upgrade")
                        .WithMany("UpgradePJT")
                        .HasForeignKey("UpgradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}