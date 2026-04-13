using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GardenApp.Models
{
    public class Section
    {
        public int SectionId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Climate { get; set; }

        public double Size { get; set; }

        public List<Plant> Plants { get; set; }
    }
}
