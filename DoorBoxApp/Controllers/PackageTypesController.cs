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
    public class PackageTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PackageTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PackageTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PackageTypes.ToListAsync());
        }

        // GET: PackageTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageType = await _context.PackageTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageType == null)
            {
                return NotFound();
            }

            return View(packageType);
        }

        // GET: PackageTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PackageTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PackageType packageType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(packageType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(packageType);
        }

        // GET: PackageTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageType = await _context.PackageTypes.FindAsync(id);
            if (packageType == null)
            {
                return NotFound();
            }
            return View(packageType);
        }

        // POST: PackageTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,PackageType packageType)
        {
            if (id != packageType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packageType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackageTypeExists(packageType.Id))
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
            return View(packageType);
        }

        // GET: PackageTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageType = await _context.PackageTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageType == null)
            {
                return NotFound();
            }

            return View(packageType);
        }

        // POST: PackageTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var packageType = await _context.PackageTypes.FindAsync(id);
            _context.PackageTypes.Remove(packageType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackageTypeExists(int id)
        {
            return _context.PackageTypes.Any(e => e.Id == id);
        }


        public async Task<IActionResult> Enable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageType = await _context.PackageTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageType == null)
            {
                return NotFound();
            }
            else
            {
                packageType.Status = 1;
                _context.Update(packageType);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }
        public async Task<IActionResult> Disable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageType = await _context.PackageTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageType == null)
            {
                return NotFound();
            }
            else
            {
                packageType.Status = 0;
                _context.Update(packageType);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }

    }
}
