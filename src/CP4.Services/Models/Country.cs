namespace CP4.Services.Models
{
    public class CountryResponse
    {
        public string Name { get; set; }
        public Flags Flags { get; set; }
        public string Common { get; set; }
        public string Png { get; set; }
        public string Svg { get; set; }
    }

    public class Flags
    {
        public string Png { get; set; }
        public string Svg { get; set; }
    }
}

