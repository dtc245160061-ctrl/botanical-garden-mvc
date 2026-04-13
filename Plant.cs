namespace GardenApp
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
