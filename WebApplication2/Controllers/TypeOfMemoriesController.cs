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
    public class TypeOfMemoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TypeOfMemoriesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: TypeOfMemories
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeOfMemory.ToListAsync());
        }

        // GET: TypeOfMemories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfMemory = await _context.TypeOfMemory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfMemory == null)
            {
                return NotFound();
            }

            return View(typeOfMemory);
        }

        // GET: TypeOfMemories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfMemories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( TypeOfMemory typeOfMemory, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    typeOfMemory.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/TOM_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(typeOfMemory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfMemory);
        }

        // GET: TypeOfMemories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfMemory = await _context.TypeOfMemory.FindAsync(id);
            if (typeOfMemory == null)
            {
                return NotFound();
            }
            return View(typeOfMemory);
        }

        // POST: TypeOfMemories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypeOfMemory typeOfMemory, IFormFile titleImageFile)
        {
            if (id != typeOfMemory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        typeOfMemory.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/TOM_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(typeOfMemory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfMemoryExists(typeOfMemory.Id))
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
            return View(typeOfMemory);
        }

        // GET: TypeOfMemories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfMemory = await _context.TypeOfMemory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfMemory == null)
            {
                return NotFound();
            }

            return View(typeOfMemory);
        }

        // POST: TypeOfMemories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfMemory = await _context.TypeOfMemory.FindAsync(id);
            _context.TypeOfMemory.Remove(typeOfMemory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfMemoryExists(int id)
        {
            return _context.TypeOfMemory.Any(e => e.Id == id);
        }
    }
}
