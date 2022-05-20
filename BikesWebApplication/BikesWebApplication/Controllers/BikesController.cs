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
    public class BikesController : Controller
    {
        private readonly DBLytvynenkoContext _context;

        public BikesController(DBLytvynenkoContext context)
        {
            _context = context;
        }

        // GET: Bikes
        public async Task<IActionResult> Index()
        {
            var dBLytvynenkoContext = _context.Bikes.Include(b => b.Factory).Include(b => b.Size);
            return View(await dBLytvynenkoContext.ToListAsync());
        }

        // GET: Bikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bikes == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes
                .Include(b => b.Factory)
                .Include(b => b.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }

        // GET: Bikes/Create
        public IActionResult Create()
        {
            ViewData["FactoryId"] = new SelectList(_context.Factories, "Id", "Id");
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id");
            return View();
        }

        // POST: Bikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SizeId,FactoryId")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FactoryId"] = new SelectList(_context.Factories, "Id", "Id", bike.FactoryId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", bike.SizeId);
            return View(bike);
        }

        // GET: Bikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bikes == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes.FindAsync(id);
            if (bike == null)
            {
                return NotFound();
            }
            ViewData["FactoryId"] = new SelectList(_context.Factories, "Id", "Id", bike.FactoryId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", bike.SizeId);
            return View(bike);
        }

        // POST: Bikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SizeId,FactoryId")] Bike bike)
        {
            if (id != bike.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BikeExists(bike.Id))
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
            ViewData["FactoryId"] = new SelectList(_context.Factories, "Id", "Id", bike.FactoryId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", bike.SizeId);
            return View(bike);
        }

        // GET: Bikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bikes == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes
                .Include(b => b.Factory)
                .Include(b => b.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }

        // POST: Bikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bikes == null)
            {
                return Problem("Entity set 'DBLytvynenkoContext.Bikes'  is null.");
            }
            var bike = await _context.Bikes.FindAsync(id);
            if (bike != null)
            {
                _context.Bikes.Remove(bike);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BikeExists(int id)
        {
          return (_context.Bikes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
