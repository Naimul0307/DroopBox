using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;

namespace DoorBoxApp.Controllers
{
    public class MerchantTarrifsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MerchantTarrifsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MerchantTarrifs
        public async Task<IActionResult> Index(int merchantId)
        {
            var applicationDbContext = _context.MerchantTarrifs.Include(m => m.LocationFrom).Include(m => m.LocationTo).Include(m => m.Merchant).Include(m => m.PackageCatagory).Where(m=>m.MerchantId== merchantId);
            var merchant = await _context.Merchants.Where(m => m.Id == merchantId).FirstOrDefaultAsync();


            ViewData["Merchant"] = merchant;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MerchantTarrifs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantTarrif = await _context.MerchantTarrifs
                .Include(m => m.LocationFrom)
                .Include(m => m.LocationTo)
                .Include(m => m.Merchant)
                .Include(m => m.PackageCatagory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchantTarrif == null)
            {
                return NotFound();
            }

            return View(merchantTarrif);
        }

        // GET: MerchantTarrifs/Create
        public IActionResult Create(int merchantId)
        {
            ViewData["MerchantId"] =  merchantId;
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name");
            ViewData["LocationToId"] = new SelectList(_context.Locations, "Id", "Name");
            ViewData["PackageCatagoryId"] = new SelectList(_context.PackageCatagories, "Id", "Name");
            return View();
        }

        // POST: MerchantTarrifs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( MerchantTarrif merchantTarrif)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchantTarrif);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { merchantId = merchantTarrif.MerchantId });
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationFromId);
            ViewData["LocationToId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationToId);
           
            ViewData["PackageCatagoryId"] = new SelectList(_context.PackageCatagories, "Id", "Name", merchantTarrif.PackageCatagoryId);
            return View(merchantTarrif);
        }

        // GET: MerchantTarrifs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantTarrif = await _context.MerchantTarrifs.FindAsync(id);
            if (merchantTarrif == null)
            {
                return NotFound();
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationFromId);
            ViewData["LocationToId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationToId);
            ViewData["PackageCatagoryId"] = new SelectList(_context.PackageCatagories, "Id", "Name", merchantTarrif.PackageCatagoryId);
            return View(merchantTarrif);
        }

        // POST: MerchantTarrifs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MerchantTarrif merchantTarrif)
        {
            if (id != merchantTarrif.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchantTarrif);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchantTarrifExists(merchantTarrif.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { merchantId = merchantTarrif.MerchantId });
            }
            ViewData["LocationFromId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationFromId);
            ViewData["LocationToId"] = new SelectList(_context.Locations, "Id", "Name", merchantTarrif.LocationToId);
            ViewData["PackageCatagoryId"] = new SelectList(_context.PackageCatagories, "Id", "Name", merchantTarrif.PackageCatagoryId);
            return View(merchantTarrif);
        }

        // GET: MerchantTarrifs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantTarrif = await _context.MerchantTarrifs
                .Include(m => m.LocationFrom)
                .Include(m => m.LocationTo)
                .Include(m => m.Merchant)
                .Include(m => m.PackageCatagory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchantTarrif == null)
            {
                return NotFound();
            }

            return View(merchantTarrif);
        }

        // POST: MerchantTarrifs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var merchantTarrif = await _context.MerchantTarrifs.FindAsync(id);
            _context.MerchantTarrifs.Remove(merchantTarrif);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchantTarrifExists(int id)
        {
            return _context.MerchantTarrifs.Any(e => e.Id == id);

        }


        public async Task<IActionResult> Enable(int? id,int? merchantId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantTarrif = await _context.MerchantTarrifs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchantTarrif == null)
            {
                return NotFound();
            }
            else
            {
                merchantTarrif.Status = 1;
                _context.Update(merchantTarrif);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", new { merchantId = merchantId });
            }

        }
        public async Task<IActionResult> Disable(int? id, int? merchantId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantTarrif = await _context.MerchantTarrifs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchantTarrif == null)
            {
                return NotFound();
            }
            else
            {
                merchantTarrif.Status = 0;
                _context.Update(merchantTarrif);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { merchantId = merchantId });
            }

        }


    }
}
