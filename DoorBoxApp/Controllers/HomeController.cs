using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoorBoxApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using DoorBoxApp.Models.Common.Authentication;
using DoorBoxApp.Data;
using DoorBoxApp.Models.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DoorBoxApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        //[Authorize(Roles = "GateAdmin, HarbourAndMarine, Mechanical, Admin, TMOffice")]
        public async Task<IActionResult> Index()
        {
            //Admin 1, Merchant 2, Rider 3, Finance 4
            var user = (await _userManager.FindByNameAsync(HttpContext.User.Identity.Name));
            if (await _userManager.IsInRoleAsync(user, "Admin")|| await _userManager.IsInRoleAsync(user, "Finance"))
            {
                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.TotalPick = await _context.Packages
               .Where(m => m.Status != 0).CountAsync();
                dMan.TotalDrop = await _context.Packages
               .Where(m => m.Status == 5).CountAsync();
              dMan.TotalCancel = await _context.Packages
              .Where(m =>(m.Status == 13 || m.Status == 14)).CountAsync();

                 dMan.TotalPending = await _context.Packages
                .Where(m => m.Status != 0 && (m.Status == 3 || m.Status == 4)).CountAsync();


                ViewData["Merchants"] = await _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 1).ToListAsync();
                ViewData["DeliveryMans"] = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
                ViewData["Detail"] = dMan;
                ViewData["User"] = 1;
                ViewData["IsNone"] = false;
            }
            else if (await _userManager.IsInRoleAsync(user, "Merchant"))
            {

                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.TotalPick = await _context.Packages
               .Where(m => m.Status != 0 && m.PickUpRequest.Merchant.ApplicationUserId == user.Id).CountAsync();
                dMan.TotalDrop = await _context.Packages
               .Where(m => m.Status != 0 && m.Status == 5 && m.PickUpRequest.Merchant.ApplicationUserId== user.Id).CountAsync();
                dMan.TotalCancel = await _context.Packages
                .Where(m => m.Status != 0 && (m.Status == 13 || m.Status == 14) && m.PickUpRequest.Merchant.ApplicationUserId == user.Id).CountAsync();

                dMan.TotalPending = await _context.Packages
              .Where(m => m.Status != 0 && (m.Status == 3 || m.Status == 4)&&m.PickUpRequest.Merchant.ApplicationUserId == user.Id).CountAsync();
                ViewData["Merchants"] = await _context.Merchants.Include(m => m.ApplicationUser).Where(m => m.ApplicationUser.Status == 1).ToListAsync();
                ViewData["DeliveryMans"] = await _context.DeliveryMans.Where(m => m.Status == 1).ToListAsync();
                ViewData["Detail"] = dMan;
                ViewData["Tarrifs"] = await _context.Tarrifs.Include(m => m.PackageCatagory).Include(m => m.LocationFrom).Include(m => m.LocationTo).Where(m => m.Status == 1).ToListAsync();
                ViewData["User"] = 2;
                ViewData["IsNone"] = false; 
                ViewData["Detail"] = dMan;


            }
             else if (await _userManager.IsInRoleAsync(user, "DeliveryMan"))
            {
                var dm = await _context.DeliveryMans.FirstOrDefaultAsync(m => m.ApplicationUserId == user.Id);
                DeliveryManPaymentViewModel dMan = new DeliveryManPaymentViewModel();
                dMan.TotalPick = await _context.Packages
               .Where(m =>  m.PickUpRequest.PickUpDeliveryMan.ApplicationUserId == user.Id).CountAsync();
                dMan.TotalDrop = await _context.Packages
               .Where(m => m.Status != 0 && m.Status == 5 && m.DeliveryManId == dm.Id).CountAsync();
                dMan.TotalCancel = await _context.Packages.Include(m => m.PickUpRequest).Include(m => m.PickUpRequest.Merchant).Include(m => m.DeliveryMan.ApplicationUser)
                .Where(m => m.Status != 0 && (m.Status == 13 || m.Status == 14) && m.PickUpRequest.Merchant.ApplicationUserId == user.Id).CountAsync();


                if (dm.Salary == 0)
                {
                  
                    dMan.TotalPaid = (double)await _context.Packages.Where(m => m.PickUpRequest.PickUpDeliveryManId == dm.Id && m.PickUpDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }
                else
                {
                   
                    dMan.TotalPaid = (double)await _context.PickUpRequests.Where(m => m.PickUpDeliveryManId == dm.Id && m.PickupDeliveryManPaid).SumAsync(m => m.PaidForPickUp) + (double)await _context.Packages.Where(m => m.DeliveryManId == dm.Id && m.DeliveryDeliveryManPaid).SumAsync(m => m.PaidForDelivery);
                }

               

                ViewData["Detail"] = dMan;
                ViewData["Tarrifs"] = await _context.Tarrifs.Include(m => m.PackageCatagory).Include(m => m.LocationFrom).Include(m => m.LocationTo).Where(m => m.Status == 1).ToListAsync();
                ViewData["User"] = 3;
                ViewData["IsNone"] = false;
            }
            else
            {
                ViewData["IsAdmin"] = false;
              ViewData["Tarrifs"] = await _context.Tarrifs.Include(m => m.PackageCatagory).Include(m => m.LocationFrom).Include(m => m.LocationTo).Where(m => m.Status == 1).ToListAsync();
                ViewData["User"] = 0;
            }
            
            return View();
        }

        public IActionResult AssignmentData(DateTime getDate, DateTime fromDate)
        {
            if (fromDate == default(DateTime))
            {
                fromDate = DateTime.Now.Date;
            }

            ViewData["Date"] = fromDate.Date;
            return View();
        }

      
        public IActionResult Privacy()
        {
            return View();
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
