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
    public class GPUsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GPUsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: GPUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.VideoCard.ToListAsync());
        }

        // GET: GPUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPU = await _context.VideoCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gPU == null)
            {
                return NotFound();
            }

            return View(gPU);
        }

        // GET: GPUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GPUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( GPU gPU, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    gPU.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/GPU_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(gPU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gPU);
        }

        // GET: GPUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPU = await _context.VideoCard.FindAsync(id);
            if (gPU == null)
            {
                return NotFound();
            }
            return View(gPU);
        }

        // POST: GPUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GPU gPU, IFormFile titleImageFile)
        {
            if (id != gPU.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        gPU.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/GPU_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(gPU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GPUExists(gPU.Id))
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
            return View(gPU);
        }

        // GET: GPUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPU = await _context.VideoCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gPU == null)
            {
                return NotFound();
            }

            return View(gPU);
        }

        // POST: GPUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gPU = await _context.VideoCard.FindAsync(id);
            _context.VideoCard.Remove(gPU);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GPUExists(int id)
        {
            return _context.VideoCard.Any(e => e.Id == id);
        }
    }
}
