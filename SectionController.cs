using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GardenApp
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
