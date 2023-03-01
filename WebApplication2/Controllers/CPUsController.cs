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
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CPUsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CPUsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: CPUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CPU.ToListAsync());
        }

        // GET: CPUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cPU = await _context.CPU
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cPU == null)
            {
                return NotFound();
            }

            return View(cPU);
        }

        // GET: CPUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CPUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CPU cPU,IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    cPU.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/CPU_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(cPU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cPU);
        }

        // GET: CPUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cPU = await _context.CPU.FindAsync(id);
            if (cPU == null)
            {
                return NotFound();
            }
            return View(cPU);
        }

        // POST: CPUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CPU cPU, IFormFile titleImageFile)
        {
            if (id != cPU.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        cPU.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/CPU_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(cPU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CPUExists(cPU.Id))
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
            return View(cPU);
        }

        // GET: CPUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cPU = await _context.CPU
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cPU == null)
            {
                return NotFound();
            }

            return View(cPU);
        }

        // POST: CPUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cPU = await _context.CPU.FindAsync(id);
            _context.CPU.Remove(cPU);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CPUExists(int id)
        {
            return _context.CPU.Any(e => e.Id == id);
        }
    }
}
