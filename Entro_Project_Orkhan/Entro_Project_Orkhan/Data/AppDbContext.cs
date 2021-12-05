using System;
using Entro_Project_Orkhan.Models;
using Microsoft.EntityFrameworkCore;

namespace Entro_Project_Orkhan.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> option) :base(option)
        {

        }

        public DbSet<AboutUs> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertImage> ConcertImages { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }

    }
}
