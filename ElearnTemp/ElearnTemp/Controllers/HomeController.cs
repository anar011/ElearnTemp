
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


            HomeVM model = new()
            {
                Sliders = sliders,

            };

            return View(model);



        }


       

    }
}