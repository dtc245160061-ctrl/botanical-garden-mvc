using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GardenApp.Data;
using System.Linq;

namespace GardenApp.Controllers
{
    public class SectionController : Controller
    {
        private readonly GardenContext _context;

        public SectionController(GardenContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Sections
                .Include(s => s.Plants)
                .ToList();

            return View(data);
        }
    }
}
