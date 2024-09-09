namespace CP4.Services
{
    public class CountriesResponse
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public int Population { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public Dictionary<string, string> Currencies { get; set; }
    }
}
