using Berillium.DAL;
using Berillium.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Berillium.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context ;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            List<Slider> result = _context.Sliders.ToList();
            return View(result);
        }
        [Area("AdminPanel")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
