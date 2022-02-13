using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using DoorBoxApp.Models.Common.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using DoorBoxApp.Models.ViewModels;

namespace DoorBoxApp.Controllers
{
    public class MerchantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;
        public MerchantsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActiveIndex()
        {
            var applicationDbContext = _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 1).OrderBy(m => m.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingIndex()
        {
            var applicationDbContext = _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 0).OrderBy(m => m.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DisabledIndex()
        {
            var applicationDbContext = _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 2).OrderBy(m => m.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchant = await _context.Merchants.Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchant == null)
            {
                return NotFound();
            }
            else
            {
                merchant.ApplicationUser.Status = 1;
                _context.Update(merchant);
                int count = await _context.SaveChangesAsync();
                if (count == 2)
                {
                    var user = await _userManager.FindByIdAsync(merchant.ApplicationUserId);
                    await _userManager.AddToRoleAsync(user, "Merchant");

                }
                return RedirectToAction(nameof(ActiveIndex));
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Disable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchant = await _context.Merchants.Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (merchant == null)
            {
                return NotFound();
            }
            else
            {
                var user = await _context.Users.Where(m => m.Id == merchant.ApplicationUserId).FirstOrDefaultAsync();
                merchant.ApplicationUser.Status = 2;
                _context.Update(merchant);
                int count = await _context.SaveChangesAsync();
                if (count == 1)
                {
                    var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                    await _userManager.RemoveFromRoleAsync(loggedInUser, "Merchant");
                }
                return RedirectToAction(nameof(DisabledIndex));
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Enable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchant = await _context.Merchants.Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);


            if (merchant == null)
            {
                return NotFound();
            }
            else
            {
                var user = await _context.Users.Where(m => m.Id == merchant.ApplicationUserId).FirstOrDefaultAsync();
                merchant.ApplicationUser.Status = 1;
                _context.Update(merchant);
                await _context.SaveChangesAsync();
                await _userManager.AddToRoleAsync(user, "Merchant");

                return RedirectToAction(nameof(ActiveIndex));
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminPackagePayment()
        {
            var packagers = await _context.Packages.Where(m => m.Status == 5 || m.Status == 13 || m.Status == 14)
                .Include(m => m.SubLocation)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.PickUpRequest.LocationFrom)
                .Include(m => m.PickUpRequest.PickUpDeliveryMan)
                .OrderByDescending(m => m.Id)
                .OrderBy(m => m.Id)
                .ToListAsync();
            return View(packagers);
        }

        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> PackagePayment()
        {
            var packagers = await _context.Packages.Where(m => m.Status == 5 || m.Status == 13 || m.Status == 14)
                .Include(m => m.SubLocation)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.PickUpRequest.LocationFrom)
                .Include(m => m.PickUpRequest.PickUpDeliveryMan)
                .OrderByDescending(m => m.Id)
                .OrderBy(m => m.Id)
                .ToListAsync();
            return View(packagers);
        }
        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> PackagePaymentMerchant(int merchantId)
        {
            var packagers = await _context.Packages.Where(m => m.Status == 5 || m.Status == 13 || m.Status == 14)
                .Include(m => m.SubLocation)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.PickUpRequest.LocationFrom)
                .Include(m => m.PickUpRequest.PickUpDeliveryMan)
                .OrderByDescending(m => m.Id)
                .Where(m => m.PickUpRequest.MerchantId == merchantId)
                .ToListAsync();

            return View(packagers);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MerchantProfile(int id)
        {
            var merhcant = await _context.Merchants.Where(m => m.Id == id)
                .Include(m => m.ApplicationUser)
                .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.LocationFrom)
                 .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.LocationTo)
                 .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.PackageCatagory)
                .FirstOrDefaultAsync();


            return View(merhcant);
        }

        [Authorize(Roles = "Merchant")]
        public async Task<IActionResult> MerchantProfileMerchant()
        {

            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchantLoggedIn = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();

            var merhcant = await _context.Merchants.Where(m => m.Id == merchantLoggedIn.Id)
                .Include(m => m.ApplicationUser)
                .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.LocationFrom)
                 .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.LocationTo)
                 .Include(m => m.MerchantTarrifs)
                .ThenInclude(m => m.PackageCatagory)
                .FirstOrDefaultAsync();


            return View(merhcant);
        }
        public async Task<IActionResult> Edit(string userId)
        {
            if (userId == null)
            {
                return NotFound();
            }

            var merchant = await _context.Merchants
                .Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Id == userId).FirstOrDefaultAsync();
            if (merchant == null)
            {
                return NotFound();
            }
            return View(merchant);
        }

        // POST: SubLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Merchant merchant)
        {


            var tempMerchant = await _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.Id == merchant.Id).FirstOrDefaultAsync();

            tempMerchant.Address = merchant.Address;
            tempMerchant.ApplicationUser.Email = merchant.ApplicationUser.Email;
            tempMerchant.ApplicationUser.PhoneNumber = merchant.ApplicationUser.PhoneNumber;
            tempMerchant.ApplicationUser.PaymentMethod = merchant.ApplicationUser.PaymentMethod;
            tempMerchant.ApplicationUser.BankCustomerName = merchant.ApplicationUser.BankCustomerName;
            tempMerchant.ApplicationUser.BankName = merchant.ApplicationUser.BankName;
            tempMerchant.ApplicationUser.BranchName = merchant.ApplicationUser.BranchName;
            tempMerchant.ApplicationUser.AccountNumber = merchant.ApplicationUser.AccountNumber;
            tempMerchant.ApplicationUser.RoutingNumber = merchant.ApplicationUser.RoutingNumber;
            tempMerchant.ApplicationUser.MobileBankingNumber = merchant.ApplicationUser.MobileBankingNumber;
            _context.Update(tempMerchant);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> AdminMerchantReportIndex()
        {
            var applicationDbContext = _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 1).OrderBy(m => m.Name);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> AdminMerchantReport(string userId, DateTime fromDate, DateTime toDate)
        {
            if (fromDate == default(DateTime))
            {
                fromDate = DateTime.Now.AddDays(-30);
            }
            if (toDate == default(DateTime))
            {
                toDate = DateTime.Now.Date;
                toDate = toDate.AddDays(1).AddMinutes(-1);
            }
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var deliveryMan = await _context.DeliveryMans.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();
            if (userId == "" || userId == null)
            {
                var packages = await _context.Packages
                .Include(p => p.PickUpRequest)
               .Include(p => p.PickUpRequest.PickUpDeliveryMan)
               .Include(p => p.PickUpRequest.Merchant)
               .Include(p => p.PickUpRequest.LocationFrom)
               .Include(p => p.LocationTo)
               .Include(p => p.SubLocation)
               .Include(p => p.PackageType)
               .Include(p => p.DeliveryMan)
               .Include(p => p.PackageCatagory)
               .Where(m => m.Status != 0 && m.AssignDate >= fromDate && m.AssignDate <= toDate && m.Status != 0).OrderBy(m => m.DeliveryDate).ToListAsync();
                ViewData["Packages"] = packages;
            }
            else
            {
                var packages = await _context.Packages
                 .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.SubLocation)
                .Include(p => p.PackageType)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.PickUpRequest.Merchant.ApplicationUserId == userId && m.Status != 0 && m.AssignDate >= fromDate && m.AssignDate <= toDate && m.Status != 0).OrderBy(m => m.DeliveryDate).ToListAsync();
                ViewData["Packages"] = packages;

                ViewData["Packages"] = packages;
            }
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            ViewData["UserId"] = userId;
            return View();
        }
        [HttpPost]
        public IActionResult AdminMerchantReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("AdminMerchantReport", new { userId = datesVM.UserId, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }
    }
}

