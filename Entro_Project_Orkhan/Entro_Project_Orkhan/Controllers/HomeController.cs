using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entro_Project_Orkhan.Data;
using Entro_Project_Orkhan.Models;
using Entro_Project_Orkhan.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Entro_Project_Orkhan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
    public IActionResult Index()
        {
            
            ViewBag.isHomePage = true;

            foreach (var item in _context.Settings)
            {
                ViewBag.Logo = item.Logo;
                ViewBag.Address = item.Address;
                ViewBag.Phone = item.Phone;
                ViewBag.Email = item.Email;
                ViewBag.CopyrightLink = item.CopyrightLink;
                ViewBag.Copyright = item.Copyright;
            }
           
            List<Concert> concert = _context.Concerts.ToList();
            List<ConcertImage> concertImage = _context.ConcertImages.ToList();
            VmModel fullconcert = new VmModel();
            fullconcert.concert = concert;
            fullconcert.concertImage = concertImage;

            ViewData["Concert"] = fullconcert.concert;
            ViewData["ConcertImage"] = fullconcert.concertImage;
            ViewData["Socials"] = _context.Socials;
            ViewData["AboutUs"] = _context.Abouts;
            ViewData["Gallery"] = _context.Galleries;
            ViewData["Slider"] = _context.Sliders;
            List<Setting> setting = _context.Settings.ToList();

            return View(setting);
        }

        
    }
}
