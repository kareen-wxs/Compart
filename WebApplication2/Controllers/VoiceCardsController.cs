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
using Microsoft.Extensions.Hosting.Internal;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class VoiceCardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public VoiceCardsController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: VoiceCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.VoiceCard.ToListAsync());
        }

        // GET: VoiceCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voiceCard = await _context.VoiceCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiceCard == null)
            {
                return NotFound();
            }

            return View(voiceCard);
        }

        // GET: VoiceCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VoiceCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( VoiceCard voiceCard, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {                            
                if (titleImageFile != null)
                {
                    voiceCard.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "img/VoiceCard_img/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _context.Add(voiceCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voiceCard);
        }

        // GET: VoiceCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voiceCard = await _context.VoiceCard.FindAsync(id);
            if (voiceCard == null)
            {
                return NotFound();
            }
            return View(voiceCard);
        }

        // POST: VoiceCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VoiceCard voiceCard, IFormFile titleImageFile)
        {
            if (id != voiceCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (titleImageFile != null)
                    {
                        voiceCard.TitleImagePath = titleImageFile.FileName;
                        using var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "img/VoiceCard_img/", titleImageFile.FileName), FileMode.Create);
                        titleImageFile.CopyTo(stream);
                    }
                    _context.Update(voiceCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoiceCardExists(voiceCard.Id))
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
            return View(voiceCard);
        }

        // GET: VoiceCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voiceCard = await _context.VoiceCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiceCard == null)
            {
                return NotFound();
            }

            return View(voiceCard);
        }

        // POST: VoiceCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voiceCard = await _context.VoiceCard.FindAsync(id);
            _context.VoiceCard.Remove(voiceCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoiceCardExists(int id)
        {
            return _context.VoiceCard.Any(e => e.Id == id);
        }
    }
}
