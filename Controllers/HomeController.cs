using Berillium.DAL;
using Berillium.Models;
using Berillium.ViewModels.HomeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Berillium.Controllers
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
            HomeVM result = new HomeVM()
            {
                Title = "Berillium",
                Slider = _context.Sliders.ToList()
            };
     
            return View(result);
        }     
        
    }
}
