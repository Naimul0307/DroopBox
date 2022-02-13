using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using Microsoft.AspNetCore.Authorization;
using DoorBoxApp.Models.Common.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using DoorBoxApp.Models.ViewModels;
using System.Net.Http;
using System.Collections.Generic;

namespace DoorBoxApp.Controllers
{
    public class DeliveryMenController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public DeliveryMenController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeliveryMans.ToListAsync());
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminPaymentForDeilveyMenIndex()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            List<DeliveryManPaymentViewModel> deliverymanList = new List<DeliveryManPaymentViewModel>();
            foreach (var dm in deliveryMen)
            {
                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.DeliveryMan = dm;
                dMan.DeliveryManId = dm.Id;

                dMan.TotalDrop = await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.Status == 5).CountAsync();
                if (dm.Salary == 0)
                {
                    dMan.TotalPick = await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id).CountAsync();
                    dMan.TotalPayable = (dMan.TotalPick * dm.PickUpRate) + (dMan.TotalDrop * dm.DeliveryRate);
                    dMan.TotalPaid = (double)await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id && m.PickUpDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }
                else
                {
                    dMan.TotalPick = await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id).CountAsync();
                    dMan.TotalPayable = (dMan.TotalPick * dm.PickUpRate) + (dMan.TotalDrop * dm.DeliveryRate);
                    dMan.TotalPaid = (double)await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id && m.PickupDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }

                dMan.TotalDue = dMan.TotalPayable - dMan.TotalPaid;
                deliverymanList.Add(dMan);
            }


            return View(deliverymanList);
        }

        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> PaymentForDeilveyMenIndex()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            List<DeliveryManPaymentViewModel> deliverymanList = new List<DeliveryManPaymentViewModel>();
            foreach (var dm in deliveryMen)
            {
                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.DeliveryMan = dm;
                dMan.DeliveryManId = dm.Id;

                dMan.TotalDrop = await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.Status == 5).CountAsync();
                if (dm.Salary == 0)
                {
                    dMan.TotalPick = await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id).CountAsync();
                    dMan.TotalPayable = (dMan.TotalPick * dm.PickUpRate) + (dMan.TotalDrop * dm.DeliveryRate);
                    dMan.TotalPaid = (double)await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id && m.PickUpDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }
                else
                {
                    dMan.TotalPick = await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id).CountAsync();
                    dMan.TotalPayable = (dMan.TotalPick * dm.PickUpRate) + (dMan.TotalDrop * dm.DeliveryRate);
                    dMan.TotalPaid = (double)await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id && m.PickupDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }

                dMan.TotalDue = dMan.TotalPayable - dMan.TotalPaid;
                deliverymanList.Add(dMan);
            }


            return View(deliverymanList);
        }

        public async Task<IActionResult> DmPickDropReport(int id, DateTime fromDate, DateTime toDate)
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
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            List<DeliveryManPaymentViewModel> deliverymanList = new List<DeliveryManPaymentViewModel>();
            foreach (var dm in deliveryMen)
            {
                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.DeliveryMan = dm;
                dMan.DeliveryManId = dm.Id;
                dMan.TotalPick = await _context.Packages
               .Where(m => m.PickUpRequest.PickUpDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.PickUpRequest.PickUpDeliveryManId == dm.Id).OrderBy(m => m.PickUpRequest.PickUpDate).CountAsync();
                dMan.TotalDrop = await _context.Packages
               .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.Status == 5 && m.DeliveryManId == dm.Id).OrderBy(m => m.DeliveryDate).CountAsync();
                dMan.TotalCancel = await _context.Packages
              .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && (m.Status == 13 || m.Status == 14) && m.DeliveryManId == dm.Id).OrderBy(m => m.DeliveryDate).CountAsync();

                if (dm.Salary == 0)
                {
                    dMan.TotalPaid = (double)await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id && m.PickUpDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }
                else
                {
                    dMan.TotalPaid = (double)await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id && m.PickupDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }
                deliverymanList.Add(dMan);
            }

            ViewData["DeliveryMan"] = deliverymanList;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }
        [HttpPost]
        public IActionResult DmPickDropReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("DmPickDropReport", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }



        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DMAdminIndex()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();

            return View(deliveryMen);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DirectPickUp()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();

            ViewData["DeliveryManId"] = new SelectList(deliveryMen, "Id", "Name");

            ViewData["PickUpRequests"] = await _context.PickUpRequests.Include(m => m.Merchant).Include(m => m.Merchant.ApplicationUser).Where(m => (m.Status == 3) && m.PickUpDeliveryManId == null).ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DirectPickUp(AssignDMViewModel deliveryMan)
        {
            foreach (var pReq in deliveryMan.PickUpRequests)
            {
                var tmpPick = await _context.PickUpRequests.Where(m => m.Id == pReq).FirstOrDefaultAsync();
                tmpPick.PickUpDeliveryManId = deliveryMan.Id;
                _context.Update(tmpPick);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Home");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DirectDelivery()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            ViewData["Packages"] = await _context.Packages.Where(m => (m.Status == 2 || m.Status == 15) && m.DeliveryManId == null && m.VendorId == null).ToListAsync();
            ViewData["DeliveryManId"] = new SelectList(deliveryMen, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DirectDelivery(AssignDMViewModel deliveryMan)
        {
            foreach (var package in deliveryMan.Packages)
            {
                var tmpPackage = await _context.Packages.Where(m => m.Id == package).FirstOrDefaultAsync();
                tmpPackage.DeliveryManId = deliveryMan.Id;
                tmpPackage.AssignDate = DateTime.Now;
                tmpPackage.Status = 3;

                _context.Update(tmpPackage);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Home");
        }




        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> PickupPayment(int id)
        {
            var packagers = await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == id && !m.PickUpDeliveryManPaid && m.Status > 1)
                .Include(m => m.SubLocation)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.PickUpRequest.LocationFrom)
                .Include(m => m.PickUpRequest.PickUpDeliveryMan)


                .ToListAsync();

            ViewData["DeliveryMan"] = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(packagers);
        }
        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> PickupPaymentFixed(int id)
        {
            var pickUpRequests = await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == id && !m.PickupDeliveryManPaid && m.Status > 1)
                .Include(m => m.Merchant)
                .Include(m => m.LocationFrom)
                .Include(m => m.PickUpDeliveryMan)


                .ToListAsync();

            ViewData["DeliveryMan"] = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(pickUpRequests);
        }

        [Authorize(Roles = "Finance")]
        public async Task<IActionResult> DeliveryPayment(int id)
        {
            var packagers = await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == id && !m.DeliveryDeliveryManPaid && m.Status > 1)
                .Include(m => m.SubLocation)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.PickUpRequest.LocationFrom)
                .Include(m => m.PickUpRequest.PickUpDeliveryMan)


                .ToListAsync();

            ViewData["DeliveryMan"] = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(packagers);
        }





        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryMen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DeliveryMan deliveryMan)
        {
            if (ModelState.IsValid)
            {
                deliveryMan.Status = 0;
                _context.Add(deliveryMan);
                await _context.SaveChangesAsync();

                deliveryMan.DeliveryManIdNo = "DM000" + deliveryMan.Id.ToString();
                var checkDelivery = await _context.Users.Where(m => m.UserName == deliveryMan.DeliveryManIdNo).FirstOrDefaultAsync();

                if (checkDelivery != null)
                {
                    Random rnd = new Random();
                    deliveryMan.DeliveryManIdNo += rnd.Next(1, 256).ToString();
                }
                _context.Update(deliveryMan);
                int count = await _context.SaveChangesAsync();

                if (count == 1)
                {

                    var user = new ApplicationUser()
                    {
                        UserName = deliveryMan.DeliveryManIdNo,
                        Email = deliveryMan.Email,
                        UserTypeId = 3,
                        PhoneNumber = deliveryMan.PhoneNumber,
                        Status = 0
                    };
                    var result = await _userManager.CreateAsync(user, "Delivery123#");
                    deliveryMan.ApplicationUserId = user.Id;
                    _context.Update(deliveryMan);
                    await _context.SaveChangesAsync();
                    await _userManager.AddToRoleAsync(user, "DeliveryMan");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryMan);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMan = await _context.DeliveryMans.FindAsync(id);
            if (deliveryMan == null)
            {
                return NotFound();
            }
            return View(deliveryMan);
        }

        // POST: DeliveryMen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DeliveryMan deliveryMan)
        {
            if (id != deliveryMan.Id)
            {
                return NotFound();
            }
            var tempDeliveryMan = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();
            tempDeliveryMan.Name = deliveryMan.Name;
            tempDeliveryMan.Email = deliveryMan.Email;
            tempDeliveryMan.DeliveryRate = deliveryMan.DeliveryRate;
            tempDeliveryMan.PickUpRate = deliveryMan.PickUpRate;
            tempDeliveryMan.Salary = deliveryMan.Salary;
            tempDeliveryMan.NIDNumber = deliveryMan.NIDNumber;
            tempDeliveryMan.PhoneNumber = deliveryMan.PhoneNumber;
            tempDeliveryMan.Address = deliveryMan.Address;
            tempDeliveryMan.Status = 0;

            try
            {
                _context.Update(tempDeliveryMan);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryManExists(deliveryMan.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }


        private bool DeliveryManExists(int id)
        {
            return _context.DeliveryMans.Any(e => e.Id == id);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Enable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivaryMan = await _context.DeliveryMans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivaryMan == null)
            {
                return NotFound();
            }
            else
            {
                delivaryMan.Status = 1;
                _context.Update(delivaryMan);
                int count = await _context.SaveChangesAsync();
                if (count == 1)
                {
                    var user = await _userManager.FindByIdAsync(delivaryMan.ApplicationUserId);
                    await _userManager.AddToRoleAsync(user, "DeliveryMan");
                }

                return RedirectToAction(nameof(Index));
            }

        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Disable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivaryMan = await _context.DeliveryMans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivaryMan == null)
            {
                return NotFound();
            }
            else
            {
                delivaryMan.Status = 0;
                _context.Update(delivaryMan);
                int count = await _context.SaveChangesAsync();
                if (count == 1)
                {
                    var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                    await _userManager.RemoveFromRoleAsync(loggedInUser, "DeliveryMan");
                }


                return RedirectToAction(nameof(Index));
            }

        }

        [HttpPost]
        public async Task<JsonResult> AddPickupDelivaryMan(int id, int delivaryManId)
        {
            var pickUpRequest = await _context.PickUpRequests.Where(m => m.Id == id).FirstOrDefaultAsync();


            if (pickUpRequest != null)
            {
                pickUpRequest.PickUpDeliveryManId = delivaryManId;

                _context.Update(pickUpRequest);
                await _context.SaveChangesAsync();

                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AssignPackages(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMan = await _context.DeliveryMans.FindAsync(id);
            if (deliveryMan == null)
            {
                return NotFound();
            }
            AssignDMViewModel deliveryMan1 = new AssignDMViewModel();
            deliveryMan1.Id = deliveryMan.Id;
            deliveryMan1.Name = deliveryMan.Name;

            ViewData["Packages"] = await _context.Packages.Where(m => (m.Status == 2 || m.Status == 15) && m.DeliveryManId == null && m.VendorId == null).ToListAsync();
            return View(deliveryMan1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignPackages(AssignDMViewModel deliveryMan)
        {
            foreach (var package in deliveryMan.Packages)
            {
                var tmpPackage = await _context.Packages.Where(m => m.Id == package).FirstOrDefaultAsync();
                tmpPackage.DeliveryManId = deliveryMan.Id;
                tmpPackage.AssignDate = DateTime.Now;
                tmpPackage.Status = 3;
                tmpPackage.VendorId = null;
                _context.Update(tmpPackage);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "DeliveryMan")]
        public async Task<IActionResult> DeliveryPackages()
        {
            var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var deliveryMan = await _context.DeliveryMans.Where(m => m.ApplicationUserId == loggedInUser.Id).FirstOrDefaultAsync();

            if (deliveryMan == null)
            {
                return NotFound();
            }

            var todaysPackages = await _context.Packages
                .Include(p => p.PickUpRequest)
                .Include(p => p.PickUpRequest.PickUpDeliveryMan)
                .Include(p => p.PickUpRequest.Merchant)
                .Include(p => p.PickUpRequest.Merchant.ApplicationUser)
                .Include(p => p.PickUpRequest.LocationFrom)
                .Include(p => p.LocationTo)
                .Include(p => p.SubLocation)
                .Include(p => p.DeliveryMan)
                .Include(p => p.PackageCatagory)
                .Where(m => m.DeliveryManId == deliveryMan.Id && (m.Status == 3 || m.Status == 4 || m.Status == 5  ||  m.Status == 13 || m.Status == 16)).ToListAsync();
            if (todaysPackages == null)
            {
                return NotFound();
            }
            ViewData["DM"] = deliveryMan;

            return View(todaysPackages);
        }
        [Authorize(Roles = "DeliveryMan")]
        
        public async Task<IActionResult> SendOTP(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == id && m.Status == 3);
            if (package == null)
            {
                return NotFound();
            }
            else
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.mobireach.com.bd/");
                    var responseTask = client.GetAsync("SendTextMessage?Username=Doorbox&Password=Rabbi@123&From=8801842871143&To=" + package.PhoneNumber + "&Message=Dear Customer, Your parcel is delivered successfully. Please share this code " + package.OTP + " with the agent for confirmation only after receiving the parcel - Doorbox");
                    responseTask.Wait();
                    var result = responseTask.Result;

                }
                package.Status = 4;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(DeliveryPackages));
            }

        }

        public async Task<IActionResult> PartialDelivered(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == id && m.Status == 3);
            if (package == null)
            {
                return NotFound();
            }
            else
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.mobireach.com.bd/");
                    var responseTask = client.GetAsync("SendTextMessage?Username=Doorbox&Password=Rabbi@123&From=8801842871143&To=" + package.PhoneNumber + "&Message=Dear Customer, Your parcel is delivered successfully. Please share this code " + package.OTP + " with the agent for confirmation only after receiving the parcel - Doorbox");
                    responseTask.Wait();
                    var result = responseTask.Result;

                }
                package.Status = 16;
                _context.Update(package);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DeliveryPackages));
            }

        }


        [Authorize(Roles = "DeliveryMan")]
        public async Task<IActionResult> HoldPackage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .FirstOrDefaultAsync(m => m.Id == id && m.Status == 3);
            if (package == null)
            {
                return NotFound();
            }
            else
            {

                package.DeliveryManId = null;
                package.Status = 15;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(DeliveryPackages));
            }

        }

        [Authorize(Roles = "DeliveryMan")]
        public async Task<JsonResult> ReturnedByDM(string reason, int? packageId)
        {
            if (packageId == null)
            {
                return Json(false);
            }

            var package = await _context.Packages
                .Include(m => m.DeliveryMan)
                .Include(m => m.DeliveryMan.ApplicationUser)
                .Include(m => m.PickUpRequest)
                .Include(m => m.PickUpRequest.Merchant)
                .Include(m => m.LocationTo)
                .Include(m => m.PickUpRequest.Merchant.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == packageId);
            if (package == null)
            {
                return Json(false);
            }
            else
            {
                using (var client = new HttpClient())
                {
                    string message = "Dear Merchant, the parcel tracking id of " + package.TrackingNumber + ", " + package.ClientName + " and " + package.ProductPrice + " is being returned after 3 attempts by " + package.DeliveryMan.Name + "(" + package.DeliveryMan.DeliveryManIdNo + ")" + " (" + package.DeliveryMan.ApplicationUser.PhoneNumber + ").Reason: " + reason + ".Please share this OTP - " + package.OTP + " with agent if the reason is correct.";

                    client.BaseAddress = new Uri("https://api.mobireach.com.bd/");
                    var responseTask = client.GetAsync("SendTextMessage?Username=Doorbox&Password=Rabbi@123&From=8801842871143&To=" + package.PickUpRequest.Merchant.ApplicationUser.PhoneNumber + "&Message=" + message);
                    responseTask.Wait();

                    var result = responseTask.Result;

                }
                if (package.LocationTo.IsOutOfTown)
                {
                    package.Price = package.Price + (package.Price / 2);
                }

                package.Status = 13;
                package.DeliveryDate = DateTime.Now;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return Json(true);
            }

        }


        public async Task<IActionResult> PickUpReport(int id, DateTime fromDate, DateTime toDate)
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
            var deliveryMan = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

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
                .Where(m => m.Status != 0 && m.PickUpRequest.PickUpDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.PickUpRequest.PickUpDeliveryManId == id).OrderBy(m => m.PickUpRequest.PickUpDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }
        [HttpPost]
        public IActionResult PickUpReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("PickUpReport", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }

        public async Task<IActionResult> DeliveryReport(int id, DateTime fromDate, DateTime toDate)
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
            var deliveryMan = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.Status == 5 && m.DeliveryManId == id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult DeliveryReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("DeliveryReport", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }
        public async Task<IActionResult> PendingReport(int id, DateTime fromDate, DateTime toDate)
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
            var deliveryMan = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && (m.Status == 3 || m.Status == 4) && m.DeliveryManId == id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult PendingReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("PendingReport", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }
        public async Task<IActionResult> ReturnReport(int id, DateTime fromDate, DateTime toDate)
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
            var deliveryMan = await _context.DeliveryMans.Where(m => m.Id == id).FirstOrDefaultAsync();

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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && (m.Status == 13 || m.Status == 14) && m.DeliveryManId == id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult ReturnReport(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("ReturnReport", new { id = datesVM.Id, fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }


        public async Task<IActionResult> PickUpReportDM(DateTime fromDate, DateTime toDate)
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
                .Where(m => m.Status != 0 && m.PickUpRequest.PickUpDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.PickUpRequest.PickUpDeliveryManId == deliveryMan.Id).OrderBy(m => m.PickUpRequest.PickUpDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult PickUpReportDM(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("PickUpReportDM", new { fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }

        public async Task<IActionResult> DeliveryReportDM(DateTime fromDate, DateTime toDate)
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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && m.Status == 5 && m.DeliveryManId == deliveryMan.Id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult DeliveryReportDM(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("DeliveryReportDM", new { fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }
        public async Task<IActionResult> PendingReportDM(DateTime fromDate, DateTime toDate)
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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && (m.Status == 3 || m.Status == 4) && m.DeliveryManId == deliveryMan.Id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult PendingReportDM(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("PendingReportDM", new { fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }

        public async Task<IActionResult> ReturnReportDM(DateTime fromDate, DateTime toDate)
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
                .Where(m => m.Status != 0 && m.DeliveryDate >= fromDate && m.PickUpRequest.PickUpDate <= toDate && (m.Status == 13 || m.Status == 14) && m.DeliveryManId == deliveryMan.Id).OrderBy(m => m.DeliveryDate).ToListAsync();
            ViewData["DeliveryMan"] = deliveryMan;
            ViewData["Packages"] = packages;
            ViewData["FromDate"] = fromDate.Date;
            ViewData["ToDate"] = toDate.Date;
            return View();
        }

        [HttpPost]
        public IActionResult ReturnReportDM(FromDateToDateViewModel datesVM)
        {
            return RedirectToAction("ReturnReportDM", new { fromDate = datesVM.FromDate, toDate = datesVM.ToDate });

        }

        [HttpPost]
        public async Task<JsonResult> GetDelivaryMen()
        {
            var deliveryMen = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
            return Json(deliveryMen);

        }

        [HttpPost]
        public async Task<JsonResult> AddDeleverDelivaryMan(int delivaryManId, int packagesId)
        {
            var packegs = await _context.Packages.Where(m => m.Id == packagesId).FirstOrDefaultAsync();
            if(packegs.DeliveryManId == null)
            {
                packegs.DeliveryManId = delivaryManId;
            }
            packegs.AssignDate = DateTime.Now;
            packegs.Status = 3;
            packegs.VendorId = null;
            _context.Update(packegs);
            await _context.SaveChangesAsync();
            return Json(true);
        }
    }
}
