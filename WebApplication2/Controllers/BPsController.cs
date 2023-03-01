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
    public class BPsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BPsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: BPs
        public async Task<IActionResult> Index()
        {
            return View(await _context.BP.ToListAsync());
        }

        // GET: BPs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bP = await _context.BP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bP == null)
            {
                return NotFound();
            }

            return View(bP);
        }

        // GET: BPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BP bP, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    bP.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/BP_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(bP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bP);
        }

        // GET: BPs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bP = await _context.BP.FindAsync(id);
            if (bP == null)
            {
                return NotFound();
            }
            return View(bP);
        }

        // POST: BPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BP bP, IFormFile titleImageFile)
        {
            if (id != bP.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BPExists(bP.Id))
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
            return View(bP);
        }

        // GET: BPs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bP = await _context.BP
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bP == null)
            {
                return NotFound();
            }

            return View(bP);
        }

        // POST: BPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bP = await _context.BP.FindAsync(id);
            _context.BP.Remove(bP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BPExists(int id)
        {
            return _context.BP.Any(e => e.Id == id);
        }
    }
}
