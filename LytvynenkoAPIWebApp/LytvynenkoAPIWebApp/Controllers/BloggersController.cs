using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LytvynenkoAPIWebApp.Models;

namespace LytvynenkoAPIWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggersController : Controller
    {
        private readonly LytvynenkoAPIContext _context;

        public BloggersController(LytvynenkoAPIContext context)
        {
            _context = context;
        }

        // GET: Bloggers
        public async Task<IActionResult> Index()
        {
              return _context.Bloggers != null ? 
                          View(await _context.Bloggers.ToListAsync()) :
                          Problem("Entity set 'LytvynenkoAPIContext.Bloggers'  is null.");
        }

        // GET: Bloggers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bloggers == null)
            {
                return NotFound();
            }

            var blogger = await _context.Bloggers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogger == null)
            {
                return NotFound();
            }

            return View(blogger);
        }

        // GET: Bloggers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bloggers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Blogger blogger)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogger);
        }

        // GET: Bloggers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bloggers == null)
            {
                return NotFound();
            }

            var blogger = await _context.Bloggers.FindAsync(id);
            if (blogger == null)
            {
                return NotFound();
            }
            return View(blogger);
        }

        // POST: Bloggers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Blogger blogger)
        {
            if (id != blogger.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogger);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloggerExists(blogger.Id))
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
            return View(blogger);
        }

        // GET: Bloggers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bloggers == null)
            {
                return NotFound();
            }

            var blogger = await _context.Bloggers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogger == null)
            {
                return NotFound();
            }

            return View(blogger);
        }

        // POST: Bloggers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bloggers == null)
            {
                return Problem("Entity set 'LytvynenkoAPIContext.Bloggers'  is null.");
            }
            var blogger = await _context.Bloggers.FindAsync(id);
            if (blogger != null)
            {
                _context.Bloggers.Remove(blogger);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloggerExists(int id)
        {
          return (_context.Bloggers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
