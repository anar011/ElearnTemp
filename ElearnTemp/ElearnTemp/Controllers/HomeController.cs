
using ElearnTemp.Data;
using ElearnTemp.Models;
using ElearnTemp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ElearnTemp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            IEnumerable<Author> authors = await _context.Authors.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.CourseImages).Include(m => m.Author).Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Event> events = await _context.Events.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<LatestNews> latestNews = await _context.LatestNewss.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<LatestNewsAuthor> latestNewsAuthors = await _context.LatestNewsAuthors.Where(m => !m.SoftDelete).ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                Authors = authors,
                Courses = courses,
                Events = events,
                LatestNewss = latestNews,
                LatestNewsAuthors = latestNewsAuthors
                

            };

            return View(model);



        }


       

    }
}