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
    public class BloggerChannelsController : Controller
    {
        private readonly LytvynenkoAPIContext _context;

        public BloggerChannelsController(LytvynenkoAPIContext context)
        {
            _context = context;
        }

        // GET: BloggerChannels
        public async Task<IActionResult> Index()
        {
            var lytvynenkoAPIContext = _context.BloggerChannels.Include(b => b.Channel);
            return View(await lytvynenkoAPIContext.ToListAsync());
        }

        // GET: BloggerChannels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BloggerChannels == null)
            {
                return NotFound();
            }

            var bloggerChannel = await _context.BloggerChannels
                .Include(b => b.Channel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bloggerChannel == null)
            {
                return NotFound();
            }

            return View(bloggerChannel);
        }

        // GET: BloggerChannels/Create
        public IActionResult Create()
        {
            ViewData["ChannelId"] = new SelectList(_context.Channels, "Id", "Title");
            return View();
        }

        // POST: BloggerChannels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChannelId")] BloggerChannel bloggerChannel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloggerChannel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChannelId"] = new SelectList(_context.Channels, "Id", "Title", bloggerChannel.ChannelId);
            return View(bloggerChannel);
        }

        // GET: BloggerChannels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BloggerChannels == null)
            {
                return NotFound();
            }

            var bloggerChannel = await _context.BloggerChannels.FindAsync(id);
            if (bloggerChannel == null)
            {
                return NotFound();
            }
            ViewData["ChannelId"] = new SelectList(_context.Channels, "Id", "Title", bloggerChannel.ChannelId);
            return View(bloggerChannel);
        }

        // POST: BloggerChannels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChannelId")] BloggerChannel bloggerChannel)
        {
            if (id != bloggerChannel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloggerChannel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloggerChannelExists(bloggerChannel.Id))
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
            ViewData["ChannelId"] = new SelectList(_context.Channels, "Id", "Title", bloggerChannel.ChannelId);
            return View(bloggerChannel);
        }

        // GET: BloggerChannels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BloggerChannels == null)
            {
                return NotFound();
            }

            var bloggerChannel = await _context.BloggerChannels
                .Include(b => b.Channel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bloggerChannel == null)
            {
                return NotFound();
            }

            return View(bloggerChannel);
        }

        // POST: BloggerChannels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BloggerChannels == null)
            {
                return Problem("Entity set 'LytvynenkoAPIContext.BloggerChannels'  is null.");
            }
            var bloggerChannel = await _context.BloggerChannels.FindAsync(id);
            if (bloggerChannel != null)
            {
                _context.BloggerChannels.Remove(bloggerChannel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloggerChannelExists(int id)
        {
          return (_context.BloggerChannels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
