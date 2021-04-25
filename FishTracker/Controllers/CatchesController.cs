using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishTracker.Models;

namespace FishTracker.Controllers
{
    public class CatchesController : Controller
    {
        private readonly FishTrackerContext _context;

        public CatchesController(FishTrackerContext context)
        {
            _context = context;
        }

        // GET: Catches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Catch.ToListAsync());
        }

        // GET: Catches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @catch = await _context.Catch
                .FirstOrDefaultAsync(m => m.CatchID == id);
            if (@catch == null)
            {
                return NotFound();
            }

            return View(@catch);
        }

        // GET: Catches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatchID,Species,Length,Weight,UserID")] Catch @catch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@catch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@catch);
        }

        // GET: Catches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @catch = await _context.Catch.FindAsync(id);
            if (@catch == null)
            {
                return NotFound();
            }
            return View(@catch);
        }

        // POST: Catches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatchID,Species,Length,Weight,UserID")] Catch @catch)
        {
            if (id != @catch.CatchID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@catch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatchExists(@catch.CatchID))
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
            return View(@catch);
        }

        // GET: Catches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @catch = await _context.Catch
                .FirstOrDefaultAsync(m => m.CatchID == id);
            if (@catch == null)
            {
                return NotFound();
            }

            return View(@catch);
        }

        // POST: Catches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @catch = await _context.Catch.FindAsync(id);
            _context.Catch.Remove(@catch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatchExists(int id)
        {
            return _context.Catch.Any(e => e.CatchID == id);
        }
    }
}
