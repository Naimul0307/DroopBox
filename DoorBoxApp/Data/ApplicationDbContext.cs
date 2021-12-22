using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Models.Common.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DoorBoxApp.Models;

namespace DoorBoxApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
           
            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = "a682b56a-6135-4111-a0k0-bdec547e3waz", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "da9a3b0e-8b6f-8529-71d0-4fd255e23f15", CreatedOn = Convert.ToDateTime("2020-01-01"), Description = "Has All Permissions" },
                new ApplicationRole { Id = "d925b59b-7456-1442-d0n0-bdec765e3awv", Name = "Merchant", NormalizedName = "MERCHANT", ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f17", CreatedOn = Convert.ToDateTime("2020-01-01"), Description = "Has Minimum Permissions" },
                new ApplicationRole { Id = "d925b59b-7456-1442-d0n0-bdec765e3awx", Name = "DeliveryMan", NormalizedName = "DELIVERYMAN", ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f18", CreatedOn = Convert.ToDateTime("2020-01-01"), Description = "Has Minimum Permissions" },
               new ApplicationRole { Id = "d925b59b-7456-1442-d0n0-bdec765e3awy", Name = "Finance", NormalizedName = "FINANCE", ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f19", CreatedOn = Convert.ToDateTime("2020-01-01"), Description = "Has Minimum Permissions" }
              
             );
            modelBuilder.Entity<UserType>().HasData(
              new UserType { Id = 1, Name = "Admin" },
              new UserType { Id = 2, Name = "Merchant" },
              new UserType { Id = 3, Name = "DeliveryMan" },
              new UserType { Id = 4, Name = "Finance" }
           );
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser() { Id = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507", UserName = "Admin", NormalizedUserName = "ADMIN", Email = "test@mail.com", NormalizedEmail = "TEST@MAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==", SecurityStamp = "5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHJ", ConcurrencyStamp = "26d21881-0a3a-44ab-aa4d-10664ace1e2d", UserTypeId=1 , Status=1},
               new ApplicationUser() { Id = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb508", UserName = "Finance", NormalizedUserName = "FINANCE", Email = "test@mail.com", NormalizedEmail = "TEST@MAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==", SecurityStamp = "5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHK", ConcurrencyStamp = "26d21881-0a3a-44ab-aa4d-10664ace1e2e", UserTypeId=4 , Status=1}
               
                
             );
            modelBuilder.Entity<CatagoryType>().HasData(
           new CatagoryType { Id = 1, Name = "Parcel" },
           new CatagoryType { Id = 2, Name = "Food" }
        );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { UserId = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507", RoleId = "a682b56a-6135-4111-a0k0-bdec547e3waz" },
                 new IdentityUserRole<string>() { UserId = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb508", RoleId = "d925b59b-7456-1442-d0n0-bdec765e3awy" }
             );
            
        }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PickUpRequest> PickUpRequests { get; set; }
        public DbSet<DeliveryMan> DeliveryMans { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<PackageCatagory> PackageCatagories { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Tarrif> Tarrifs { get; set; }
        public DbSet<MerchantTarrif> MerchantTarrifs { get; set; }
        public DbSet<SubLocation> SubLocations { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<CatagoryType> CatagoryTypes { get; set; }




    }
}
