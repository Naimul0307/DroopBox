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
    public class SubLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubLocations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SubLocations.Include(s => s.Location);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SubLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subLocation = await _context.SubLocations
                .Include(s => s.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subLocation == null)
            {
                return NotFound();
            }

            return View(subLocation);
        }

        // GET: SubLocations/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name");
            return View();
        }

        // POST: SubLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubLocation subLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", subLocation.LocationId);
            return View(subLocation);
        }

        // GET: SubLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subLocation = await _context.SubLocations.FindAsync(id);
            if (subLocation == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", subLocation.LocationId);
            return View(subLocation);
        }

        // POST: SubLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SubLocation subLocation)
        {
            if (id != subLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubLocationExists(subLocation.Id))
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
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", subLocation.LocationId);
            return View(subLocation);
        }

        // GET: SubLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subLocation = await _context.SubLocations
                .Include(s => s.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subLocation == null)
            {
                return NotFound();
            }

            return View(subLocation);
        }

        // POST: SubLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subLocation = await _context.SubLocations.FindAsync(id);
            _context.SubLocations.Remove(subLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubLocationExists(int id)
        {
            return _context.SubLocations.Any(e => e.Id == id);
        }


        public async Task<IActionResult> Enable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subLocation = await _context.SubLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subLocation == null)
            {
                return NotFound();
            }
            else
            {
                subLocation.Status = 1;
                _context.Update(subLocation);
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

            var subLocation = await _context.SubLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subLocation == null)
            {
                return NotFound();
            }
            else
            {
                subLocation.Status = 0;
                _context.Update(subLocation);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }

        [HttpPost]
        public async Task<JsonResult> GetSubLocationByLocationId(int locationId)

        {
            var subLocations = await _context.SubLocations.Where(m => m.LocationId == locationId).ToListAsync();
            
                return Json(subLocations);
        }

    }
}
