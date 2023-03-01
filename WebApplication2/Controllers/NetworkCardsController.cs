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
    public class NetworkCardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public NetworkCardsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: NetworkCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.NetworkCard.ToListAsync());
        }

        // GET: NetworkCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networkCard = await _context.NetworkCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (networkCard == null)
            {
                return NotFound();
            }

            return View(networkCard);
        }

        // GET: NetworkCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NetworkCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( NetworkCard networkCard, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    networkCard.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/NS_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(networkCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(networkCard);
        }

        // GET: NetworkCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networkCard = await _context.NetworkCard.FindAsync(id);
            if (networkCard == null)
            {
                return NotFound();
            }
            return View(networkCard);
        }

        // POST: NetworkCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NetworkCard networkCard, IFormFile titleImageFile)
        {
            if (id != networkCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        networkCard.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "img/NS_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(networkCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NetworkCardExists(networkCard.Id))
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
            return View(networkCard);
        }

        // GET: NetworkCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networkCard = await _context.NetworkCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (networkCard == null)
            {
                return NotFound();
            }

            return View(networkCard);
        }

        // POST: NetworkCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var networkCard = await _context.NetworkCard.FindAsync(id);
            _context.NetworkCard.Remove(networkCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NetworkCardExists(int id)
        {
            return _context.NetworkCard.Any(e => e.Id == id);
        }
    }
}
