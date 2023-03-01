using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Finished_assemblyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Finished_assemblyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Finished_assembly
        public async Task<IActionResult> Index()
        {
            return View(await _context.Finished_assembly.ToListAsync());
        }

        // GET: Finished_assembly/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finished_assembly = await _context.Finished_assembly
                .FirstOrDefaultAsync(m => m.Id == id);
            if (finished_assembly == null)
            {
                return NotFound();
            }

            return View(finished_assembly);
        }

        // GET: Finished_assembly/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Finished_assembly/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Finished_assembly finished_assembly)
        {
            if (ModelState.IsValid)
            {
                _context.Add(finished_assembly);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(finished_assembly);
        }

        // GET: Finished_assembly/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finished_assembly = await _context.Finished_assembly.FindAsync(id);
            if (finished_assembly == null)
            {
                return NotFound();
            }
            return View(finished_assembly);
        }

        // POST: Finished_assembly/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Finished_assembly finished_assembly)
        {
            if (id != finished_assembly.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(finished_assembly);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Finished_assemblyExists(finished_assembly.Id))
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
            return View(finished_assembly);
        }

        // GET: Finished_assembly/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finished_assembly = await _context.Finished_assembly
                .FirstOrDefaultAsync(m => m.Id == id);
            if (finished_assembly == null)
            {
                return NotFound();
            }

            return View(finished_assembly);
        }

        // POST: Finished_assembly/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var finished_assembly = await _context.Finished_assembly.FindAsync(id);
            _context.Finished_assembly.Remove(finished_assembly);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Finished_assemblyExists(int id)
        {
            return _context.Finished_assembly.Any(e => e.Id == id);
        }
    }
}
