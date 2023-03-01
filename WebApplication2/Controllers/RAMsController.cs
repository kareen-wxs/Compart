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
    public class RAMsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public RAMsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: RAMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.RAM.ToListAsync());
        }

        // GET: RAMs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAM = await _context.RAM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rAM == null)
            {
                return NotFound();
            }

            return View(rAM);
        }

        // GET: RAMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RAMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( RAM rAM, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    rAM.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/RAM_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(rAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rAM);
        }

        // GET: RAMs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAM = await _context.RAM.FindAsync(id);
            if (rAM == null)
            {
                return NotFound();
            }
            return View(rAM);
        }

        // POST: RAMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RAM rAM, IFormFile titleImageFile)
        {
            if (id != rAM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        rAM.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/RAM_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(rAM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RAMExists(rAM.Id))
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
            return View(rAM);
        }

        // GET: RAMs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rAM = await _context.RAM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rAM == null)
            {
                return NotFound();
            }

            return View(rAM);
        }

        // POST: RAMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rAM = await _context.RAM.FindAsync(id);
            _context.RAM.Remove(rAM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RAMExists(int id)
        {
            return _context.RAM.Any(e => e.Id == id);
        }
    }
}
