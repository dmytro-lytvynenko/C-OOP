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
    public class BikesInColorsController : Controller
    {
        private readonly DBLytvynenkoContext _context;

        public BikesInColorsController(DBLytvynenkoContext context)
        {
            _context = context;
        }

        // GET: BikesInColors
        public async Task<IActionResult> Index()
        {
            var dBLytvynenkoContext = _context.BikesInColors.Include(b => b.Bikes).Include(b => b.Colors);
            return View(await dBLytvynenkoContext.ToListAsync());
        }

        // GET: BikesInColors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BikesInColors == null)
            {
                return NotFound();
            }

            var bikesInColor = await _context.BikesInColors
                .Include(b => b.Bikes)
                .Include(b => b.Colors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bikesInColor == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Shops", new { id = bikesInColor.Id, bike = bikesInColor.BikesId, amount = bikesInColor.Amount, price = bikesInColor.Price, color = bikesInColor.ColorsId });
        }

        // GET: BikesInColors/Create
        public IActionResult Create()
        {
            ViewData["BikesId"] = new SelectList(_context.Bikes, "Id", "Id");
            ViewData["ColorsId"] = new SelectList(_context.Colors, "Id", "Id");
            return View();
        }

        // POST: BikesInColors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Amount,BikesId,ColorsId")] BikesInColor bikesInColor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bikesInColor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BikesId"] = new SelectList(_context.Bikes, "Id", "Id", bikesInColor.BikesId);
            ViewData["ColorsId"] = new SelectList(_context.Colors, "Id", "Id", bikesInColor.ColorsId);
            return View(bikesInColor);
        }

        // GET: BikesInColors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BikesInColors == null)
            {
                return NotFound();
            }

            var bikesInColor = await _context.BikesInColors.FindAsync(id);
            if (bikesInColor == null)
            {
                return NotFound();
            }
            ViewData["BikesId"] = new SelectList(_context.Bikes, "Id", "Id", bikesInColor.BikesId);
            ViewData["ColorsId"] = new SelectList(_context.Colors, "Id", "Id", bikesInColor.ColorsId);
            return View(bikesInColor);
        }

        // POST: BikesInColors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Amount,BikesId,ColorsId")] BikesInColor bikesInColor)
        {
            if (id != bikesInColor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bikesInColor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BikesInColorExists(bikesInColor.Id))
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
            ViewData["BikesId"] = new SelectList(_context.Bikes, "Id", "Id", bikesInColor.BikesId);
            ViewData["ColorsId"] = new SelectList(_context.Colors, "Id", "Id", bikesInColor.ColorsId);
            return View(bikesInColor);
        }

        // GET: BikesInColors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BikesInColors == null)
            {
                return NotFound();
            }

            var bikesInColor = await _context.BikesInColors
                .Include(b => b.Bikes)
                .Include(b => b.Colors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bikesInColor == null)
            {
                return NotFound();
            }

            return View(bikesInColor);
        }

        // POST: BikesInColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BikesInColors == null)
            {
                return Problem("Entity set 'DBLytvynenkoContext.BikesInColors'  is null.");
            }
            var bikesInColor = await _context.BikesInColors.FindAsync(id);
            if (bikesInColor != null)
            {
                _context.BikesInColors.Remove(bikesInColor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BikesInColorExists(int id)
        {
          return (_context.BikesInColors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
