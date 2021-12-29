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
using DoorBoxApp.Models.ViewModels;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;

namespace DoorBoxApp.Controllers
{
    public class PackagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private static readonly HttpClient client = new HttpClient();
        private readonly IHostingEnvironment hostingEnvironment;


        public PackagesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }


        // GET: Packages
        public async Task<IActionResult> MerchantActivePackageIndex()
        {

            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();

            var applicationDbContext = _context.Packages.Include(p => p.DeliveryMan)
                .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.PickUpRequest.MerchantId == merchant.Id && m.Status < 6 && m.Status > 3).OrderBy(m => m.PickUpRequest.RequestDate);
            return View(await applicationDbContext.ToListAsync());
        }


        public async Task<IActionResult> MerchantAllPackageIndex(DateTime fromDate, DateTime toDate)
        {
            if (fromDate == default(DateTime))
            {
                fromDate = DateTime.Now.AddDays(-30);
            }
            if (toDate == default(DateTime))
            {
                toDate = DateTime.Now.AddHours(13).Date;
            }
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();
            var packages = await _context.Packages
                .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.PickUpRequest.MerchantId == merchant.Id && m.PickUpRequest.RequestDate >= fromDate && m.PickUpRequest.RequestDate <= toDate && m.Status > 3).OrderBy(m => m.PickUpRequest.RequestDate).ToListAsync();


            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }
        [HttpPost]
        public IActionResult MerchantAllPackageIndex(FromDateToDateViewModel datesVM)
        {

            return RedirectToAction("MerchantAllPackageIndex", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }



        public async Task<IActionResult> AdminAllPackageIndex(DateTime fromDate, DateTime toDate)
        {
            if (fromDate == default(DateTime))
            {
                fromDate = DateTime.Now.AddDays(-30);
            }
            if (toDate == default(DateTime))
            {
                toDate = DateTime.Now.AddHours(13);
            }
            var packages = await _context.Packages
                 .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.Status != 0 && m.PickUpRequest.RequestDate >= fromDate && m.PickUpRequest.RequestDate <= toDate && m.Status > 3).OrderBy(m => m.PickUpRequest.RequestDate).ToListAsync();
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }
        [HttpPost]
        public IActionResult AdminAllPackageIndex(FromDateToDateViewModel datesVM)
        {

            return RedirectToAction("AdminAllPackageIndex", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }



        public async Task<IActionResult> AdminActivePackageIndex()
        {
            var applicationDbContext = _context.Packages
                .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.Status != 0 && m.Status < 6 && m.Status > 3).OrderBy(m => m.PickUpRequest.RequestDate);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> GeneratedBill(int id)
        {
            var package = await _context.Packages
                .Include(p => p.DeliveryMan)
                .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.LocationFrom).Include(p => p.LocationTo).Include(p => p.PickUpRequest.Merchant).Include(p => p.PackageCatagory).Where(m => m.Id == id).FirstOrDefaultAsync();

            if (package.Status < 4)
            {
                return NotFound();
            }
            else
            {
                string inWords = package.NumberToWords((double)package.Price + (double)package.ProductPrice);
                ViewData["InWords"] = inWords;
                return View(package);
            }

        }
        public async Task<IActionResult> CreatePackages(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageReq = await _context.PickUpRequests
                .Include(m => m.LocationFrom)
                .Include(m => m.Merchant)
                .Include(m => m.Packages)
                .ThenInclude(m => m.LocationTo)
                 .Include(m => m.Packages)
                .ThenInclude(m => m.PackageCatagory)
                .Where(m => m.Id == id).FirstOrDefaultAsync();
            if (packageReq == null)
            {
                return NotFound();
            }
            ViewData["Catagories"] = await _context.PackageCatagories.Where(m => m.Status == 1).ToListAsync();
            ViewData["Locations"] = await _context.Locations.Where(m => m.Status == 1).ToListAsync();
            return View(packageReq);
        }



        [HttpPost]
        public async Task<JsonResult> AddPackage(int catagoryId, int locationToId, int subLocationToId, int packageTypeId, string clientName, string address, string phoneNo, string details, double weight, double productPrice, double delivaryPrice, string remarks, double sellingPrice, int pickUpRequestId)

        {
            var locationTo = await _context.Locations.FirstOrDefaultAsync(m => m.Id == locationToId);

            Package package = new Package();
            package.PackageCatagoryId = catagoryId;
            package.LocationToId = locationToId;

            if (subLocationToId != 0)
            {
                package.SubLocationId = subLocationToId;
            }
            if (packageTypeId != 0)
            {
                package.PackageTypeId = packageTypeId;
            }


            package.ClientName = clientName;
            package.Address = address;
            package.PhoneNumber = phoneNo;
            package.Details = details;
            package.Weight = weight;
            if (locationTo.IsOutOfTown && productPrice != 0)
            {
                productPrice = productPrice + (productPrice * .01);
            }
            package.ProductPrice = productPrice;
            package.Price = delivaryPrice;
            package.Remarks = remarks;
            package.SellingPrice = sellingPrice;
            package.Status = 1;
            package.PickUpRequestId = pickUpRequestId;
            _context.Add(package);
            int res = await _context.SaveChangesAsync();
            if (res == 1)
            {

                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }

        [HttpPost]
        public async Task<JsonResult> FinalizeRequest(int pickUpRequestId)
        {
            var request = await _context.PickUpRequests.Include(m => m.Packages).Where(m => m.Id == pickUpRequestId).FirstOrDefaultAsync();


            if (request != null)
            {
                if (request.Status == 0)
                {
                    if (request.Packages.Count != 0)
                    {
                        foreach (var package in request.Packages)
                        {
                            Random rnd = new Random();
                            package.Status = 1;
                            //package.TrackingNumber = "TR" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + rnd.Next(1, 256).ToString();
                            _context.Update(package);
                            await _context.SaveChangesAsync();
                        }
                        request.Status = 2;
                        request.TotalPackageNumber = request.Packages.Count;
                        _context.Update(request);
                        await _context.SaveChangesAsync();


                    }

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public async Task<JsonResult> ReceiveFinalize(int pickUpRequestId)
        {
            var request = await _context.PickUpRequests.Include(m => m.Packages).Where(m => m.Id == pickUpRequestId).FirstOrDefaultAsync();


            if (request != null)
            {
                if (request.Status == 4)
                {
                    if (request.Packages.Count != 0)
                    {
                        foreach (var package in request.Packages)
                        {
                            Random rnd = new Random();
                            package.Status = 2;
                            package.TrackingNumber = "TR" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + rnd.Next(1, 256).ToString();
                            Random generator = new Random();
                            String r = generator.Next(0, 1000000).ToString("D6");
                            package.OTP = r;
                            _context.Update(package);
                            await _context.SaveChangesAsync();
                        }

                        request.Status = 5;
                        _context.Update(request);
                        await _context.SaveChangesAsync();


                    }

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                return Json(false);
            }
        }



        public async Task<IActionResult> ShippedByAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (package == null)
            {
                return NotFound();
            }
            else
            {
                package.ShippingDate = DateTime.Now;
                package.Status = 5;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AdminActivePackageIndex));
            }

        }


        public async Task<IActionResult> PartiallyDeleveredByAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (package == null)
            {
                return NotFound();
            }
            else
            {
                package.Status = 7;
                package.DeliveryDate = DateTime.Now;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AdminActivePackageIndex));
            }

        }



        private bool PackageExists(int id)
        {
            return _context.Packages.Any(e => e.Id == id);
        }

        public async Task<JsonResult> AddPayment(int packageId, double payAmount)
        {
            if (packageId == 0)
            {
                return Json(false);
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == packageId);
            if (package == null)
            {
                return Json(false);
            }
            else
            {
                if (package.PaidAmount == null)
                {
                    package.PaidAmount = 0;
                }

                package.PaidAmount += payAmount;
                _context.Update(package);
                int success = await _context.SaveChangesAsync();
                if (success == 1)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }

        }
        [HttpPost]
        public async Task<JsonResult> GetPackageByTrackingNumber(string trackingNumber)
        {
            if (trackingNumber == "" || trackingNumber == null)
            {

                return Json(false);
            }
            else
            {
                var package = await _context.Packages
                    .Include(m => m.PickUpRequest)
                    .Include(m => m.PickUpRequest.Merchant)
                    .Where(m => m.TrackingNumber == trackingNumber).FirstOrDefaultAsync();
                if (package != null)
                {
                    PublicViewModel publicViewModel = new PublicViewModel();
                    publicViewModel.Status = package.Status;
                    publicViewModel.Merchant = package.PickUpRequest.Merchant.Name;
                    publicViewModel.Client = package.ClientName;
                    publicViewModel.Address = package.Address;
                    publicViewModel.Price = (double)package.ProductPrice;
                    return Json(publicViewModel);
                }
                else
                {
                    return Json(false);
                }
            }

        }
        [HttpPost]
        public async Task<JsonResult> GetCatagory(int catagoryId)
        {
            var catagory = await _context.PackageCatagories.Where(m => m.Id == catagoryId).FirstOrDefaultAsync();
            if (catagory != null)
            {
                return Json(catagory);
            }
            else
            {
                return Json(false);
            }
        }





        [HttpPost]
        public async Task<JsonResult> GetPackageDetails(int id)
        {
            var packageReq = await _context.PickUpRequests.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (packageReq != null)
            {
                return Json(packageReq);
            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public async Task<JsonResult> AddDeliveryManPickUp(int id, int pickedUpPackageNumber)
        {
            var pickUpRequest = await _context.PickUpRequests.Where(m => m.Id == id).FirstOrDefaultAsync();


            if (pickUpRequest != null)
            {
                pickUpRequest.PickedUpPackageNumber = pickedUpPackageNumber;
                pickUpRequest.Status = 4;
                pickUpRequest.PickUpDate = DateTime.Now;
                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();

                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }



        [HttpPost]
        public async Task<JsonResult> GetLocationTo(int locationToId)
        {
            var location = await _context.Locations.Where(m => m.Id == locationToId).FirstOrDefaultAsync();
            if (location != null)
            {
                return Json(location);
            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetSubLocationTo(int subLocationId)
        {
            var subLocation = await _context.SubLocations.Where(m => m.Id == subLocationId).FirstOrDefaultAsync();
            if (subLocation != null)
            {
                return Json(subLocation);
            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetPackageType(int packageTypeId)
        {
            var packageType = await _context.PackageTypes.Where(m => m.Id == packageTypeId).FirstOrDefaultAsync();
            if (packageType != null)
            {
                return Json(packageType);
            }
            else
            {
                return Json(false);
            }
        }


        [HttpPost]
        public async Task<JsonResult> UpdateEmptyPackage(int catagoryId, int locationToId, int subLocationToId, int packageTypeId, double weight, double sellingPrice, int packageId)

        {


            Package package = await _context.Packages.Include(m => m.PickUpRequest).Where(m => m.Id == packageId).FirstOrDefaultAsync();
            package.PackageCatagoryId = catagoryId;
            package.LocationToId = locationToId;
            if (subLocationToId != 0)
            {
                package.SubLocationId = subLocationToId;
            }
            if (packageTypeId != 0)
            {
                package.PackageTypeId = packageTypeId;
            }
            package.Weight = weight;
            package.SellingPrice = sellingPrice;
            package.Status = 1;


            if (catagoryId != 0 && locationToId != 0 && weight != 0)
            {
                TarrifPriceViewModel tarrifPriceViewModel = Tarrif.GetDesiredTarrif(package.PickUpRequest.MerchantId, catagoryId, package.PickUpRequest.LocationFromId, locationToId, weight, _context);
                if (tarrifPriceViewModel != null)
                {
                    package.Price = tarrifPriceViewModel.TotalPrice;
                }
                else
                {
                    package.Price = 0;
                }



            }

            _context.Update(package);
            int res = await _context.SaveChangesAsync();
            if (res == 1)
            {

                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }
        [HttpPost]
        public async Task<JsonResult> UpdateWithDeliveryPrice(int catagoryId, int locationToId, int subLocationToId, int packageTypeId, double weight, int packageId, double delivaryPrice)

        {


            Package package = await _context.Packages.Include(m => m.PickUpRequest).Where(m => m.Id == packageId).FirstOrDefaultAsync();
            package.PackageCatagoryId = catagoryId;
            package.LocationToId = locationToId;
            package.Weight = weight;
            package.Price = delivaryPrice;
            package.Status = 1;
            if (subLocationToId != 0)
            {
                package.SubLocationId = subLocationToId;
            }
            if (packageTypeId != 0)
            {
                package.PackageTypeId = packageTypeId;
            }
            _context.Update(package);
            int res = await _context.SaveChangesAsync();
            if (res == 1)
            {

                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }

        [HttpPost]
        public async Task<JsonResult> DeletePackage(int packageId)

        {
            Package package = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (package == null)
            {
                return Json(false);
            }
            _context.Remove(package);
            int res = await _context.SaveChangesAsync();
            if (res == 1)
            {

                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }






        [HttpPost]
        public async Task<JsonResult> SavePickUpPaymentFixed(int pickupRequestId, double paidAmount)
        {
            var pickRequest = await _context.PickUpRequests.Where(m => m.Id == pickupRequestId).FirstOrDefaultAsync();
            if (pickRequest != null)
            {


                pickRequest.PickupDeliveryManPaid = true;
                pickRequest.PaidForPickUp = paidAmount;
                _context.Update(pickRequest);
                int res = await _context.SaveChangesAsync();
                if (res == 1)
                {

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public async Task<JsonResult> SavePickUpPayment(int packageId, double paidAmount)
        {
            var package = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (package != null)
            {


                package.PickUpDeliveryManPaid = true;
                package.PaidForPickUp = paidAmount;
                _context.Update(package);
                int res = await _context.SaveChangesAsync();
                if (res == 1)
                {

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
            else
            {
                return Json(false);
            }
        }


        [HttpPost]
        public async Task<JsonResult> SaveDeliveryPayment(int packageId, double paidAmount)
        {
            var package = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (package != null)
            {


                package.DeliveryDeliveryManPaid = true;
                package.PaidForDelivery = paidAmount;
                _context.Update(package);
                int res = await _context.SaveChangesAsync();
                if (res == 1)
                {

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> SavePackagePayment(int packageId, double paidAmount)
        {
            var package = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (package != null)
            {
                double totalPaid = 0;

                if (package.PaidAmount != null)
                {
                    totalPaid = (double)(package.PaidAmount) + paidAmount;
                }
                else
                {
                    totalPaid = paidAmount;
                }

                if (totalPaid >= package.ProductPrice - package.Price)
                {
                    package.MerchantPaid = true;
                }
                if (totalPaid == 0 && package.ProductPrice == package.Price)
                {
                    package.MerchantPaid = true;
                }

                package.PaidAmount = totalPaid;
                _context.Update(package);
                int res = await _context.SaveChangesAsync();
                if (res == 1)
                {

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> DelivrByDM(string otp, int packageId)
        {
            var package = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (package != null)
            {

                if (package.OTP == otp)
                {
                    package.Status = 5;
                    package.DeliveryDate = DateTime.Now;
                    _context.Update(package);
                    int res1 = await _context.SaveChangesAsync();

                    if (res1 == 1)
                    {

                        return Json(true);
                    }
                    else
                    {
                        return Json(false);
                    }
                }
                else
                {
                    return Json(false);
                }

            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public async Task<JsonResult> ReturnToMerchant(string otp, int packageId)
        {
            if (packageId == 0)
            {
                return Json(false);
            }
            var pack = await _context.Packages.Where(m => m.Id == packageId).FirstOrDefaultAsync();
            if (pack == null)
            {
                return Json(false);
            }
            if (pack.OTP == otp)
            {
                pack.Status = 14;
                pack.DeliveryDate = DateTime.Now;
                _context.Update(pack);
                int res1 = await _context.SaveChangesAsync();

                if (res1 == 1)
                {

                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                return Json(false);
            }

        }
        [HttpPost]
        public async Task<JsonResult> GetCatagoryType(int catagoryTypeId)
        {
            var catagoryType = await _context.CatagoryTypes.Where(m => m.Id == catagoryTypeId).FirstOrDefaultAsync();
            if (catagoryType != null)
            {
                return Json(catagoryType);
            }
            else
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetCatagoryByType(int catagoryTypeId)
        {
            var catagories = await _context.PackageCatagories.Where(m => m.CatagoryTypeId == catagoryTypeId).ToListAsync();
            if (catagories != null)
            {
                return Json(catagories);
            }
            else
            {
                return Json(false);
            }
        }
    }
}

