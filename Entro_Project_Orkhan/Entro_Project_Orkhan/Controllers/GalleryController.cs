using Entro_Project_Orkhan.Data;
using Entro_Project_Orkhan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro_Project_Orkhan.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;
        public GalleryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Gallery()
        {
            foreach (var item in _context.Settings)
            {
                TempData["GalleryText"] = item.GalleryText;
            }

            foreach (var Banner in _context.Banners)
            {
                if (Banner.Title == "Gallery")
                {
                    ViewBag.BannerTitle = Banner.Title;
                }
            }
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

            List<Gallery> gallery = _context.Galleries.ToList();
            return View(gallery);
        }
    }
}
