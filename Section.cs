using System.Collections.Generic;

namespace GardenApp
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }

        public List<Plant> Plants { get; set; }
    }
}
