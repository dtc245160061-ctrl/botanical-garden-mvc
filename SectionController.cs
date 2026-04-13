using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GardenApp
{
    public class SectionController : Controller
    {
        public IActionResult Index()
        {
            var sections = new List<Section>
            {
                new Section
                {
                    SectionId = 1,
                    Name = "Tropical",
                    Plants = new List<Plant>
                    {
                        new Plant { PlantId = 1, Name = "Monstera", Species = "Monstera Deliciosa" },
                        new Plant { PlantId = 2, Name = "Banana", Species = "Musa" }
                    }
                },
                new Section
                {
                    SectionId = 2,
                    Name = "Desert",
                    Plants = new List<Plant>
                    {
                        new Plant { PlantId = 3, Name = "Cactus", Species = "Cactaceae" }
                    }
                }
            };

            return View(sections);
        }
    }
}
