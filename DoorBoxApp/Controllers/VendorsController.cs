using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using DoorBoxApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;

namespace DoorBoxApp.Controllers
{
    public class VendorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.Vendors.ToListAsync());
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address")] Vendor vendor)
        {
            if (id != vendor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.Id))
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
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);
            _context.Vendors.Remove(vendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return _context.Vendors.Any(e => e.Id == id);
        }



        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AssignPackagesToVendor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            AssignDMViewModel deliveryMan1 = new AssignDMViewModel();
            deliveryMan1.Id = vendor.Id;
            deliveryMan1.Name = vendor.Name;

            ViewData["Packages"] = await _context.Packages.Where(m => (m.Status == 2 || m.Status == 15) && m.DeliveryManId == null && m.VendorId == null).ToListAsync();
            return View(deliveryMan1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignPackagesToVendor(AssignDMViewModel deliveryMan)
        {
            foreach (var package in deliveryMan.Packages)
            {
                var tmpPackage = await _context.Packages.Where(m => m.Id == package).FirstOrDefaultAsync();
                tmpPackage.VendorId = deliveryMan.Id;
                tmpPackage.AssignDate = DateTime.Now;
                tmpPackage.Status = 4;
                tmpPackage.DeliveryManId = null;
                _context.Update(tmpPackage);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AssignedPackagesVendor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages.Where(m=>m.VendorId==id)
                .Include(m=>m.PickUpRequest)
                .Include(m=>m.PickUpRequest.Merchant)
                .ToListAsync();
            ViewData["Vendor"] = await _context.Vendors.Where(m => m.Id == id).FirstOrDefaultAsync();
            return View(packages);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleveredByVendor(int? id,int vendorId)
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
                package.Status = 5;
                package.DeliveryDate = DateTime.Now;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction("AssignedPackagesVendor", new { id = vendorId });
            }

        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MessageByVendor(int? id, int vendorId, string message = null)
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
                package.Message = message;
                package.DeliveryDate = DateTime.Now;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction("AssignedPackagesVendor", new { id = vendorId });
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ReturnedByVendor(int? id, int vendorId)
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
                package.Price = package.Price + (package.Price / 2);
                package.Status = 13;
                package.DeliveryDate = DateTime.Now;
                _context.Update(package);
                await _context.SaveChangesAsync();

                return RedirectToAction("AssignedPackagesVendor", new { id = vendorId });
            }

        }


        [HttpPost]
        public async Task<JsonResult> GetVendor()
        {
            var vendor = await _context.Vendors.ToListAsync();
            return Json(vendor);

        }

        [HttpPost]
        public async Task<JsonResult> AssignVendor(int vendorsId, int packagesId)
        {
            var packegs = await _context.Packages.Where(m => m.Id == packagesId).FirstOrDefaultAsync();
            if(packegs.VendorId == null)
            {
                packegs.VendorId = vendorsId;
            }
            packegs.AssignDate = DateTime.Now;
            packegs.Status = 3;
            packegs.DeliveryManId = null;
            _context.Update(packegs);
            await _context.SaveChangesAsync();
            return Json(true);
        }

    }
}
