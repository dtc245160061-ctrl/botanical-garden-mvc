using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GardenApp.Models
{
    public class Plant
    {
        public int PlantId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Species { get; set; }

        public double Height { get; set; }

        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}
