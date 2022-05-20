using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BikesWebApplication;
using Microsoft.AspNetCore.Authorization;

namespace BikesWebApplication.Controllers
{
    public class ShopsController : Controller
    {
        private readonly DBLytvynenkoContext _context;

        public ShopsController(DBLytvynenkoContext context)
        {
            _context = context;
        }

        // GET: Shops
        public async Task<IActionResult> Index()
        {
            var dBLytvynenkoContext = _context.Shops.Include(s => s.BikesInColors).Include(s => s.City);
            return View(await dBLytvynenkoContext.ToListAsync());
        }

        // GET: Shops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Shops == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.BikesInColors)
                .Include(s => s.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // GET: Shops/Create
        public IActionResult Create()
        {
            ViewData["BikesInColorsId"] = new SelectList(_context.BikesInColors, "Id", "Id");
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id");
            return View();
        }

        // POST: Shops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BikesInColorsId,Name,CityId")] Shop shop)
        {
            
                _context.Add(shop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            /*ViewData["BikesInColorsId"] = new SelectList(_context.BikesInColors, "Id", "Id", shop.BikesInColorsId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", shop.CityId);
            return View(shop);*/
        }

        // GET: Shops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Shops == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            ViewData["BikesInColorsId"] = new SelectList(_context.BikesInColors, "Id", "Id", shop.BikesInColorsId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", shop.CityId);
            return View(shop);
        }

        // POST: Shops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BikesInColorsId,Name,CityId")] Shop shop)
        {
            if (id != shop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopExists(shop.Id))
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
            ViewData["BikesInColorsId"] = new SelectList(_context.BikesInColors, "Id", "Id", shop.BikesInColorsId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", shop.CityId);
            return View(shop);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Shops == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.BikesInColors)
                .Include(s => s.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Shops == null)
            {
                return Problem("Entity set 'DBLytvynenkoContext.Shops'  is null.");
            }
            var shop = await _context.Shops.FindAsync(id);
            if (shop != null)
            {
                _context.Shops.Remove(shop);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopExists(int id)
        {
          return (_context.Shops?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
