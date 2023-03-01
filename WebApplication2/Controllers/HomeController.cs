using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
       
            _context = context;
        }
        public IActionResult Privacy()
        {
            var CPU = _context.CPU.ToList();
            ViewBag.CPU = new SelectList(CPU, "Id", "Name");

            var Matplata = _context.MotherBoard.ToList();
            ViewBag.Matplata = new SelectList(Matplata, "Id", "Name");

            var GPU = _context.VideoCard.ToList();
            ViewBag.GPU = new SelectList(GPU, "Id", "Name");

            var RAM = _context.RAM.ToList();
            ViewBag.RAM = new SelectList(RAM, "Id", "Name");

            var Case = _context.Case.ToList();
            ViewBag.Case = new SelectList(Case, "Id", "Name");

            var Cooler = _context.Cooler.ToList();
            ViewBag.Cooler = new SelectList(Cooler, "Id", "Name");

            var CoolingSystem = _context.CoolingSystem.ToList();
            ViewBag.CoolingSystem = new SelectList(CoolingSystem, "Id", "Name");

            var DVD = _context.DVD.ToList();
            ViewBag.DVD = new SelectList(DVD, "Id", "Name");

            var NetworkCard = _context.NetworkCard.ToList();
            ViewBag.NetworkCard = new SelectList(NetworkCard, "Id", "Name");

            var ColvoMemory = _context.ColvoMemory.ToList();
            ViewBag.ColvoMemory = new SelectList(ColvoMemory, "Id", "Name");

            var TypeofMemory = _context.TypeOfMemory.ToList();
            ViewBag.TypeofMemory = new SelectList(TypeofMemory, "Id", "Name");

            var VoiceCard = _context.VoiceCard.ToList();
            ViewBag.VoiceCard = new SelectList(VoiceCard, "Id", "Name");

            var BP = _context.BP.ToList();
            ViewBag.BP = new SelectList(BP, "Id", "Name");

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sotrudnichestvo()
        {
            return View();
        }

        public IActionResult Cities()
        {
            return View();
        }
        
        public IActionResult Qwerty()
        {
            ViewBag.CPU = _context.CPU.ToList();

            ViewBag.Matplata = _context.MotherBoard.ToList();

            ViewBag.GPU = _context.VideoCard.ToList();

            ViewBag.RAM = _context.RAM.ToList();

            ViewBag.Case = _context.Case.ToList();

            ViewBag.Cooler = _context.Cooler.ToList();

            ViewBag.CoolingSystem = _context.CoolingSystem.ToList();

            ViewBag.DVD = _context.DVD.ToList();

            ViewBag.NetworkCard = _context.NetworkCard.ToList();

            ViewBag.ColvoMemory = _context.ColvoMemory.ToList();

            ViewBag.TypeofMemory = _context.TypeOfMemory.ToList();

            ViewBag.VoiceCard = _context.VoiceCard.ToList();

            ViewBag.BP = _context.BP.ToList();
            return View();
        }
        public IActionResult All()
        {
            return View();
        }   
        public IActionResult Contakty()
        {
            return View();
        } 
        public IActionResult Finish()
        {
            return View();
        }
        
        public IActionResult O_nas()
        {
            return View();
        }
        public IActionResult All_Сonfigurator()
        {
            return View();
        }
        public IActionResult All_Finished_assembly()
        {
            return View();
        }
        public IActionResult All_Periphery()
        {
            return View();
        }

    }
}
