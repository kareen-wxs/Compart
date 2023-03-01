using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ColvoMemoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ColvoMemoriesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: ColvoMemories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ColvoMemory.ToListAsync());
        }

        // GET: ColvoMemories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colvoMemory = await _context.ColvoMemory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colvoMemory == null)
            {
                return NotFound();
            }

            return View(colvoMemory);
        }

        // GET: ColvoMemories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ColvoMemories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ColvoMemory colvoMemory, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    colvoMemory.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/CM_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(colvoMemory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(colvoMemory);
        }

        // GET: ColvoMemories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colvoMemory = await _context.ColvoMemory.FindAsync(id);
            if (colvoMemory == null)
            {
                return NotFound();
            }
            return View(colvoMemory);
        }

        // POST: ColvoMemories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ColvoMemory colvoMemory, IFormFile titleImageFile)
        {
            if (id != colvoMemory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        colvoMemory.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/CM_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(colvoMemory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColvoMemoryExists(colvoMemory.Id))
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
            return View(colvoMemory);
        }

        // GET: ColvoMemories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colvoMemory = await _context.ColvoMemory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colvoMemory == null)
            {
                return NotFound();
            }

            return View(colvoMemory);
        }

        // POST: ColvoMemories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var colvoMemory = await _context.ColvoMemory.FindAsync(id);
            _context.ColvoMemory.Remove(colvoMemory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColvoMemoryExists(int id)
        {
            return _context.ColvoMemory.Any(e => e.Id == id);
        }
    }
}
