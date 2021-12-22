using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using Microsoft.AspNetCore.Identity;
using DoorBoxApp.Models.Common.Authentication;
using System.IO;
using Microsoft.AspNetCore.Http;
using DoorBoxApp.Models.Common.File;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Data;
using ExcelDataReader;
using DoorBoxApp.Models.ViewModels;

namespace DoorBoxApp.Controllers
{
    public class PickUpRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private static readonly HttpClient client = new HttpClient();
        private readonly IHostingEnvironment hostingEnvironment;


        public PickUpRequestsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }



        //GET: PickUpRequests
        public async Task<IActionResult> MarchantIndex()
        {
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();
            var applicationDbContext = _context.PickUpRequests
                .Include(p => p.LocationFrom)
                .Include(p => p.Merchant)
                .Include(p => p.PickUpDeliveryMan).Where(m => m.MerchantId == merchant.Id).OrderByDescending(m => m.Id); ;
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> DeliveryManIndex()
        {
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var deliveryMan = await _context.DeliveryMans.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();
            var applicationDbContext = _context.PickUpRequests
                .Include(p => p.LocationFrom)
                .Include(p => p.Merchant)
                .Include(p => p.Merchant.ApplicationUser)
                .Include(p => p.Packages)
                .Include(p => p.PickUpDeliveryMan).Where(m => m.PickUpDeliveryManId == deliveryMan.Id && (m.Status == 3 || m.Status == 4));
            return View(await applicationDbContext.ToListAsync());
        }



        public async Task<IActionResult> AdminIndex()
        {
            var applicationDbContext = _context.PickUpRequests.Include(p => p.LocationFrom).Include(p => p.Merchant).Include(p => p.PickUpDeliveryMan).Where(m => m.Status > 1).OrderByDescending(m=>m.Id);
            return View(await applicationDbContext.ToListAsync());
        }




        //GET: PickUpRequests/Create
        public IActionResult Create()
        {
            ViewData["LocationFromId"] = new SelectList(_context.Locations.Where(m => m.Status == 1), "Id", "Name");
            return View();
        }

        // POST: PickUpRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PickUpRequest pickUpRequest)
        {
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();

            pickUpRequest.Status = 0;
            pickUpRequest.MerchantId = merchant.Id;
            if (ModelState.IsValid)
            {
                _context.Add(pickUpRequest);
                await _context.SaveChangesAsync();

                pickUpRequest.RequestId = "Req000" + pickUpRequest.Id.ToString();
                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MarchantIndex));
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", pickUpRequest.LocationFromId);
            return View(pickUpRequest);
        }

        // GET: PickUpRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests.FindAsync(id);
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", pickUpRequest.LocationFromId);
            return View(pickUpRequest);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests.Include(m => m.Packages).Where(m=>m.Id==id).FirstOrDefaultAsync();
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            if (pickUpRequest.Status < 4 || pickUpRequest.Status == 13)
            {
                _context.Remove(pickUpRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MarchantIndex));
            }
            else
            {
                return NotFound();
            }
        }

        // POST: PickUpRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PickUpRequest pickUpRequest)
        {
            if (id != pickUpRequest.Id)
            {
                return NotFound();
            }
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();

            pickUpRequest.RequestId = "Req000" + id.ToString();
            pickUpRequest.Status = 0;
            pickUpRequest.MerchantId = merchant.Id;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pickUpRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PickUpRequestExists(pickUpRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MarchantIndex));
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", pickUpRequest.LocationFromId);
            return View(pickUpRequest);
        }

        // GET: PickUpRequests/Delete/5


        private bool PickUpRequestExists(int id)
        {
            return _context.PickUpRequests.Any(e => e.Id == id);
        }

        public async Task<IActionResult> ForwardToAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests.Include(m => m.Packages)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            else
            {
                var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                var merchant = await _context.Merchants.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();
                if (merchant.Id == pickUpRequest.MerchantId)
                {
                    pickUpRequest.RequestDate = DateTime.Now;
                    pickUpRequest.TotalPackageNumber = pickUpRequest.Packages.Count;
                    pickUpRequest.Status = 2;
                    _context.Update(pickUpRequest);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(MarchantIndex));

                }
                else
                {
                    return NotFound();
                }


            }

        }
        public async Task<IActionResult> ApproveByAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            else
            {
                pickUpRequest.Status = 3;
                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AdminIndex));
            }

        }
        public async Task<IActionResult> PickedUpByAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            else
            {
                pickUpRequest.Status = 3;
                pickUpRequest.PickUpDate = DateTime.Now;
                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AdminIndex));
            }

        }
        public async Task<IActionResult> DeclineByAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUpRequest = await _context.PickUpRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickUpRequest == null)
            {
                return NotFound();
            }
            else
            {
                pickUpRequest.Status = 13;
                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AdminIndex));
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
                .Include(m => m.Packages)
                .ThenInclude(m => m.PackageCatagory.CatagoryType)


                .Include(m => m.Packages)
                .ThenInclude(m => m.PackageType)
                .Where(m => m.Id == id).FirstOrDefaultAsync();
            if (packageReq == null)
            {
                return NotFound();
            }

            bool finalizable = false;
            var packs = packageReq.Packages.Where(m => m.Status == 0).ToList();
            if (packs.Count == 0)
            {
                finalizable = true;
            }
            ViewData["Finalizable"] = finalizable;
            ViewData["CatagoryTypes"] = await _context.CatagoryTypes.ToListAsync();
            ViewData["Catagories"] = await _context.PackageCatagories.Include(m => m.CatagoryType).Where(m => m.Status == 1).ToListAsync();
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", packageReq.LocationFromId);
            ViewData["PackageTypeId"] = await _context.PackageTypes.Where(m => m.Status == 1).ToListAsync();
            ViewData["SubLocationId"] = await _context.SubLocations.Where(m => m.Status == 1).ToListAsync();
            ViewData["Locations"] = await _context.Locations.Where(m => m.Status == 1).ToListAsync();
            return View(packageReq);
        }
        public async Task<IActionResult> MatchPackages(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageReq = await _context.PickUpRequests
                .Include(m => m.LocationFrom)
                .Include(m => m.Merchant)
                .Include(m => m.PickUpDeliveryMan)
                .Include(m => m.Packages)
                .ThenInclude(m => m.LocationTo)
                 .Include(m => m.Packages)
                .ThenInclude(m => m.PackageCatagory)
                .Include(m => m.Packages)
                .ThenInclude(m => m.PackageCatagory.CatagoryType)
                  .Include(m => m.Packages)
                .ThenInclude(m => m.PackageType)
                .Where(m => m.Id == id).FirstOrDefaultAsync();
            if (packageReq == null)
            {
                return NotFound();
            }

            bool finalizable = false;
            var packs = packageReq.Packages.Where(m => m.Status != 1).ToList();
            if (packs.Count == 0)
            {
                finalizable = true;
            }
            ViewData["Finalizable"] = finalizable;
            ViewData["CatagoryTypes"] = await _context.CatagoryTypes.ToListAsync();
            ViewData["Catagories"] = await _context.PackageCatagories.Include(m => m.CatagoryType).Where(m => m.Status == 1).ToListAsync();
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", packageReq.LocationFromId);
            ViewData["PackageTypeId"] = await _context.PackageTypes.Where(m => m.Status == 1).ToListAsync();
            ViewData["SubLocationId"] = await _context.SubLocations.Where(m => m.Status == 1).ToListAsync();
            ViewData["Locations"] = await _context.Locations.Where(m => m.Status == 1).ToListAsync();
            return View(packageReq);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FileUpload(PickUpRequest pickUpRequest)
        {
            var pickUp = await _context.PickUpRequests.Where(m => m.Id == pickUpRequest.Id).FirstOrDefaultAsync();

            IFormFile aFile = pickUpRequest.UploadedFile;

            var stream = new MemoryStream();
            aFile.CopyTo(stream);
            stream.Position = 0;
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                int i = 0;
                while (reader.Read()) //Each row of the file
                {
                    i++;
                    if (i != 1)
                    {
                        Package package = new Package();
                        //package.PackageCatagoryId = catagoryId;
                        //package.LocationToId = locationToId;

                        string locationToStr = reader.GetValue(0).ToString();
                        string subLocationToStr = reader.GetValue(1).ToString();
                        string productSubCatagoryStr = reader.GetValue(2).ToString();
                        string productTypeStr = reader.GetValue(3).ToString();

                        var locationTo = await _context.Locations.Where(m => m.Name == locationToStr).FirstOrDefaultAsync();
                        var subLocationTo = await _context.SubLocations.Where(m => m.Name == subLocationToStr).FirstOrDefaultAsync();
                        var productSubCatagory = await _context.PackageCatagories.Where(m => m.Name == productSubCatagoryStr).FirstOrDefaultAsync();
                        var productType = await _context.PackageTypes.Where(m => m.Name == productTypeStr).FirstOrDefaultAsync();

                        if (locationTo != null)
                        {
                            package.LocationToId = locationTo.Id;
                        }
                        if (subLocationTo != null)
                        {
                            package.SubLocationId = subLocationTo.Id;
                        }

                         if (productType != null)
                        {
                            package.PackageTypeId = productType.Id;
                        }


                        if (productSubCatagory != null)
                        {
                            package.PackageCatagoryId = productSubCatagory.Id;
                        }



                        package.ClientName = reader.GetValue(4).ToString();
                        package.Address = reader.GetValue(5).ToString(); ;
                        package.PhoneNumber = reader.GetValue(6).ToString(); ;
                        package.Details = reader.GetValue(7).ToString(); ;
                        package.Weight = (double)reader.GetValue(8);
                        package.ProductPrice = (double)reader.GetValue(9);
                        package.Remarks =reader.GetValue(10).ToString();
                        package.SellingPrice =(double)reader.GetValue(11);
                        // package.Price = delivaryPrice;

                        package.Status = 0;

                        if (package.PackageCatagoryId != null && package.LocationToId != null && package.Weight != null)
                        {
                            TarrifPriceViewModel tarrifPriceViewModel = Tarrif.GetDesiredTarrif(pickUp.MerchantId, (int)package.PackageCatagoryId, pickUp.LocationFromId, (int)package.LocationToId, (double)package.Weight, _context);
                            package.Price = tarrifPriceViewModel.TotalPrice;


                        }

                        package.PickUpRequestId = pickUpRequest.Id;
                        _context.Add(package);
                        int res = await _context.SaveChangesAsync();

                    }

                }
            }
            return RedirectToAction("CreatePackages", new { id = pickUp.Id });
        }

    }
}
