using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quarter.Models;
using Quarter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarter.Controllers
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
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Services = _context.Services.Take(3).ToList(),
                Tags = _context.Tags.ToList(),
                Statuses = _context.Statuses.ToList(),
                Cities = _context.Cities.ToList(),
                Settings = _context.Settings.ToList(),
                Categories = _context.Categories.ToList(),
                FeaturedProduct = _context.Products.Include(x=>x.Team).Include(x=>x.ProductImages).Where(x=>!x.IsFeatured).ToList()
            };
            return View(homeVM);
        }
    }
}
