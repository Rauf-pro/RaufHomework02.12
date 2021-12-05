using Microsoft.EntityFrameworkCore;
using RaufHomework02._12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.DATA
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Concerts> Concerts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryHover> GalleryHovers { get; set; }
        public DbSet<HoverToGallery> HoverToGalleries { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        

    }
}
