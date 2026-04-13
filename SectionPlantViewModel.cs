using System.Collections.Generic;
using GardenApp.Models;

namespace GardenApp.ViewModels
{
    public class SectionPlantViewModel
    {
        public Section Section { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
