using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entro_Project_Orkhan.Data;
using Entro_Project_Orkhan.Models;
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

            foreach (var item in _context.Socials)
            {
                if (item.Id == 1)
                {
                    ViewBag.Facebook = item.Name;
                    ViewBag.FacebookIcon = item.Icon;
                    ViewBag.FacebookLink = item.Link;
                }
                if (item.Id == 2)
                {
                    ViewBag.Twitter = item.Name;
                    ViewBag.TwitterIcon = item.Icon;
                    ViewBag.TwitterLink = item.Link;
                }
                if (item.Id == 3)
                {
                    ViewBag.Linkedin = item.Name;
                    ViewBag.LinkedinIcon = item.Icon;
                    ViewBag.LinkedinLink = item.Link;
                }
                if (item.Id == 4)
                {
                    ViewBag.Instagram = item.Name;
                    ViewBag.InstagramIcon = item.Icon;
                    ViewBag.InstagramLink = item.Link;
                }


            }
            List<Setting> setting = _context.Settings.ToList();

            return View(setting);
        }

        
    }
}
