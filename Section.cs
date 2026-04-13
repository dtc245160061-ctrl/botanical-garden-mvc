using System.Collections.Generic;

namespace GardenApp
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Climate { get; set; }
        public double Size { get; set; }

        public List<Plant> Plants { get; set; }
    }
}
