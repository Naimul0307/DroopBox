﻿// <auto-generated />
using System;
using DoorBoxApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoorBoxApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211015202558_DeliveryEmergencyContact")]
    partial class DeliveryEmergencyContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoorBoxApp.Models.CatagoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CatagoryTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Parcel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Food"
                        });
                });

            modelBuilder.Entity("DoorBoxApp.Models.Common.Authentication.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "a682b56a-6135-4111-a0k0-bdec547e3waz",
                            ConcurrencyStamp = "da9a3b0e-8b6f-8529-71d0-4fd255e23f15",
                            CreatedOn = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Has All Permissions",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d925b59b-7456-1442-d0n0-bdec765e3awv",
                            ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f17",
                            CreatedOn = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Has Minimum Permissions",
                            Name = "Merchant",
                            NormalizedName = "MERCHANT"
                        },
                        new
                        {
                            Id = "d925b59b-7456-1442-d0n0-bdec765e3awx",
                            ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f18",
                            CreatedOn = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Has Minimum Permissions",
                            Name = "DeliveryMan",
                            NormalizedName = "DELIVERYMAN"
                        },
                        new
                        {
                            Id = "d925b59b-7456-1442-d0n0-bdec765e3awy",
                            ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f19",
                            CreatedOn = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Has Minimum Permissions",
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("DoorBoxApp.Models.Common.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("BankCustomerName");

                    b.Property<string>("BankName");

                    b.Property<string>("BranchName");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MobileBankingNumber");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OTPUser");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PaymentMethod");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("RoutingNumber");

                    b.Property<string>("SecurityStamp");

                    b.Property<byte>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "26d21881-0a3a-44ab-aa4d-10664ace1e2d",
                            Email = "test@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHJ",
                            Status = (byte)1,
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserTypeId = 1
                        },
                        new
                        {
                            Id = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb508",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "26d21881-0a3a-44ab-aa4d-10664ace1e2e",
                            Email = "test@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@MAIL.COM",
                            NormalizedUserName = "FINANCE",
                            PasswordHash = "AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHK",
                            Status = (byte)1,
                            TwoFactorEnabled = false,
                            UserName = "Finance",
                            UserTypeId = 4
                        });
                });

            modelBuilder.Entity("DoorBoxApp.Models.Common.Authentication.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Merchant"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DeliveryMan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Finance"
                        });
                });

            modelBuilder.Entity("DoorBoxApp.Models.DeliveryMan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("DeliveryManIdNo");

                    b.Property<double>("DeliveryRate");

                    b.Property<string>("Email");

                    b.Property<string>("EmergencyVontact");

                    b.Property<string>("NIDNumber");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<double>("PickUpRate");

                    b.Property<double>("Salary");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("DeliveryMans");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsOutOfTown");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("MerchantIdNo");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("DoorBoxApp.Models.MerchantTarrif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FixedAmountFirstKG");

                    b.Property<double>("IncrementPerKG");

                    b.Property<int>("LocationFromId");

                    b.Property<int>("LocationToId");

                    b.Property<int>("MerchantId");

                    b.Property<int>("PackageCatagoryId");

                    b.Property<int>("Status");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("LocationFromId");

                    b.HasIndex("LocationToId");

                    b.HasIndex("MerchantId");

                    b.HasIndex("PackageCatagoryId");

                    b.ToTable("MerchantTarrifs");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("AssignDate");

                    b.Property<string>("ClientName");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<bool>("DeliveryDeliveryManPaid");

                    b.Property<int?>("DeliveryManId");

                    b.Property<string>("Details");

                    b.Property<string>("Dimension");

                    b.Property<int?>("LocationToId");

                    b.Property<int?>("MerchantId");

                    b.Property<bool>("MerchantPaid");

                    b.Property<string>("OTP");

                    b.Property<int?>("PackageCatagoryId");

                    b.Property<int?>("PackageTypeId");

                    b.Property<double?>("PaidAmount");

                    b.Property<double?>("PaidForDelivery");

                    b.Property<double?>("PaidForPickUp");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PickUpDeliveryManPaid");

                    b.Property<int>("PickUpRequestId");

                    b.Property<double?>("Price");

                    b.Property<double?>("ProductPrice");

                    b.Property<string>("Remarks");

                    b.Property<double?>("SellingPrice");

                    b.Property<DateTime>("ShippingDate");

                    b.Property<byte>("Status");

                    b.Property<int?>("SubLocationId");

                    b.Property<string>("TrackingNumber");

                    b.Property<int?>("VendorId");

                    b.Property<double?>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryManId");

                    b.HasIndex("LocationToId");

                    b.HasIndex("MerchantId");

                    b.HasIndex("PackageCatagoryId");

                    b.HasIndex("PackageTypeId");

                    b.HasIndex("PickUpRequestId");

                    b.HasIndex("SubLocationId");

                    b.HasIndex("VendorId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("DoorBoxApp.Models.PackageCatagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatagoryTypeId");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryTypeId");

                    b.ToTable("PackageCatagories");
                });

            modelBuilder.Entity("DoorBoxApp.Models.PackageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("DoorBoxApp.Models.PickUpRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details");

                    b.Property<int>("LocationFromId");

                    b.Property<int>("MerchantId");

                    b.Property<double?>("PaidForPickUp");

                    b.Property<DateTime>("PickUpDate");

                    b.Property<int?>("PickUpDeliveryManId");

                    b.Property<int>("PickedUpPackageNumber");

                    b.Property<string>("PickupAddress");

                    b.Property<bool>("PickupDeliveryManPaid");

                    b.Property<DateTime>("RequestDate");

                    b.Property<string>("RequestId");

                    b.Property<int>("Status");

                    b.Property<int>("TotalPackageNumber");

                    b.HasKey("Id");

                    b.HasIndex("LocationFromId");

                    b.HasIndex("MerchantId");

                    b.HasIndex("PickUpDeliveryManId");

                    b.ToTable("PickUpRequests");
                });

            modelBuilder.Entity("DoorBoxApp.Models.SubLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("SubLocations");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Tarrif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FixedAmountFirstKG");

                    b.Property<double>("IncrementPerKG");

                    b.Property<int>("LocationFromId");

                    b.Property<int>("LocationToId");

                    b.Property<int>("PackageCatagoryId");

                    b.Property<int>("Status");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("LocationFromId");

                    b.HasIndex("LocationToId");

                    b.HasIndex("PackageCatagoryId");

                    b.ToTable("Tarrifs");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507",
                            RoleId = "a682b56a-6135-4111-a0k0-bdec547e3waz"
                        },
                        new
                        {
                            UserId = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb508",
                            RoleId = "d925b59b-7456-1442-d0n0-bdec765e3awy"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Common.Authentication.ApplicationUser", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.UserType", "UserType")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoorBoxApp.Models.DeliveryMan", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("DoorBoxApp.Models.Merchant", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("DoorBoxApp.Models.MerchantTarrif", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Location", "LocationFrom")
                        .WithMany()
                        .HasForeignKey("LocationFromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.Location", "LocationTo")
                        .WithMany()
                        .HasForeignKey("LocationToId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.Merchant", "Merchant")
                        .WithMany("MerchantTarrifs")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.PackageCatagory", "PackageCatagory")
                        .WithMany()
                        .HasForeignKey("PackageCatagoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoorBoxApp.Models.Package", b =>
                {
                    b.HasOne("DoorBoxApp.Models.DeliveryMan", "DeliveryMan")
                        .WithMany()
                        .HasForeignKey("DeliveryManId");

                    b.HasOne("DoorBoxApp.Models.Location", "LocationTo")
                        .WithMany()
                        .HasForeignKey("LocationToId");

                    b.HasOne("DoorBoxApp.Models.Merchant")
                        .WithMany("Packages")
                        .HasForeignKey("MerchantId");

                    b.HasOne("DoorBoxApp.Models.PackageCatagory", "PackageCatagory")
                        .WithMany()
                        .HasForeignKey("PackageCatagoryId");

                    b.HasOne("DoorBoxApp.Models.PackageType", "PackageType")
                        .WithMany()
                        .HasForeignKey("PackageTypeId");

                    b.HasOne("DoorBoxApp.Models.PickUpRequest", "PickUpRequest")
                        .WithMany("Packages")
                        .HasForeignKey("PickUpRequestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.SubLocation", "SubLocation")
                        .WithMany()
                        .HasForeignKey("SubLocationId");

                    b.HasOne("DoorBoxApp.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("DoorBoxApp.Models.PackageCatagory", b =>
                {
                    b.HasOne("DoorBoxApp.Models.CatagoryType", "CatagoryType")
                        .WithMany()
                        .HasForeignKey("CatagoryTypeId");
                });

            modelBuilder.Entity("DoorBoxApp.Models.PickUpRequest", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Location", "LocationFrom")
                        .WithMany()
                        .HasForeignKey("LocationFromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.Merchant", "Merchant")
                        .WithMany()
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.DeliveryMan", "PickUpDeliveryMan")
                        .WithMany()
                        .HasForeignKey("PickUpDeliveryManId");
                });

            modelBuilder.Entity("DoorBoxApp.Models.SubLocation", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoorBoxApp.Models.Tarrif", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Location", "LocationFrom")
                        .WithMany()
                        .HasForeignKey("LocationFromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.Location", "LocationTo")
                        .WithMany()
                        .HasForeignKey("LocationToId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.PackageCatagory", "PackageCatagory")
                        .WithMany()
                        .HasForeignKey("PackageCatagoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DoorBoxApp.Models.Common.Authentication.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
