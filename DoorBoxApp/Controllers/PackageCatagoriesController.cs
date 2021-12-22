using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoorBoxApp.Controllers
{

    [Authorize(Roles = "Admin")]
    public class PackageCatagoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PackageCatagoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PackageCatagories
        public async Task<IActionResult> Index()
        {
            return View(await _context.PackageCatagories.Include(m=>m.CatagoryType).ToListAsync());
        }


        // GET: PackageCatagories/Create
        public IActionResult Create()
        {
            ViewData["CatagoryTypeId"] = new SelectList(_context.CatagoryTypes, "Id", "Name");
            return View();
        }

        // POST: PackageCatagories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PackageCatagory packageCatagory)
        {
            packageCatagory.Status = 0;
            if (ModelState.IsValid)
            {
                _context.Add(packageCatagory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(packageCatagory);
        }

        // GET: PackageCatagories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageCatagory = await _context.PackageCatagories.FindAsync(id);
            if (packageCatagory == null)
            {
                return NotFound();
            }

            ViewData["CatagoryTypeId"] = new SelectList(_context.CatagoryTypes, "Id", "Name", packageCatagory.CatagoryTypeId);
            return View(packageCatagory);
        }

        // POST: PackageCatagories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PackageCatagory packageCatagory)
        {
            packageCatagory.Status = 0;
            if (id != packageCatagory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packageCatagory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackageCatagoryExists(packageCatagory.Id))
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
            ViewData["CatagoryTypeId"] = new SelectList(_context.CatagoryTypes, "Id", "Name", packageCatagory.CatagoryTypeId);
            return View(packageCatagory);
        }

        public async Task<IActionResult> Enable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packageCatagory = await _context.PackageCatagories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageCatagory == null)
            {
                return NotFound();
            }
            else
            {
                packageCatagory.Status = 1;
                _context.Update(packageCatagory);
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

            var packageCatagory = await _context.PackageCatagories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packageCatagory == null)
            {
                return NotFound();
            }
            else
            {
                packageCatagory.Status = 0;
                _context.Update(packageCatagory);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }


       
        
        private bool PackageCatagoryExists(int id)
        {
            return _context.PackageCatagories.Any(e => e.Id == id);
        }
    }
}
